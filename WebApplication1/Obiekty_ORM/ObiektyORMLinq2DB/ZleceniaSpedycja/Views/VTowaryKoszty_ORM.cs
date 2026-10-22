using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.ZleceniaSpedycja.Views
{

    [Table(Name = "VTOWARY_KOSZTY")]
    internal class VTowaryKoszty_ORM
    {
        [Column(Name = "ID_TOWARY_KOSZTY")]
        public int IdTowaryKoszty { get; set; }

        [Column(Name = "IDTOWARU")]
        public int IdTowaru { get; set; }

        [Column(Name = "DATA_OTRZYMANIA")]
        public DateTime? DataOtrzymania { get; set; }

        [Column(Name = "KOSZT")]
        public string Koszt { get; set; }

        [Column(Name = "OPIS")]
        public string Opis { get; set; }

        [Column(Name = "KWOTA_W_WALUCIE")]
        public double KwotaWWalucie { get; set; }

        [Column(Name = "WALUTA")]
        public string Waluta { get; set; }

        [Column(Name = "VAT")]
        public string Vat { get; set; }

        [Column(Name = "IDVAT")]
        public int? IdVat { get; set; }

        [Column(Name = "ILOSC")]
        public double Ilosc { get; set; }

        [Column(Name = "JM")]
        public string JednostkaMiary { get; set; }

        [Column(Name = "IDWALUTY")]
        public int IdWaluty { get; set; }

        [Column(Name = "SLKATEGORIA")]
        public int SlKategoria { get; set; }

        [Column(Name = "KONTRAHENT")]
        public string Kontrahent { get; set; }

        [Column(Name = "NR_FAKTURY")]
        public string NrFaktury { get; set; }

        [Column(Name = "UWAGI")]
        public string Uwagi { get; set; }

        [Column(Name = "NUMER_ZLECENIA")]
        public string NUMER_ZLECENIA { get; set; }


    }
}
