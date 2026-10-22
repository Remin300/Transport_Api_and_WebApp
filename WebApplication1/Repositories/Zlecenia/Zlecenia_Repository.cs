using LinqToDB;
using LinqToDB.Async;
using Serilog.Core;
using System.Collections;
using System.Data.Common;
using System.Security.Claims;
using WebApplication1.Obiekty_ORM.ObiektyORMLinq2DB.Urzytkownicy;
using WebApplication1.ObiektyORMLinq2DB;
using WebApplication1.ObiektyORMLinq2DB.Grupy_Dzialy_Filtry;
using WebApplication1.ObiektyORMLinq2DB.Tabor;
using WebApplication1.ObiektyORMLinq2DB.TS.Kierowcy;
using WebApplication1.ObiektyORMLinq2DB.ZleceniaSpedycja;
using WebApplication1.ObiektyORMLinq2DB.ZleceniaSpedycja.Views;
using WebApplication1.Repositories.User;
using WebApplication1.Repositories.User.DTO;
using WebApplication1.Repositories.User.Mappers;
using WebApplication1.Repositories.User.Validators;
using WebApplication1.Repositories.Zlecenia.DTO;
using WebApplication1.Repositories.Zlecenia.Helpers;
using WebApplication1.Repositories.Zlecenia.Mappers;
using WebApplication1.Repositories.Zlecenia.Queries;
using WebApplication1.Repositories.Zlecenia.Validators;
using WebApplication1.Tools;

namespace WebApplication1.Repositories.Zlecenia
{
    public class Zlecenia_Repository : IZlecenia_Repository
    {
        private readonly ILogger<UserRepository> _logger;
        public Zlecenia_Repository(ILogger<UserRepository> logger)
        {
            _logger = logger;
        }

        public async Task<Result<Lista_Zlecen_Response_Dto>> Get_Zlecenia_List_Async(Get_Zlecenia_List_Query query, int userId)
        {
            try
            {
                using (var db = DbConnectionLinq2DB.GetConnection())
                {
                    // ===== dodcelowo mozna trzymac w IMemoryCache =============
                    var dostepneOddzialy = db.GetTable<Users_Odzialy_ORM>()
                      .Where(x => x.IDUSER == userId)
                      .Select(x => x.IDODDZIALY)
                      .ToList();

                    var dostepneFiltry = db.GetTable<Users_FiltryPrzych_ORM>()
                              .Where(x => x.ID_USER == userId)
                              .Select(x => x.ID_FILTRY_PRZYCH)
                              .ToList();

                    // ===========================================================

                    var listaZlecen_query = db.GetTable<VZleceniaSpedNew_ORM>().AsQueryable();

                    if (!string.IsNullOrWhiteSpace(query.Zleceniodawca))
                    {
                        listaZlecen_query = listaZlecen_query.Where(z => z.NAZWAZLECENIODAWCY.ToLower().Contains(query.Zleceniodawca.ToLower()));
                    }

                    if (!string.IsNullOrWhiteSpace(query.NrReferencyjny))
                    {
                        listaZlecen_query = listaZlecen_query.Where(z => z.PRZELADUNEK.ToLower().Contains(query.NrReferencyjny.ToLower()));
                    }

                    if (!string.IsNullOrWhiteSpace(query.Przewoznik))
                    {
                        listaZlecen_query = listaZlecen_query.Where(z => z.NAZWAWYKONAWCY.ToLower().Contains(query.Przewoznik.ToLower()));
                    }

                    if (!string.IsNullOrWhiteSpace(query.NrRej))
                    {
                        listaZlecen_query = listaZlecen_query.Where(z => z.REJPOJAZDU.ToLower().Contains(query.NrRej.ToLower()));
                    }

                    if (!string.IsNullOrWhiteSpace(query.NrZlecenia))
                    {
                        listaZlecen_query = listaZlecen_query.Where(z => z.NUMER_PELNY.ToLower().Contains(query.NrZlecenia.ToLower()));
                    }
                    if (!string.IsNullOrWhiteSpace(query.NrFaktury))
                    {
                        listaZlecen_query = listaZlecen_query.Where(z => z.NUMER_FAKTURY.ToLower().Contains(query.NrFaktury.ToLower()));
                    }
                    if (!string.IsNullOrWhiteSpace(query.Kierowca))
                    {
                        listaZlecen_query = listaZlecen_query.Where(z => z.KIEROWCA_OBCY.ToLower().Contains(query.Kierowca.ToLower()));
                    }

                    if (!string.IsNullOrWhiteSpace(query.MiejsceZaladunku))
                    {
                        listaZlecen_query = listaZlecen_query.Where(z => z.TRASA_OD.ToLower().Contains(query.MiejsceZaladunku.ToLower()));
                    }
                    if (!string.IsNullOrWhiteSpace(query.MiejsceRozladunku))
                    {
                        listaZlecen_query = listaZlecen_query.Where(z => z.TRASA_DO.ToLower().Contains(query.MiejsceRozladunku.ToLower()));
                    }


                    if (query.IdUser.HasValue && query.IdUser != 0)
                    {
                        listaZlecen_query = listaZlecen_query.Where(z => z.ID_USER == query.IdUser);
                    }

                    if (query.IdDzial.HasValue && query.IdDzial != 0)
                    {
                        if (dostepneOddzialy.Contains(query.IdDzial.Value))
                        {
                            listaZlecen_query = listaZlecen_query.Where(z => z.ID_KATEGORIA == query.IdDzial);
                        }
                        else
                        {
                            return Result<Lista_Zlecen_Response_Dto>.Fail("Brak dostępu do wybranego działu.", ErrorType.Forbidden);
                        }
                    }
                    else
                    {
                        listaZlecen_query = listaZlecen_query.Where(z =>
                        z.ID_KATEGORIA == null ||
                        z.ID_KATEGORIA == 0 ||
                        dostepneOddzialy.Contains(z.ID_KATEGORIA));
                    }


                    if (query.IdDodatkowyFiltr.HasValue && query.IdDodatkowyFiltr != 0)
                    {
                        if (dostepneFiltry.Contains(query.IdDodatkowyFiltr.Value))
                        {

                            // dodatkowe 0 i null bo w bazie danych sąrekordy nieprzypisane
                            listaZlecen_query = listaZlecen_query.Where(z => z.FILTR1 == query.IdDodatkowyFiltr);
                        }
                        else
                        {
                            return Result<Lista_Zlecen_Response_Dto>.Fail("Brak dostępu do wybranego filtru.", ErrorType.Forbidden);
                        }
                    }
                    else
                    {
                        listaZlecen_query = listaZlecen_query.Where(z =>
                                    z.FILTR1 == null ||
                            z.FILTR1 == 0 ||
                        dostepneFiltry.Contains(z.FILTR1));
                    }


                    if (query.Status.HasValue && query.Status != 100)
                    {

                        listaZlecen_query = listaZlecen_query.Where(x => x.FINALIZED == query.Status);
                    }



                    //// Wybieramy datę do filtrowania
                    switch (query.FiltrDataRodzaj)
                    {
                        case 1:
                            listaZlecen_query = listaZlecen_query.Where(z => z.DATA_ZLECENIA.HasValue &&
                                                     z.DATA_ZLECENIA.Value.Date >= query.DataOd.Value.Date &&
                                                     z.DATA_ZLECENIA.Value.Date <= query.DataDo.Value.Date);
                            break;
                        case 2:
                            listaZlecen_query = listaZlecen_query.Where(z => z.DATA_ZALADUNKU.HasValue &&
                                                     z.DATA_ZALADUNKU.Value.Date >= query.DataOd.Value.Date &&
                                                     z.DATA_ZALADUNKU.Value.Date <= query.DataDo.Value.Date);
                            break;
                        case 3:
                            listaZlecen_query = listaZlecen_query.Where(z => z.DATA_ROZLADUNKU.HasValue &&
                                                     z.DATA_ROZLADUNKU.Value.Date >= query.DataOd.Value.Date &&
                                                     z.DATA_ROZLADUNKU.Value.Date <= query.DataDo.Value.Date);
                            break;
                        case 4:
                            listaZlecen_query = listaZlecen_query.Where(z => z.DATA_WYSTAWIENIA_FAKTURY.HasValue &&
                                                     z.DATA_WYSTAWIENIA_FAKTURY.Value.Date >= query.DataOd.Value.Date &&
                                                     z.DATA_WYSTAWIENIA_FAKTURY.Value.Date <= query.DataDo.Value.Date);
                            break;
                        default:
                            listaZlecen_query = listaZlecen_query.Where(z => z.DATA_ZLECENIA.HasValue &&
                                                z.DATA_ZLECENIA.Value.Date >= query.DataOd.Value.Date &&
                                                z.DATA_ZLECENIA.Value.Date <= query.DataDo.Value.Date);
                            break;
                    }


                    //switch (query.Transport_0_Spedycja_1)
                    //{
                    //    case 0:
                    //        listaZlecen_query = listaZlecen_query.Where(z => z.ID_WYKONAWCY.HasValue &&
                    //                                 z.ID_WYKONAWCY == 1);                          // 1 to zawsze firma własna
                    //        break;
                    //    case 1:
                    //        listaZlecen_query = listaZlecen_query.Where(z => z.ID_WYKONAWCY.HasValue &&
                    //                                 z.ID_WYKONAWCY != 1);
                    //        break;
                    //}


                    // policz wszystkie rekordy
                    int totalItems = listaZlecen_query.Count();

                    int itemsPerPage = 20;
                    int offset = (query.PageNo - 1) * itemsPerPage;

                    // pobierz wybraną stronę
                    var items = await listaZlecen_query
                        .OrderBy(x => x.NUMER_PELNY)
                        .Skip(offset)
                        .Take(itemsPerPage)
                        .ToListAsync();

                    // var lista_Zlecen = listaZlecen_query.OrderBy(z => z.NUMER_PELNY).ToListAsync();

                    var response = new Lista_Zlecen_Response_Dto
                    {
                        TotalItems = totalItems,
                        TotalPages = (int)Math.Ceiling(totalItems / (double)itemsPerPage),
                        PageNo = query.PageNo,
                        ListaZlecen = items
                    };


                    return Result<Lista_Zlecen_Response_Dto>.Ok(response);
                }
            }
            catch (Exception ex)
            {
                return Result<Lista_Zlecen_Response_Dto>.Fail("Błąd serwera: " + ex.Message, ErrorType.Failure);

            }
        }
        public async Task<Result<Ladunek_Zbiorowy_Response_Dto>> Get_Ladunek_Zbiorowy_Async(int zleceni_id)
        {
            Ladunek_Zbiorowy_Response_Dto respons_dto = new Ladunek_Zbiorowy_Response_Dto();
            respons_dto.ladunek = new List<Towary_i_stawki_Dto>();
            try
            {
                using (var db = DbConnectionLinq2DB.GetConnection())
                {
                    var towary = await db.GetTable<VTowaryZbiorPojazd_ORM>()
                        .Where(x => x.IdZlecenia == zleceni_id).ToListAsync();

                    foreach(var towar in towary)
                    {
                        var grupa = new Towary_i_stawki_Dto();
                        grupa.towar = Zlecenia_Mapper.From_Towary_ORM_to_Towar_Dto(towar);


                        var stawki_wlasne =  await db.GetTable<VTowaryStawki_ORM>()
                                      .Where(x => x.IdTowaru == towar.IdTowaru).ToListAsync();

                        grupa.stawki_wlasne = Zlecenia_Mapper.From_L_TowaryStawki_ORM_L_Stawka_wlasna_Dto(stawki_wlasne);



                        var stawki_kosztowe = await db.GetTable<VTowaryKoszty_ORM>()
                                      .Where(x => x.IdTowaru == towar.IdTowaru).ToListAsync();

                        grupa.stawki_kosztowe = Zlecenia_Mapper.From_L_TowaryStawki_ORM_L_Stawka_kosztowa_Dto(stawki_kosztowe);




                        respons_dto.ladunek.Add(grupa);
                    }




                    return Result<Ladunek_Zbiorowy_Response_Dto>.Ok(respons_dto);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Błąd podczas pobierania ladunku zbiorowego");

                return Result<Ladunek_Zbiorowy_Response_Dto>.Fail("Błąd serwera: " + ex.Message, ErrorType.Failure);

            }
        }

        // ==== ZLECENIA ========================================
        public async Task<Result<GetZlecenieToEdit_Dto>> Get_Zlecenie_ById_Async(int id_zlecenia)
        {
            try
            {
                using (var db = DbConnectionLinq2DB.GetConnection())
                {
                    var zlecenie = await db.GetTable<ZlecenieSped_ORM>().FirstOrDefaultAsync(x => x.IdZleceniaSped == id_zlecenia);


                    if (zlecenie == null)
                    {
                        return Result<GetZlecenieToEdit_Dto>.Fail("Nie znaleziono zlecenia o podanym ID.", ErrorType.NotFound);
                    }

                    var dto = Zlecenia_Mapper.From_ZlecenieSped_ORM_to_Update_Zlecenia_Dto_mapper(zlecenie);

                    // ====================================================================
                    // ======= pierwszys Towai i jego stawki z ładunku zbiorowego =========
                    // ====================================================================
                    var pierwszyTowar = db.GetTable<Towary_ORM>()
                       .FirstOrDefault(x => x.IdZlecenia == zlecenie.IdZleceniaSped);


                    if (pierwszyTowar != null)
                    {
                        dto.towar_id = pierwszyTowar.IdTowaru;
                        dto.towar_nazwa = pierwszyTowar.Nazwa;
                        dto.towar_ilosc = pierwszyTowar.Ilosc;
                        dto.towar_wartosc = pierwszyTowar.Wartosc;
                        dto.towar_idwaluty = pierwszyTowar.IdWaluty;


                        var pierwsza_stawka_wlasna = await db.GetTable<TowaryStawki_ORM>()
                                         .FirstOrDefaultAsync(x => x.IdTowaru == pierwszyTowar.IdTowaru);

                        if (pierwsza_stawka_wlasna != null)
                        {
                            dto.sw_id = pierwsza_stawka_wlasna.IdTowaryStawki;
                            dto.sw_slownik_id = pierwsza_stawka_wlasna.IdSlownikStawek;
                            dto.StawkaWlasna = pierwsza_stawka_wlasna.KwotaWWalucie;
                            dto.IdWalutySw = pierwsza_stawka_wlasna.IdWaluty;
                            dto.IdVatSw = pierwsza_stawka_wlasna.IdVat;
                            dto.IdJmSW = pierwsza_stawka_wlasna.IdJednostkaMiar;

                            // dto.IdTabeliSw 
                        }

                        var pierwsza_stawka_kosztowa = await db.GetTable<TowaryKoszty_ORM>()
                                      .FirstOrDefaultAsync(x => x.IdTowaru == pierwszyTowar.IdTowaru);

                        if (pierwsza_stawka_kosztowa != null)
                        {
                            dto.ps_id = pierwsza_stawka_kosztowa.IdTowaryKoszty;
                            dto.ps_slownik_id = pierwsza_stawka_kosztowa.IdKosztu;
                            dto.PrzewoznikStawka = pierwsza_stawka_kosztowa.KwotaWWalucie;
                            dto.IdWalutyPs = pierwsza_stawka_kosztowa.IdWaluty;
                            dto.IdVatPs = pierwsza_stawka_kosztowa.IdVat;
                            dto.IdJmPs = pierwsza_stawka_kosztowa.IdJednostkaMiar;
                            //dto.IdTabeliPs 
                        }
                    }


                    // ====================================================================
                    // ====================================================================
                    // ====================================================================


                    var zleceniod = await db.GetTable<Kontrahenci_ORM>().FirstOrDefaultAsync(x => x.ID_KONTRAHENTA == zlecenie.IdZleceniodawcy);
                    var wykonawca = await db.GetTable<Kontrahenci_ORM>().FirstOrDefaultAsync(x => x.ID_KONTRAHENTA == zlecenie.IdWykonawcy);

                    dto.zleceniodawcaNazwa = zleceniod?.NAZWA ?? "";
                    dto.wykonawcaNazwa = wykonawca?.NAZWA ?? "";

                    GetZlecenieToEdit_Dto return_class = new GetZlecenieToEdit_Dto()
                    {
                        Zlecenie = dto,

                    };

                    // pobranie danych dodatkowych potrzebnych w kontrolkach UI
                    var dane_dodatkowe = await Get_datne_dodatkowe();


                    return_class.Waluty = dane_dodatkowe.Waluty;
                    return_class.StawkiVat = dane_dodatkowe.StawkiVat;
                    return_class.Kierowcy = dane_dodatkowe.Kierowcy;
                    return_class.Naczepy = dane_dodatkowe.Naczepy;
                    return_class.Pojazdy = dane_dodatkowe.Pojazdy;

                    return_class.jm = dane_dodatkowe.jm;
                    return_class.SlownikStawkiWlasne = dane_dodatkowe.SlownikStawkiWlasne;
                    return_class.SlownikStakiPrzewoz = dane_dodatkowe.SlownikStakiPrzewoz;

                    return Result<GetZlecenieToEdit_Dto>.Ok(return_class);
                }
            }
            catch (Exception ex)
            {
                return Result<GetZlecenieToEdit_Dto>.Fail("Błąd serwera: " + ex.Message, ErrorType.Failure);
            }
        }
        public async Task<Result<int>> Create_Zlecenia_Async(Update_Zlecenie_Dto create_dto)
        {
            var validator = new Update_Zlecenie_Dto_Validator();

            var validationResult = await validator.ValidateAsync(create_dto);

            if (!validationResult.IsValid)
            {
                var errors = string.Join("; ", validationResult.Errors.Select(x => x.ErrorMessage));

                return Result<int>.Fail(errors, ErrorType.Validation);
            }

            ZlecenieSped_ORM zlecenie_obiekt = new ZlecenieSped_ORM();
            zlecenie_obiekt = Zlecenia_Mapper.From_Update_Zlecenia_to_ZlecenieSped_ORM_mapper(zlecenie_obiekt, create_dto);



            var wynik = Generators.Generuj_Numer_Zlecenia(zlecenie_obiekt.IdWykonawcy, zlecenie_obiekt.DataZlecenia);

            string? numer_Pelny = wynik.Nr_Pelny;
            int? nr_Kolejny = wynik.Nr_Kolejny;

            zlecenie_obiekt.NumerPelny = numer_Pelny;
            zlecenie_obiekt.NrKolejny = nr_Kolejny ?? 0;

            try
            {
                using (var db = DbConnectionLinq2DB.GetConnection())
                {
                    var nowe__id = await db.InsertWithIdentityAsync(zlecenie_obiekt);
                    var return_int = Convert.ToInt32(nowe__id);



                    var nowyTowar = new Towary_ORM();
                    nowyTowar.IdZlecenia = return_int;
                    nowyTowar.Nazwa = create_dto.towar_nazwa ?? "";
                    nowyTowar.Ilosc = create_dto.towar_ilosc;
                    nowyTowar.Wartosc = create_dto.towar_wartosc;
                    nowyTowar.IdWaluty = create_dto.towar_idwaluty;

                    var nowyTowar_id = await db.InsertWithIdentityAsync(nowyTowar);
                    nowyTowar.IdTowaru = Convert.ToInt32(nowyTowar_id);




                    var nowaStawkaWlasna = new TowaryStawki_ORM();
                    nowaStawkaWlasna.IdTowaru = nowyTowar.IdTowaru;
                    nowaStawkaWlasna.IdSlownikStawek = create_dto.sw_slownik_id ?? 0;
                    nowaStawkaWlasna.KwotaWWalucie = create_dto.StawkaWlasna;
                    nowaStawkaWlasna.IdWaluty = create_dto.IdWalutySw;
                    nowaStawkaWlasna.IdJednostkaMiar = create_dto.IdJmSW ?? 0;
                    nowaStawkaWlasna.IdVat = create_dto.IdVatSw ?? 0;
                    nowaStawkaWlasna.Ilosc = 1; // defaultowo 1
                    await db.InsertAsync(nowaStawkaWlasna);

                    var nowaStawkaKosztowa = new TowaryKoszty_ORM();
                    nowaStawkaKosztowa.IdTowaru = nowyTowar.IdTowaru;
                    nowaStawkaKosztowa.IdKosztu = create_dto.ps_slownik_id;
                    nowaStawkaKosztowa.KwotaWWalucie = create_dto.PrzewoznikStawka;
                    nowaStawkaKosztowa.IdWaluty = create_dto.IdWalutyPs;
                    nowaStawkaKosztowa.IdJednostkaMiar = create_dto.IdJmPs ?? 0;
                    nowaStawkaKosztowa.IdVat = create_dto.IdVatPs;
                    nowaStawkaKosztowa.Ilosc = 2; // defaultowo 1
                    await db.InsertAsync(nowaStawkaKosztowa);



                    return Result<int>.Ok(return_int);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Błąd podczas tworzenia zlecenia");

                return Result<int>.Fail("Błąd serwera: " + ex.Message, ErrorType.Failure);

            }
        }
        public async Task<Result> Edit_Zlecenia_Async(int idZlec, Update_Zlecenie_Dto update_dto)
        {

            using (var db = DbConnectionLinq2DB.GetConnection())
            using (var tran = db.BeginTransaction())

            {

                try
                {
                    var zlecenie_obiekt = await db.GetTable<ZlecenieSped_ORM>()
                        .FirstOrDefaultAsync(x => x.IdZleceniaSped == idZlec);

                    if (zlecenie_obiekt == null)
                    {
                        return Result.Fail(
                            "Nie znaleziono zlecenia o podanym ID.",
                            ErrorType.NotFound);
                    }

                    Zlecenia_Mapper.From_Update_Zlecenia_to_ZlecenieSped_ORM_mapper(zlecenie_obiekt, update_dto);

                    // ====================================================================
                    // ======= pierwszys Towai i jego stawki z ładunku zbiorowego =========
                    // ====================================================================
                    var pierwszyTowar = await db.GetTable<Towary_ORM>()
                       .FirstOrDefaultAsync(x => x.IdTowaru == update_dto.towar_id);


                    if (pierwszyTowar != null)
                    {
                        pierwszyTowar.Nazwa = update_dto.towar_nazwa ?? "";
                        pierwszyTowar.Ilosc = update_dto.towar_ilosc;
                        pierwszyTowar.Wartosc = update_dto.towar_wartosc;
                        pierwszyTowar.IdWaluty = update_dto.towar_idwaluty;

                        await db.UpdateAsync(pierwszyTowar);
                        var pierwsza_stawka_wlasna = await db.GetTable<TowaryStawki_ORM>()
                                         .FirstOrDefaultAsync(x => x.IdTowaryStawki == update_dto.sw_id);

                        if (pierwsza_stawka_wlasna != null)
                        {
                            pierwsza_stawka_wlasna.IdSlownikStawek = update_dto.sw_slownik_id ?? 0;
                            pierwsza_stawka_wlasna.KwotaWWalucie = update_dto.StawkaWlasna;
                            pierwsza_stawka_wlasna.IdWaluty = update_dto.IdWalutySw;
                            pierwsza_stawka_wlasna.IdVat = update_dto.IdVatSw ?? 0;
                            pierwsza_stawka_wlasna.IdJednostkaMiar = update_dto.IdJmSW ?? 0;

                            await db.UpdateAsync(pierwsza_stawka_wlasna);
                        }

                        var pierwsza_stawka_kosztowa = await db.GetTable<TowaryKoszty_ORM>()
                                      .FirstOrDefaultAsync(x => x.IdTowaryKoszty == update_dto.ps_id);

                        if (pierwsza_stawka_kosztowa != null)
                        {
                            pierwsza_stawka_kosztowa.IdKosztu = update_dto.ps_slownik_id;
                            pierwsza_stawka_kosztowa.KwotaWWalucie = update_dto.PrzewoznikStawka;
                            pierwsza_stawka_kosztowa.IdWaluty = update_dto.IdWalutyPs;
                            pierwsza_stawka_kosztowa.IdVat = update_dto.IdVatPs;
                            pierwsza_stawka_kosztowa.IdJednostkaMiar = update_dto.IdJmPs ?? 0;

                            await db.UpdateAsync(pierwsza_stawka_kosztowa);
                        }



                    }
                    else
                    {
                        var nowyTowar = new Towary_ORM();
                        nowyTowar.IdZlecenia = idZlec;
                        nowyTowar.Nazwa = update_dto.towar_nazwa ?? "";
                        nowyTowar.Ilosc = update_dto.towar_ilosc;
                        nowyTowar.Wartosc = update_dto.towar_wartosc;
                        nowyTowar.IdWaluty = update_dto.towar_idwaluty;

                        var nowyTowar_id = await db.InsertWithIdentityAsync(nowyTowar);
                        nowyTowar.IdTowaru = Convert.ToInt32(nowyTowar_id);




                        var nowaStawkaWlasna = new TowaryStawki_ORM();
                        nowaStawkaWlasna.IdTowaru = nowyTowar.IdTowaru;
                        nowaStawkaWlasna.IdSlownikStawek = update_dto.sw_slownik_id ?? 0;
                        nowaStawkaWlasna.KwotaWWalucie = update_dto.StawkaWlasna;
                        nowaStawkaWlasna.IdWaluty = update_dto.IdWalutySw;
                        nowaStawkaWlasna.IdVat = update_dto.IdVatSw ?? 0;
                        nowaStawkaWlasna.IdJednostkaMiar = update_dto.IdJmSW ?? 0;
                        await db.InsertAsync(nowaStawkaWlasna);

                        var nowaStawkaKosztowa = new TowaryKoszty_ORM();
                        nowaStawkaKosztowa.IdTowaru = nowyTowar.IdTowaru;
                        nowaStawkaKosztowa.IdKosztu = update_dto.ps_slownik_id;
                        nowaStawkaKosztowa.KwotaWWalucie = update_dto.PrzewoznikStawka;
                        nowaStawkaKosztowa.IdWaluty = update_dto.IdWalutyPs;
                        nowaStawkaKosztowa.IdVat = update_dto.IdVatPs;
                        nowaStawkaKosztowa.IdJednostkaMiar = update_dto.IdJmPs;
                        await db.InsertAsync(nowaStawkaKosztowa);
                    }


                    // ====================================================================
                    // ====================================================================
                    // ====================================================================



                    await db.UpdateAsync(zlecenie_obiekt);
                    tran.Commit();

                    return Result.Ok();

                }
                catch (Exception ex)
                {
                    tran.Rollback();

                    _logger.LogError(ex, "Błąd podczas edycji zlecenia {IdZlecenia}", idZlec);

                    return Result.Fail(
                        "Wystąpił błąd podczas zapisywania zlecenia.",
                        ErrorType.Failure);

                }
            }

        }
        public async Task<Result> Delete_Zlecenia_Async(int id_zlecenia, int userId)
        {
            try
            {
                using (var db = DbConnectionLinq2DB.GetConnection())
                {
                    var zlecenie_obiekt = await db.GetTable<ZlecenieSped_ORM>()
                        .FirstOrDefaultAsync(x => x.IdZleceniaSped == id_zlecenia);

                    if (zlecenie_obiekt == null)
                    {
                        return Result.Fail(
                            "Nie znaleziono zlecenia o podanym ID.",
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

                    await db.DeleteAsync(zlecenie_obiekt);
                    _logger.LogInformation(
                            "Usunięto zlecenie. UserId: {UserId}, NumerZlecenia: {zmienna_2}",
                            userId,
                            zlecenie_obiekt.NumerPelny);

                    return Result.Ok();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Błąd podczas usuwania zlecenia");
                return Result<int>.Fail("Błąd serwera: " + ex.Message, ErrorType.Failure);

            }
        }
        // ======================================================


        // ==== TOWARY ==========================================
        public async Task<Result<Update_Towar_Dto>> Get_Towar_Async(int id_Towaru)
        {
            try
            {
                using (var db = DbConnectionLinq2DB.GetConnection())
                {


                    var towar = await db.GetTable<Towary_ORM>().FirstOrDefaultAsync(x => x.IdTowaru == id_Towaru);

                    if (towar == null)
                    {
                        return Result<Update_Towar_Dto>.Fail("Nie znaleziono rekordu o podanym ID.", ErrorType.NotFound);
                    }

                    Update_Towar_Dto dto = Zlecenia_Mapper.From_Towary_ORM_to_Update_Towar_Dto(towar);



                    return Result<Update_Towar_Dto>.Ok(dto);
                }
            }
            catch (Exception ex)
            {
                return Result<Update_Towar_Dto>.Fail("Błąd serwera: " + ex.Message, ErrorType.Failure);
            }

        }
        public async Task<Result<int>> Create_Towar_Async(Update_Towar_Dto update_dto)
        {
            try
            {
                using (var db = DbConnectionLinq2DB.GetConnection())
                {

                    var towar = new Towary_ORM();
                    towar = Zlecenia_Mapper.From_Update_Towar_Dto_to_Towary_ORM(towar, update_dto);


                    var nowe__id = await db.InsertWithIdentityAsync(towar);
                    var return_int = Convert.ToInt32(nowe__id);

                    return Result<int>.Ok(return_int);
                }
            }
            catch (Exception ex)
            {
                return Result<int>.Fail("Błąd serwera: " + ex.Message, ErrorType.Failure);
            }
        }
        public async Task<Result> Update_Towar_Async(Update_Towar_Dto update_dto)
        {
            try
            {
                using (var db = DbConnectionLinq2DB.GetConnection())
                {
                    var towar = await db.GetTable<Towary_ORM>().FirstOrDefaultAsync(x => x.IdTowaru == update_dto.IdTowaru);
                    if (towar == null)
                    {
                        return Result.Fail("Nie znaleziono rekordu o podanym ID.", ErrorType.NotFound);
                    }

                    towar = Zlecenia_Mapper.From_Update_Towar_Dto_to_Towary_ORM(towar, update_dto);


                    await db.UpdateAsync(towar);

                    return Result.Ok();
                }
            }
            catch (Exception ex)
            {
                return Result.Fail("Błąd serwera: " + ex.Message, ErrorType.Failure);
            }

        }
        public async Task<Result> Delete_Towar_Async(int id_towaru, int userId)
        {
            try
            {
                using (var db = DbConnectionLinq2DB.GetConnection())
                {


                    var towar = await db.GetTable<Towary_ORM>().FirstOrDefaultAsync(x => x.IdTowaru == id_towaru);

                    if (towar == null)
                    {
                        return Result<Update_Towar_Dto>.Fail("Nie znaleziono rekordu o podanym ID.", ErrorType.NotFound);
                    }

                    var User = await db.GetTable<Users_ORM>().FirstOrDefaultAsync(x => x.ID_USER == userId);


                    // Tylko admin może usunąć zlecenie
                    if (!User.KOD.Contains("A"))
                    {
                        return Result.Fail(
                               "Brak uprawnień do wykonania tej operacji.",
                               ErrorType.Forbidden);
                    }

                    await db.DeleteAsync(towar);
                    _logger.LogInformation(
                            "Usunięto Towa. UserId: {UserId}, IdZlecenia: {zmienna_2}",
                            userId,
                            towar.IdZlecenia);

                    return Result.Ok();
                }
            }
            catch (Exception ex)
            {
                return Result.Fail("Błąd serwera: " + ex.Message, ErrorType.Failure);
            }
        }
        // ======================================================


        // ==== STAWKI WLASNE =================================== 
        public async Task<Result<Update_Stawka_Wlasna_Dto>> Get_Stawka_Wlasna_Async(int id_Stawki)
        {
            try
            {
                using (var db = DbConnectionLinq2DB.GetConnection())
                {

                    var stawka = await db.GetTable<TowaryStawki_ORM>().FirstOrDefaultAsync(x => x.IdTowaryStawki == id_Stawki);

                    if (stawka == null)
                    {
                        return Result<Update_Stawka_Wlasna_Dto>.Fail("Nie znaleziono rekordu o podanym ID.", ErrorType.NotFound);
                    }

                    Update_Stawka_Wlasna_Dto dto = Zlecenia_Mapper.From_TowaryStawki_ORM_to_Update_Stawka_Wlasna_Dto(stawka);



                    return Result<Update_Stawka_Wlasna_Dto>.Ok(dto);

                }
            }
            catch (Exception ex)
            {
                return Result<Update_Stawka_Wlasna_Dto>.Fail("Błąd serwera: " + ex.Message, ErrorType.Failure);
            }
        }
        public async Task<Result<int>> Create_Stawka_Wlasna_Async(Update_Stawka_Wlasna_Dto update_dto)
        {
            try
            {
                using (var db = DbConnectionLinq2DB.GetConnection())
                {

                    var stawka = new TowaryStawki_ORM();
                    stawka = Zlecenia_Mapper.From_Update_Stawka_Wlasna_Dto_to_TowaryStawki_ORM(stawka, update_dto);


                    var nowe__id = await db.InsertWithIdentityAsync(stawka);
                    var return_int = Convert.ToInt32(nowe__id);

                    return Result<int>.Ok(return_int);
                }
            }
            catch (Exception ex)
            {
                return Result<int>.Fail("Błąd serwera: " + ex.Message, ErrorType.Failure);
            }
        }
        public async Task<Result> Update_Stawka_Wlasna_Async(Update_Stawka_Wlasna_Dto update_dto)
        {
            try
            {
                using (var db = DbConnectionLinq2DB.GetConnection())
                {
                    var stawka = await db.GetTable<TowaryStawki_ORM>().FirstOrDefaultAsync(x => x.IdTowaryStawki == update_dto.IdTowaryStawki);
                    if (stawka == null)
                    {
                        return Result.Fail("Nie znaleziono rekordu o podanym ID.", ErrorType.NotFound);
                    }

                    stawka = Zlecenia_Mapper.From_Update_Stawka_Wlasna_Dto_to_TowaryStawki_ORM(stawka, update_dto);


      

                    await db.UpdateAsync(stawka);

                    return Result.Ok();
                }
            }
            catch (Exception ex)
            {
                return Result.Fail("Błąd serwera: " + ex.Message, ErrorType.Failure);
            }
        }
        public async Task<Result> Delete_Stawka_Wlasna_Async(int id_Stawki, int userId)
        {
            try
            {
                using (var db = DbConnectionLinq2DB.GetConnection())
                {


                    var stawka = await db.GetTable<TowaryStawki_ORM>().FirstOrDefaultAsync(x => x.IdTowaryStawki == id_Stawki);

                    if (stawka == null)
                    {
                        return Result<Update_Stawka_Wlasna_Dto>.Fail("Nie znaleziono rekordu o podanym ID.", ErrorType.NotFound);
                    }

                    var User = await db.GetTable<Users_ORM>().FirstOrDefaultAsync(x => x.ID_USER == userId);


                    // Tylko admin może usunąć zlecenie
                    if (!User.KOD.Contains("A"))
                    {
                        return Result.Fail(
                               "Brak uprawnień do wykonania tej operacji.",
                               ErrorType.Forbidden);
                    }

                    await db.DeleteAsync(stawka);
                    _logger.LogInformation(
                            "Usunięto TowaryStawki. UserId: {UserId}, IdTowar: {zmienna_2}",
                            userId,
                            stawka.IdTowaru);

                    return Result.Ok();
                }
            }
            catch (Exception ex)
            {
                return Result.Fail("Błąd serwera: " + ex.Message, ErrorType.Failure);
            }
        }
        // ======================================================


        // ==== STAWKI KOSZTOWE =================================
        public async Task<Result<Update_Stawka_Kosztowa_Dto>> Get_Stawka_Kosztowa_Async(int id_Stawki)
        {
            try
            {
                using (var db = DbConnectionLinq2DB.GetConnection())
                {

                    var stawka = await db.GetTable<TowaryKoszty_ORM>().FirstOrDefaultAsync(x => x.IdTowaryKoszty == id_Stawki);


                    if (stawka == null)
                    {
                        return Result<Update_Stawka_Kosztowa_Dto>.Fail("Nie znaleziono rekordu o podanym ID.", ErrorType.NotFound);
                    }
                    Update_Stawka_Kosztowa_Dto dto = Zlecenia_Mapper.From_TowaryKoszty_ORM_to_Update_Stawka_Kosztowa_Dto(stawka);



                    return Result<Update_Stawka_Kosztowa_Dto>.Ok(dto);

                }
            }
            catch (Exception ex)
            {
                return Result<Update_Stawka_Kosztowa_Dto>.Fail("Błąd serwera: " + ex.Message, ErrorType.Failure);
            }
        }
        public async Task<Result<int>> Create_Stawka_Kosztowa_Async(Update_Stawka_Kosztowa_Dto update_dto)
        {
            try
            {
                using (var db = DbConnectionLinq2DB.GetConnection())
                {

                    var stawka = new TowaryKoszty_ORM();
                    stawka = Zlecenia_Mapper.From_Update_Stawka_Kosztowa_Dto_to_TowaryKoszty_ORM(stawka, update_dto);


                    var nowe__id = await db.InsertWithIdentityAsync(stawka);
                    var return_int = Convert.ToInt32(nowe__id);

                    return Result<int>.Ok(return_int);
                }
            }
            catch (Exception ex)
            {
                return Result<int>.Fail("Błąd serwera: " + ex.Message, ErrorType.Failure);
            }
        }
        public async Task<Result> Update_Stawka_Kosztowa_Async(Update_Stawka_Kosztowa_Dto update_dto)
        {
            try
            {
                using (var db = DbConnectionLinq2DB.GetConnection())
                {
                    var stawka = await db.GetTable<TowaryKoszty_ORM>().FirstOrDefaultAsync(x => x.IdTowaryKoszty == update_dto.IdTowaryKoszty);
                    if (stawka == null)
                    {
                        return Result.Fail("Nie znaleziono rekordu o podanym ID.", ErrorType.NotFound);
                    }

                    stawka = Zlecenia_Mapper.From_Update_Stawka_Kosztowa_Dto_to_TowaryKoszty_ORM(stawka, update_dto);


                    await db.UpdateAsync(stawka);

                    return Result.Ok();
                }
            }
            catch (Exception ex)
            {
                return Result.Fail("Błąd serwera: " + ex.Message, ErrorType.Failure);
            }
        }
        public async Task<Result> Delete_Stawka_Kosztow_Async(int id_Stawki, int userId)
        {
            try
            {
                using (var db = DbConnectionLinq2DB.GetConnection())
                {


                    var stawka = await db.GetTable<TowaryKoszty_ORM>().FirstOrDefaultAsync(x => x.IdTowaryKoszty == id_Stawki);

                    if (stawka == null)
                    {
                        return Result<Update_Stawka_Wlasna_Dto>.Fail("Nie znaleziono rekordu o podanym ID.", ErrorType.NotFound);
                    }

                    var User = await db.GetTable<Users_ORM>().FirstOrDefaultAsync(x => x.ID_USER == userId);


                    // Tylko admin może usunąć zlecenie
                    if (!User.KOD.Contains("A"))
                    {
                        return Result.Fail(
                               "Brak uprawnień do wykonania tej operacji.",
                               ErrorType.Forbidden);
                    }

                    await db.DeleteAsync(stawka);
                    _logger.LogInformation(
                            "Usunięto TowaryKoszty. UserId: {UserId}, IdTowar: {zmienna_2}",
                            userId,
                            stawka.IdTowaru);

                    return Result.Ok();
                }
            }
            catch (Exception ex)
            {
                return Result.Fail("Błąd serwera: " + ex.Message, ErrorType.Failure);
            }
        }
        // ======================================================




        public async Task<Lista_Dane_do_kontrolek_Dto> Get_datne_dodatkowe()
        {

            Lista_Dane_do_kontrolek_Dto lista = new Lista_Dane_do_kontrolek_Dto();
            try
            {
                using (var db = DbConnectionLinq2DB.GetConnection())
                {
                    lista.Waluty = db.GetTable<SymboleWalut_ORM>()
                            .Select(x => new AppCacheSelectOption_Dto
                            {
                                id = x.IdWaluty,
                                nazwa = x.Symbol
                            })
                        .ToList();

                    lista.StawkiVat = db.GetTable<StawkiVat_ORM>()
                        .Select(x => new AppCacheSelectOption_Dto
                        {
                            id = x.IdStawki,
                            nazwa = x.Opis
                        })
                    .ToList();


                    lista.jm = db.GetTable<Miary_ORM>()
                            .Select(x => new AppCacheSelectOption_Dto
                            {
                                id = x.IdMiary,
                                nazwa = x.Skrot
                            })
                        .ToList();

                    lista.Kierowcy = db.GetTable<Kierowcy_ORM>()
                          .Select(x => new AppCacheSelectOption_Dto
                          {
                              id = x.ID_KIEROWCA,
                              nazwa = x.IMIE + " " + x.NAZWISKO
                          })
                        .ToList();

                    lista.Pojazdy = db.GetTable<Pojazdy_ORM>()
                       .Select(x => new AppCacheSelectOption_Dto
                       {
                           id = x.ID_POJAZDU,
                           nazwa = x.NR_REJ
                       })
                     .ToList();


                    lista.Naczepy = db.GetTable<NACZEPY_ORM>()
                       .Select(x => new AppCacheSelectOption_Dto
                       {
                           id = x.ID_NACZEPY,
                           nazwa = x.NR_REJ
                       })
                     .ToList();

                    lista.SlownikStawkiWlasne = db.GetTable<SlownikStawki_ORM>()
                          .Select(x => new SlowniaStawek_Dto
                          {
                              Id = x.IdSlownikiStawki,
                              nazwa = x.Opis,
                              DefaultKwota = x.DefaultKwota,
                              IdDefaultVat = x.IdDefaultVat,
                              IdDefaultJednostkaMiar = x.IdDefaultJednostkaMiar,
                              IdDefaultWaluta = x.IdDefaultWaluta,
                          })
                      .ToList();

                    lista.SlownikStakiPrzewoz = db.GetTable<SlownikKoszty_ORM>()
                       .Select(x => new SlowniaStawek_Dto
                       {
                           Id = x.IdSlownikiKoszty,
                           nazwa = x.Opis,
                           DefaultKwota = x.DefaultKwota,
                           IdDefaultVat = x.IdDefaultVat,
                           IdDefaultJednostkaMiar = x.IdDefaultJednostkaMiar,
                           IdDefaultWaluta = x.IdDefaultWaluta,
                       })
                   .ToList();




                }

                return lista;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Błąd podczas uspobierania danych bazowych do formatki dodaj/edytuj zlecenie");
                return null;

            }
        }

      
    }
}
