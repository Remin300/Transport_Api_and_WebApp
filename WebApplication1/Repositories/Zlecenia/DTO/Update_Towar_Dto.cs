namespace WebApplication1.Repositories.Zlecenia.DTO
{
    public class Update_Towar_Dto
    {
        public int? IdZlecenia { get; set; }
        public int? IdTowaru { get; set; }
        public double? Ilosc { get; set; }
        public double? Waga { get; set; }
        public string Nazwa { get;  set; }
        public int? IdZleceniodawcy { get;  set; }
        public int? IdOdbiorca { get;  set; }
        public int? IdDostawcy { get;  set; }
        public DateTime? DataZalad { get;  set; }
        public DateTime? DataRozlad { get;  set; }
        public string? GodzinaZalad { get;  set; }
        public string? GodzinaRozlad { get;  set; }
        public string? Pojazd { get;  set; }
        public string? Naczepa { get;  set; }
        public string? Kierowca { get;  set; }
        public string? MiejsceZa { get;  set; }
        public string? MiejsceRo { get;  set; }
        public string? Uwagi { get;  set; }
      
    }
}
