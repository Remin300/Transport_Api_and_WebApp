using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.Faktury.Views
{
    [Table(Name = "VFAKTURA_KSEFNEW")]
    public class VFakturaKSeF_ORM
    {
        [PrimaryKey, Identity]
        [Column(Name = "ID_FAKTURY")]
        public int ID_FAKTURY { get; set; }

        [Column(Name = "NUMERFAKTURY"), NotNull]
        public string NUMERFAKTURY { get; set; }

        [Column(Name = "KONTRAHENT_KOD_KRAJU"), NotNull]
        public string KONTRAHENT_KOD_KRAJU { get; set; }

        [Column(Name = "KONTRAHENT_NAZWA"), NotNull]
        public string KONTRAHENT_NAZWA { get; set; }

        [Column(Name = "KONTRAHENT_NIP"), NotNull]
        public string KONTRAHENT_NIP { get; set; }

        [Column(Name = "KONTRAHENT_ADRES"), NotNull]
        public string KONTRAHENT_ADRES { get; set; }

        [Column(Name = "KONTRAHENT_KOD"), NotNull]
        public string KONTRAHENT_KOD { get; set; }

        [Column(Name = "DATA_WYSTAWIENIA"), NotNull]
        public DateTime DATA_WYSTAWIENIA { get; set; }

        [Column(Name = "DATA_SPRZEDAZY"), NotNull]
        public DateTime DATA_SPRZEDAZY { get; set; }

        [Column(Name = "WARTOSC_NETTO_WALUTA")]
        public double WARTOSC_NETTO_WALUTA { get; set; }

        [Column(Name = "WARTOSC_BRUTTO_WALUTA")]
        public double WARTOSC_BRUTTO_WALUTA { get; set; }

        [Column(Name = "WARTOSC_PODATKU_WALUTA")]
        public double WARTOSC_PODATKU_WALUTA { get; set; }

        [Column(Name = "WARTOSC_NETTO_PLN")]
        public double WARTOSC_NETTO_PLN { get; set; }

        [Column(Name = "WARTOSC_BRUTTO_PLN")]
        public double WARTOSC_BRUTTO_PLN { get; set; }

        [Column(Name = "WARTOSC_PODATKU_PLN")]
        public double WARTOSC_PODATKU_PLN { get; set; }

        [Column(Name = "WALUTA")]
        public string WALUTA { get; set; }

        [Column(Name = "ZATWIERDZONA")]
        public string ZATWIERDZONA { get; set; }

        [Column(Name = "WYSLANA_DO_KSEF")]
        public string WYSLANA_DO_KSEF { get; set; }

        [Column(Name = "RODZAJ_FAKTURY")]
        public string RODZAJ_FAKTURY { get; set; }
    }
}
