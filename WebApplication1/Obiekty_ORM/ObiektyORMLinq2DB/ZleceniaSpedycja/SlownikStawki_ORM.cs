using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.ZleceniaSpedycja
{
    [Table(Name = "SLOWNIKI_STAWKI")]
    public class SlownikStawki_ORM
    {
        [PrimaryKey]
        [Column(Name = "ID_SLOWNIKI_STAWKI")]
        public int IdSlownikiStawki { get; set; }

        [Column(Name = "OPIS")]
        public string Opis { get; set; }

        [Column(Name = "DOD_OPIS")]
        public string DOD_OPIS { get; set; }

        [Column(Name = "DEFAULT_KWOTA")]
        public double DefaultKwota { get; set; }

        [Column(Name = "IDDEFAULT_VAT")]
        public int? IdDefaultVat { get; set; }

        [Column(Name = "IDDEFAULT_JEDNOSTKA_MIAR")]
        public int? IdDefaultJednostkaMiar { get; set; }

        [Column(Name = "IDDEFAULT_WALUTA")]
        public int? IdDefaultWaluta { get; set; }

        [Column(Name = "SWWKU")]
        public string Swwku { get; set; }

        [Column(Name = "KONTO")]
        public string Konto { get; set; }

        [Column(Name = "KONTO_WN")]
        public string KontoWn { get; set; }

        [Column(Name = "KONTO_MA")]
        public string KontoMa { get; set; }

        [Column(Name = "ZERO_KRAJ")]
        public int ZeroKraj { get; set; }

        [Column(Name = "KATEGORIA")]
        public int Kategoria { get; set; }

        [Column(Name = "OPIS_ENG")]
        public string OpisEng { get; set; }

        [Column(Name = "SWW_SPEDYCJA")]
        public string SwwSpedycja { get; set; }

        [Column(Name = "IDDEFAULT_OPIS")]
        public int? IdDefaultOpis { get; set; } = 0;
    }
}
