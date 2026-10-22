namespace WebApplication1.Repositories.User.DTO
{
    public class Create_User_Dto
    {
        public string? LOGIN { get; set; }
        public string? PASS { get; set; }
        public string? IMIE { get; set; }
        public string? NAZWISKO { get; set; }
        public int? ID_GRUPY { get; set; }
        public int? IDGRUPA { get; set; }
        public int? VISIBLE { get; set; }
        public string? ADRES { get; set; }
        public string? KOD { get; set; }
        public string? MIASTO { get; set; }
        public int? LOCK { get; set; }
        public string? KSEF_TOKEN { get; set; }
        public int? ID_ROLA { get; set; }
        public int? IDREJESTR { get; set; }
        public string? WARUNEK { get; set; }
        public string? PASSODKOD { get; set; }
        public string? GRUPA { get; set; }

        public List<int>? listaIdOddzialy { get; set; }
        public List<int>? listaIdDodatkoweFiltry { get; set; }
    }
}
