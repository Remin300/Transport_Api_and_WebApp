namespace WebApplication1.Repositories.Zlecenia.DTO
{
    public class Towary_i_stawki_Dto
    {
        public Towar_Dto? towar { get; set; }
        public List<Stawka_wlasna_Dto>? stawki_wlasne { get; set; }
        public List<Stawka_kosztowa_Dto>? stawki_kosztowe { get; set; }
    }
}
