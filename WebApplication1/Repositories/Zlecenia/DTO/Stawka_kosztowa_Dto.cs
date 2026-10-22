using LinqToDB.Mapping;

namespace WebApplication1.Repositories.Zlecenia.DTO
{
    public class Stawka_kosztowa_Dto
    {
       
        public int? IdTowaryKoszty { get; set; }
        public int? IdTowaru { get; set; }
        public string? NrFaktury { get; set; }

        public string? Opis { get; set; }
        public double? Ilosc { get; set; }
        public double? KwotaJednostkowa { get; set; }
        public double? KwotaCalkowita { get; set; }
        public string? Waluta { get; set; }
        public string? Vat { get; set; }
        public string? JednostkaMiary { get; set; }
        public string? Uwagi { get; set; }

    }
}
