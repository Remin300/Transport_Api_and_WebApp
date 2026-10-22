using WebApplication1.Obiekty_ORM.ObiektyORMLinq2DB.Urzytkownicy;
using WebApplication1.ObiektyORMLinq2DB.Grupy_Dzialy_Filtry;
using WebApplication1.ObiektyORMLinq2DB.ZleceniaSpedycja;

namespace WebApplication1.Repositories.User.DTO
{
    public class GetAppCache_Dto
    {
        public List<StawkiVat_ORM> StawkiVat { get; set; }
        public List<AppCacheSelectOption_Dto> Oddzialy { get; set; }

        public List<AppCacheSelectOption_Dto> FiltryDodatkowe { get; set; }

        public List<AppCacheSelectOption_Dto> Users { get; set; }
    }
}
