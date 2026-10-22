namespace WebApplication1.Repositories.Zlecenia.DTO
{
    public class Towar_Dto
    {

        public int IdTowaru { get; set; }
        public string? NR_FAKTURY { get; set; }
        public string? Odbiorca { get; set; }
        public string? Dostawca { get; set; }
        public string? Towar { get; set; }
        public DateTime? DATAWYSYLKI { get; set; }
        public DateTime? DATADOSTARCZENIA { get; set; }
        public string? PLATNIK { get; set; }

    }
}
