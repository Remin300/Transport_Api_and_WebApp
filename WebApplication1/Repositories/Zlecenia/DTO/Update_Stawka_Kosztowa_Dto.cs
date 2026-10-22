namespace WebApplication1.Repositories.Zlecenia.DTO
{
    public class Update_Stawka_Kosztowa_Dto
    {
        public int? IdTowaryKoszty { get; set; }
        public int? IdSlownikKosztow { get; set; }  // UWAGA KLUCZ OBCY DO SŁOWNIKA
        public double? KwotaWWalucie { get; set; }
        public int? IdWaluty { get; set; }
        public int? IdVat { get; set; }
        public int? IdJednostkaMiar { get; set; }
        public double? Ilosc { get; set; }
        public string? Uwagi { get; set; }
        public int? IdTowaru { get;  set; }
    }
}
