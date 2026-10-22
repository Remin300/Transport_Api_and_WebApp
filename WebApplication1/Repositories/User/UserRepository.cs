using LinqToDB;
using LinqToDB.Async;
using System.Data.Common;
using WebApplication1.Obiekty_ORM.ObiektyORMLinq2DB.Urzytkownicy;
using WebApplication1.ObiektyORMLinq2DB.Grupy_Dzialy_Filtry;
using WebApplication1.ObiektyORMLinq2DB.ZleceniaSpedycja;
using WebApplication1.Repositories.User.DTO;
using WebApplication1.Repositories.User.Mappers;
using WebApplication1.Repositories.User.Queries;
using WebApplication1.Repositories.User.Validators;
using WebApplication1.Tools;

namespace WebApplication1.Repositories.User
{
    public class UserRepository : IUserRepository
    {
        private readonly ILogger<UserRepository> _logger;
        public UserRepository(ILogger<UserRepository> logger)
        {
            _logger = logger;
        }
        public async Task<Login_User_Response_Dto?> LoginAsync(string login, string password)
        {


            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
                return null;

            try
            {
                using (var dbConnection = DbConnectionLinq2DB.GetConnection())
                {
                    var user = await dbConnection.GetTable<Users_ORM>()
                             .FirstOrDefaultAsync(u => u.LOGIN == login);

                    if (user == null)
                        return null;

                    bool passwordOk = PasswordHasher.VerifyPassword(password, user.PASS_NOWY_PROGRAM);

                    if (!passwordOk)
                        return null;

                    var dostepneOddzialy = dbConnection.GetTable<Users_Odzialy_ORM>()
                           .Where(x => x.IDUSER == user.ID_USER)
                           .Select(x => x.IDODDZIALY)
                           .ToList();

                    var dostepneFiltry = dbConnection.GetTable<Users_FiltryPrzych_ORM>()
                         .Where(x => x.ID_USER == user.ID_USER)
                         .Select(x => x.ID_FILTRY_PRZYCH)
                         .ToList();

                    Login_User_Response_Dto login_response = new Login_User_Response_Dto();

                    login_response.id = user.ID_USER;
                    login_response.username = user.LOGIN;
                    login_response.dostepneOddzialy = dostepneOddzialy;
                    login_response.dostepneFiltry = dostepneFiltry;


                    return login_response;

                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Błąd podczas logowania",
                     login);
                return null;
            }
        }

        public async Task<GetAppCache_Dto?> GetAppCache(int userId)
        {
            try
            {
                using (var dbConnection = DbConnectionLinq2DB.GetConnection())
                {
                   var dostepneOddzialy = dbConnection.GetTable<Users_Odzialy_ORM>()
                       .Where(x => x.IDUSER == userId)
                       .Select(x => x.IDODDZIALY)
                       .ToList();
                    var oddzialy = dbConnection.GetTable<Oddzialy_ORM>()
                          .Where(x => dostepneOddzialy.Contains(x.ID_OT)) // Filtruj tylko te oddziały, które są na liście przypisanych oddziałów
                              .Select(x => new AppCacheSelectOption_Dto
                              {
                                  id = x.ID_OT,
                                  nazwa = x.NAZWA
                              })
                          .ToList();

                    var dostepneFiltry = dbConnection.GetTable<Users_FiltryPrzych_ORM>()
                               .Where(x => x.ID_USER == userId)
                               .Select(x => x.ID_FILTRY_PRZYCH)
                               .ToList();
                    var filtryPrzych = dbConnection.GetTable<FiltrPrzych_ORM>()
                           .Where(x => dostepneFiltry.Contains(x.ID_FILTRY_PRZYCH)) // Filtruj tylko te oddziały, które są na liście przypisanych oddziałów
                          .Select(x => new AppCacheSelectOption_Dto
                          {
                              id = x.ID_FILTRY_PRZYCH,
                              nazwa = x.OPIS
                          })
                          .ToList();


                    var users = dbConnection.GetTable<Users_ORM>() 
                          .Where(x => x.VISIBLE == 1) // Wyklucz aktualnego użytkownika
                          .Select(x => new AppCacheSelectOption_Dto
                          {
                              id = x.ID_USER,
                              nazwa = x.LOGIN
                          })
                          .ToList();


                    GetAppCache_Dto login_response = new GetAppCache_Dto();

                    login_response.Oddzialy = oddzialy;
                    login_response.FiltryDodatkowe = filtryPrzych;
                    login_response.Users = users;

                    return login_response;

                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Błąd podczas pobierania AppCache");
                return null;
            }
        }


        public async Task<Result<Update_User_DTO>> GetByIdAsync(int userId)
        {
            try
            {
                using (var db = DbConnectionLinq2DB.GetConnection())
                {
                    var user = await db.GetTable<Users_ORM>().FirstOrDefaultAsync(x => x.ID_USER == userId);

                    if (user == null)
                    {
                        return Result<Update_User_DTO>.Fail("Nie znaleziono zlecenia o podanym ID.", ErrorType.NotFound);
                    }

                    var dto = Users_Mappers.Fom_User_to_Update_User_DTO_Mapper(user);


                    return Result<Update_User_DTO>.Ok(dto);
                }
            }
            catch (Exception ex)
            {


                return Result<Update_User_DTO>.Fail("Błąd serwera: " + ex.Message, ErrorType.Failure);
            }
        }

        public async Task<Result> Update_User_Basic_Info_Async(int userId, Update_User_DTO body)
        {
            try
            {
                using (var db = DbConnectionLinq2DB.GetConnection())
                {
                    var user = await db.GetTable<Users_ORM>().FirstOrDefaultAsync(x => x.ID_USER == userId);

                    if (user == null)
                    {
                        return Result<Update_User_DTO>.Fail("Nie znaleziono użytkownika o podanym ID.", ErrorType.NotFound);
                    }

                    var validator = new Update_User_DTO_Validator();

                    var validationResult = await validator.ValidateAsync(body);

                    if (!validationResult.IsValid)
                    {
                        var errors = string.Join("; ", validationResult.Errors.Select(x => x.ErrorMessage));

                        return Result.Fail(errors, ErrorType.Validation);
                    }



                    Users_Mappers.From_Update_User_DTO_to_User_Mapper(user, body);


                    await db.UpdateAsync(user);


                    return Result.Ok();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Błąd podczas edycji danych usera",
                    body.LOGIN);

                return Result.Fail("Błąd serwera: " + ex.Message, ErrorType.Failure);

            }
        }

        public async Task<Result> Update_User_Pass_Async(int userId, Update_User_Pass_Dto body)
        {
            try
            {
                using (var db = DbConnectionLinq2DB.GetConnection())
                {
                    var user = await db.GetTable<Users_ORM>().FirstOrDefaultAsync(x => x.ID_USER == userId);

                    if (user == null)
                    {
                        return Result<Update_User_DTO>.Fail("Nie znaleziono zlecenia o podanym ID.", ErrorType.NotFound);
                    }


                    bool passwordOk = PasswordHasher.VerifyPassword(body.oldPass, user.PASS_NOWY_PROGRAM);
                    if (!passwordOk)
                    {
                        return Result<Update_User_DTO>.Fail("Stare hasło jest nieprawidłowe.", ErrorType.Validation);
                    }

                    user.PASS_NOWY_PROGRAM = PasswordHasher.HashPassword(body.newPass);
                    user.PASSCHANGED = DateTime.Now;

                    await db.UpdateAsync(user);


                    return Result.Ok();
                }
            }
            catch (Exception ex)
            {
                return Result.Fail("Błąd serwera: " + ex.Message, ErrorType.Failure);
            }
        }

        public async Task<Result<User_List_Response_Dto>> Get_User_List(int userId, Get_User_List_Query query)
        {
            try
            {
                using (var db = DbConnectionLinq2DB.GetConnection())
                {
                    var User = await db.GetTable<Users_ORM>().FirstOrDefaultAsync(x => x.ID_USER == userId);

                    // Tylko admin może usunąć zlecenie
                    if (!User.KOD.Contains("A"))
                    {
                        return Result<User_List_Response_Dto>.Fail(
                               "Brak uprawnień do wykonania tej operacji.",
                               ErrorType.Forbidden);
                    }


                    var user_list = db.GetTable<Users_ORM>().AsQueryable();

                    if (!string.IsNullOrEmpty(query.LOGIN))
                    {
                        user_list = user_list.Where(x => x.LOGIN.ToLower().Contains(query.LOGIN.ToLower()));
                    }
                    if (!string.IsNullOrEmpty(query.IMIE))
                    {
                        user_list = user_list.Where(x => x.IMIE.ToLower().Contains(query.IMIE.ToLower()));
                    }
                    if (!string.IsNullOrEmpty(query.NAZWISKO))
                    {
                        user_list = user_list.Where(x => x.NAZWISKO.ToLower().Contains(query.NAZWISKO.ToLower()));
                    }

                    // policz wszystkie rekordy
                    int totalItems = user_list.Count();

                    int itemsPerPage = 50;
                    int offset = (query.PageNo - 1) * itemsPerPage;


                    var lista = await user_list
                        .Select(x => new User_Dto
                        {
                            ID_USER = x.ID_USER,
                            LOGIN = x.LOGIN,
                            IMIE = x.IMIE,
                            NAZWISKO = x.NAZWISKO,
                            ADRES = x.ADRES,
                            MIASTO = x.MIASTO
                        })
                        .OrderBy(x => x.LOGIN)
                        .Skip(offset)
                        .Take(itemsPerPage)
                        .ToListAsync();



                    var response = new User_List_Response_Dto
                    {
                        TotalItems = totalItems,
                        TotalPages = (int)Math.Ceiling(totalItems / (double)itemsPerPage),
                        PageNo = query.PageNo,
                        UserList = lista
                    };


                    return Result<User_List_Response_Dto>.Ok(response);
                }
            }
            catch (Exception ex)
            {
                return Result<User_List_Response_Dto>.Fail("Błąd serwera: " + ex.Message, ErrorType.Failure);
            }
        }

        public async Task<Result<GetAllUserInfo_Dto>> GetAllInfoByIdAsync(int userId)
        {
            try
            {
                using (var db = DbConnectionLinq2DB.GetConnection())
                {
                    var user = await db.GetTable<Users_ORM>().FirstOrDefaultAsync(x => x.ID_USER == userId);

                    if (user == null)
                    {
                        return Result<GetAllUserInfo_Dto>.Fail("Nie znaleziono użytkownika o podanym ID.", ErrorType.NotFound);
                    }


                    Update_User_AllInfo_DTO dto = new Update_User_AllInfo_DTO();

                     dto = Users_Mappers.Fom_User_to_Update_User_AllInfo_DTO_Mapper(user, dto);

                    var dostepneOddzialy = db.GetTable<Users_Odzialy_ORM>()
                             .Where(x => x.IDUSER == userId)
                             .Select(x => x.IDODDZIALY)
                             .ToList();

                    var dostepneFiltry = db.GetTable<Users_FiltryPrzych_ORM>()
                              .Where(x => x.ID_USER == userId)
                              .Select(x => x.ID_FILTRY_PRZYCH)
                              .ToList();


                    dto.listaIdDodatkoweFiltry = dostepneFiltry;
                    dto.listaIdOddzialy = dostepneOddzialy;

                    GetAllUserInfo_Dto dto_response = new GetAllUserInfo_Dto
                    {
                        user = dto,
                        Dzialy = await db.GetTable<Oddzialy_ORM>()
                            .Select(x => new AppCacheSelectOption_Dto
                            {
                                id = x.ID_OT,
                                nazwa = x.NAZWA
                            })
                            .ToListAsync(),
                        Filtry = await db.GetTable<FiltrPrzych_ORM>()
                            .Select(x => new AppCacheSelectOption_Dto
                            {
                                id = x.ID_FILTRY_PRZYCH,
                                nazwa = x.OPIS
                            })
                            .ToListAsync()
                    };


                    return Result<GetAllUserInfo_Dto>.Ok(dto_response);
                }
            }
            catch (Exception ex)
            {
                return Result<GetAllUserInfo_Dto>.Fail("Błąd serwera: " + ex.Message, ErrorType.Failure);
            }
        }

        public async Task<Result> Update_User_All_Info_Async(int userId, int id, Update_User_AllInfo_DTO dto)
        {

            using var db = DbConnectionLinq2DB.GetConnection();
            using var transaction = db.BeginTransaction();

            try
            {
                var User = await db.GetTable<Users_ORM>().FirstOrDefaultAsync(x => x.ID_USER == userId);

                // Tylko admin może usunąć zlecenie
                if (!User.KOD.Contains("A"))
                {
                    return Result<User_List_Response_Dto>.Fail(
                           "Brak uprawnień do wykonania tej operacji.",
                           ErrorType.Forbidden);
                }


                var user = await db.GetTable<Users_ORM>().FirstOrDefaultAsync(x => x.ID_USER == id);

                if (user == null)
                {
                    return Result<Update_User_DTO>.Fail("Nie znaleziono użytkownika o podanym ID.", ErrorType.NotFound);
                }

                var validator = new Update_User_AllInfo_DTO_Validator();

                var validationResult = await validator.ValidateAsync(dto);

                if (!validationResult.IsValid)
                {
                    var errors = string.Join("; ", validationResult.Errors.Select(x => x.ErrorMessage));

                    return Result.Fail(errors, ErrorType.Validation);
                }



                Users_Mappers.From_Update_User_AllInfo_DTO_to_User_Mapper(user, dto);


                await db.UpdateAsync(user);

             
                    // Usuń dotychczasowe przypisania użytkownika
                    await db.GetTable<Users_Odzialy_ORM>()
                    .Where(x => x.IDUSER == user.ID_USER)
                    .DeleteAsync();

                if (dto.listaIdOddzialy != null)
                {
                    // Dodaj nowe przypisania
                    foreach (int idOddzialu in dto.listaIdOddzialy.Distinct())
                    {
                        var nowy = new Users_Odzialy_ORM
                        {
                            IDUSER = user.ID_USER,
                            IDODDZIALY = idOddzialu
                        };

                        await db.InsertAsync(nowy);
                    }
                }

            

        

                    // Usuń dotychczasowe przypisania użytkownika
                    await db.GetTable<Users_FiltryPrzych_ORM>()
                    .Where(x => x.ID_USER == user.ID_USER)
                    .DeleteAsync();

                if (dto.listaIdDodatkoweFiltry != null)
                {

                    // Dodaj nowe przypisania
                    foreach (int idFiltru in dto.listaIdDodatkoweFiltry.Distinct())
                    {
                        var nowy = new Users_FiltryPrzych_ORM
                        {
                            ID_USER = user.ID_USER,
                            ID_FILTRY_PRZYCH = idFiltru
                        };

                        await db.InsertAsync(nowy);
                    }
                }



                transaction.Commit();


                return Result.Ok();
            }
            catch (Exception ex)
            {
                transaction.Rollback();

                _logger.LogError(ex, "Błąd podczas edycji danych usera",
                     dto.LOGIN);

                return Result<User_List_Response_Dto>.Fail("Błąd serwera: " + ex.Message, ErrorType.Failure);
            }

        }

        public async Task<Result> Reset_User_Pass_Async(int userId, int id, string newPass)
        {
            try
            {
                using (var db = DbConnectionLinq2DB.GetConnection())
                {
                    var User = await db.GetTable<Users_ORM>().FirstOrDefaultAsync(x => x.ID_USER == userId);

                    // Tylko admin może usunąć zlecenie
                    if (!User.KOD.Contains("A"))
                    {
                        return Result<User_List_Response_Dto>.Fail(
                               "Brak uprawnień do wykonania tej operacji.",
                               ErrorType.Forbidden);
                    }


                    var user = await db.GetTable<Users_ORM>().FirstOrDefaultAsync(x => x.ID_USER == id);

                    if (user == null)
                    {
                        return Result<Update_User_DTO>.Fail("Nie znaleziono zlecenia o podanym ID.", ErrorType.NotFound);
                    }


                    user.PASS_NOWY_PROGRAM = PasswordHasher.HashPassword(newPass);
                    user.PASSCHANGED = DateTime.Now;

                    await db.UpdateAsync(user);


                    return Result.Ok();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Błąd podczas resetowania hasła",
                $"User id = {userId}");

                return Result.Fail("Błąd serwera: " + ex.Message, ErrorType.Failure);
            }
        }

        public async Task<Result> Delete_User_async(int id, int userId)
        {
            try
            {
                using (var db = DbConnectionLinq2DB.GetConnection()) 
                {
                    var user_to_delete = await db.GetTable<Users_ORM>()
                        .FirstOrDefaultAsync(x => x.ID_USER == id);

                    if (user_to_delete == null)
                    {
                        return Result.Fail(
                            "Nie znaleziono użytkownika o podanym ID.",
                            ErrorType.NotFound);
                    }

                    var User = await db.GetTable<Users_ORM>().FirstOrDefaultAsync(x => x.ID_USER == userId);


                    // Tylko admin może usunąć zlecenie
                    if (!User.KOD.Contains("A"))
                    {
                        return Result.Fail(
                               "Brak uprawnień do wykonania tej operacji.",
                               ErrorType.Forbidden);
                    }

                    await db.DeleteAsync(user_to_delete);
                    _logger.LogInformation(
                            "Usunięto użytkownika. UserId: {UserId}, NumerUżytkownika: {NumerUżytkownika}",
                            userId,
                            user_to_delete.LOGIN);

                    return Result.Ok();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Błąd podczas usuwania użytkownika");
                return Result<int>.Fail("Błąd serwera: " + ex.Message, ErrorType.Failure);

            }
        }

        public async Task<Result<int>> Create_User_Async(Create_User_Dto dto)
        {
            using var db = DbConnectionLinq2DB.GetConnection();
            using var transaction = db.BeginTransaction();

            try
            {

                var validator = new Create_User_Dto_Validator();

                var validationResult = await validator.ValidateAsync(dto);

                if (!validationResult.IsValid)
                {
                    var errors = string.Join("; ", validationResult.Errors.Select(x => x.ErrorMessage));

                    return Result<int>.Fail(errors, ErrorType.Validation);
                }



                var new_user = Users_Mappers.From_Create_User_Dto_to_User_Mapper(dto);


                // Wstawienie rekordu i uzyskanie nowego ID
                var new_user_Id = await db.InsertWithIdentityAsync(new_user);

                // Przypisanie nowego ID do obiektu
                new_user.ID_USER = Convert.ToInt32(new_user_Id);

     
                if (dto.listaIdOddzialy != null)
                {
                    // Dodaj nowe przypisania
                    foreach (int idOddzialu in dto.listaIdOddzialy.Distinct())
                    {
                        var nowy = new Users_Odzialy_ORM
                        {
                            IDUSER = new_user.ID_USER,
                            IDODDZIALY = idOddzialu
                        };

                        await db.InsertAsync(nowy);
                    }
                }


                if (dto.listaIdDodatkoweFiltry != null)
                {

                    // Dodaj nowe przypisania
                    foreach (int idFiltru in dto.listaIdDodatkoweFiltry.Distinct())
                    {
                        var nowy = new Users_FiltryPrzych_ORM
                        {
                            ID_USER = new_user.ID_USER,
                            ID_FILTRY_PRZYCH = idFiltru
                        };

                        await db.InsertAsync(nowy);
                    }
                }



                transaction.Commit();


                return Result<int>.Ok(new_user.ID_USER);
            }
            catch (Exception ex)
            {
                transaction.Rollback();

                _logger.LogError(ex, "Błąd podczas edycji danych usera",
                     dto.LOGIN);

                return Result<int>.Fail("Błąd serwera: " + ex.Message, ErrorType.Failure);
            }
        }
    }
}