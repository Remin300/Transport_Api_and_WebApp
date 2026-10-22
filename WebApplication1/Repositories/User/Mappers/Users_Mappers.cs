using WebApplication1.Obiekty_ORM.ObiektyORMLinq2DB.Urzytkownicy;
using WebApplication1.Repositories.User.DTO;

namespace WebApplication1.Repositories.User.Mappers
{
    public static class Users_Mappers
    {
        public static Update_User_DTO Fom_User_to_Update_User_DTO_Mapper(Users_ORM user)
        {
            Update_User_DTO dto = new Update_User_DTO();

            dto.LOGIN = user.LOGIN;
            dto.IMIE = user.IMIE;
            dto.NAZWISKO = user.NAZWISKO;
            dto.ADRES = user.ADRES;
            dto.MIASTO = user.MIASTO;

            return dto;
        }
        internal static Users_ORM From_Update_User_DTO_to_User_Mapper(Users_ORM user, Update_User_DTO dto)
        {

            user.LOGIN = dto.LOGIN;
            user.IMIE = dto.IMIE;
            user.NAZWISKO = dto.NAZWISKO;
            user.ADRES = dto.ADRES;
            user.MIASTO = dto.MIASTO;




            return user;
        }
        internal static Update_User_AllInfo_DTO Fom_User_to_Update_User_AllInfo_DTO_Mapper(Users_ORM user, Update_User_AllInfo_DTO dto)
        {

            dto.LOGIN = user.LOGIN;
            dto.PASS = user.PASS;
            dto.IMIE = user.IMIE;
            dto.NAZWISKO = user.NAZWISKO;
            dto.ID_GRUPY = user.ID_GRUPY;
            dto.IDGRUPA = user.IDGRUPA;
            dto.VISIBLE = user.VISIBLE;
            dto.ADRES = user.ADRES;
            dto.KOD = user.KOD;
            dto.MIASTO = user.MIASTO;
            dto.LOCK = user.LOCK;
            dto.KSEF_TOKEN = user.KSEF_TOKEN;
            dto.ID_ROLA = user.ID_ROLA;
            dto.IDREJESTR = user.IDREJESTR;
            dto.WARUNEK = user.WARUNEK;
            dto.PASSODKOD = user.PASSODKOD;
            dto.GRUPA = user.GRUPA;

            return dto;
        }
        internal static Users_ORM From_Update_User_AllInfo_DTO_to_User_Mapper(Users_ORM user, Update_User_AllInfo_DTO dto)
        {

            user.LOGIN = dto.LOGIN;
            user.PASS = dto.PASS;
            user.IMIE = dto.IMIE;
            user.NAZWISKO = dto.NAZWISKO;
            user.ID_GRUPY = dto.ID_GRUPY;
            user.IDGRUPA = dto.IDGRUPA;
            user.VISIBLE = dto.VISIBLE;
            user.ADRES = dto.ADRES;
            user.KOD = dto.KOD;
            user.MIASTO = dto.MIASTO;
            user.LOCK = dto.LOCK;
            user.KSEF_TOKEN = dto.KSEF_TOKEN;
            user.ID_ROLA = dto.ID_ROLA ?? 0;
            user.IDREJESTR = dto.IDREJESTR ?? 0;
            user.WARUNEK = dto.WARUNEK;
            user.PASSODKOD = dto.PASSODKOD;
            user.GRUPA = dto.GRUPA;

            return user;
        }

        internal static Users_ORM From_Create_User_Dto_to_User_Mapper( Create_User_Dto dto)
        {
            var user = new Users_ORM();

            user.LOGIN = dto.LOGIN;
            user.PASS = dto.PASS;
            user.IMIE = dto.IMIE;
            user.NAZWISKO = dto.NAZWISKO;
            user.ID_GRUPY = dto.ID_GRUPY;
            user.IDGRUPA = dto.IDGRUPA;
            user.VISIBLE = dto.VISIBLE;
            user.ADRES = dto.ADRES;
            user.KOD = dto.KOD;
            user.MIASTO = dto.MIASTO;
            user.LOCK = dto.LOCK;
            user.KSEF_TOKEN = dto.KSEF_TOKEN;
            user.ID_ROLA = dto.ID_ROLA ?? 0;
            user.IDREJESTR = dto.IDREJESTR ?? 0;
            user.WARUNEK = dto.WARUNEK;
            user.PASSODKOD = dto.PASSODKOD;
            user.GRUPA = dto.GRUPA;

            return user;
        }

    }
}
