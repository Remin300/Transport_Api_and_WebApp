using WebApplication1.ObiektyORMLinq2DB.ZleceniaSpedycja;
using WebApplication1.Repositories.User.DTO;

namespace WebApplication1.Repositories.Zlecenia.DTO
{
    public class GetZlecenieToEdit_Dto
    {
        public Update_Zlecenie_Dto Zlecenie { get; set; }
     
        public List<AppCacheSelectOption_Dto> Waluty { get; set; }
        public List<AppCacheSelectOption_Dto> StawkiVat { get; set; }

        public List<AppCacheSelectOption_Dto> Kierowcy { get; set; }
        public List<AppCacheSelectOption_Dto> Pojazdy { get; set; }
        public List<AppCacheSelectOption_Dto> Naczepy { get; set; }

        public List<AppCacheSelectOption_Dto> jm { get; set; }

        public List<SlowniaStawek_Dto> SlownikStawkiWlasne { get; set; }

        public List<SlowniaStawek_Dto> SlownikStakiPrzewoz { get; set; }


    }
}
