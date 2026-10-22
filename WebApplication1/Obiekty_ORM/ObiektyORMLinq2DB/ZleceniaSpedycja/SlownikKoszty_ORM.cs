using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.ZleceniaSpedycja
{
    [Table(Name = "SLOWNIKI_KOSZTY")]
    internal class SlownikKoszty_ORM
    {
        [PrimaryKey]
        [Column(Name = "ID_SLOWNIKI_KOSZTY")]
        public int IdSlownikiKoszty { get; set; }

        [Column(Name = "OPIS")]
        public string Opis { get; set; }

        [Column(Name = "DEFAULT_KWOTA")]
        public double? DefaultKwota { get; set; }

        [Column(Name = "IDDEFAULT_VAT")]
        public int? IdDefaultVat { get; set; }

        [Column(Name = "IDDEFAULT_JEDNOSTKA_MIAR")]
        public int? IdDefaultJednostkaMiar { get; set; }

        [Column(Name = "IDDEFAULT_WALUTA")]
        public int? IdDefaultWaluta { get; set; }

        [Column(Name = "KATEGORIA")]
        public int Kategoria { get; set; }

        [Column(Name = "DOD_OPIS")]
        public string DodOpis { get; set; }
    }
}
