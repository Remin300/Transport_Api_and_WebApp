using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.DaneFirmy
{
    [Table(Name = "DANE_FIRMY")]
    public class Dane_Firmy_ORM
    {
        [PrimaryKey] // Klucz główny
        [Column(Name = "ID_DANE_FIRMY")]
        public int IdDaneFirmy { get; set; }

        [Column(Name = "NAZWA"), Nullable]
        public string? Nazwa { get; set; }

        [Column(Name = "KOD"), Nullable]
        public string? Kod { get; set; }

        [Column(Name = "MIEJSCOWOSC"), Nullable]
        public string? Miejscowosc { get; set; }

        [Column(Name = "ADRES"), Nullable]
        public string? Adres { get; set; }

        [Column(Name = "POBOX"), Nullable]
        public string? Pobox { get; set; }

        [Column(Name = "NIP"), Nullable]
        public string? NIP { get; set; }

        [Column(Name = "REGON"), Nullable]
        public string? REGON { get; set; }

        [Column(Name = "KONTAKT1"), Nullable]
        public string? Kontakt1 { get; set; }

        [Column(Name = "KONTAKT2"), Nullable]
        public string? Kontakt2 { get; set; }

        [Column(Name = "KONTAKT3"), Nullable]
        public string? Kontakt3 { get; set; }

        [Column(Name = "KONTAKT4"), Nullable]
        public string? Kontakt4 { get; set; }

        [Column(Name = "KONTAKT5"), Nullable]
        public string? Kontakt5 { get; set; }

        [Column(Name = "MIEJSCE_WYSTAWIANIA"), Nullable]
        public string? MiejsceWystawiania { get; set; }

        [Column(Name = "IDENTYFIKATOR"), Nullable]
        public int? Identyfikator { get; set; }

        [Column(Name = "KONTAKT6"), Nullable]
        public string? Kontakt6 { get; set; }

        [Column(Name = "WOJEWODZTWO"), Nullable]
        public string? Wojewodztwo { get; set; }

        [Column(Name = "EURONIP_1"), Nullable]
        public string? Euronip1 { get; set; }

        [Column(Name = "EURONIP_2"), Nullable]
        public string? Euronip2 { get; set; }

        [Column(Name = "EURONIP_3"), Nullable]
        public string? Euronip3 { get; set; }

        [Column(Name = "EURONIP_4"), Nullable]
        public string? Euronip4 { get; set; }

        [Column(Name = "EURONIP_5"), Nullable]
        public string? Euronip5 { get; set; }

        [Column(Name = "LOGO"), Nullable]
        public byte[]? Logo { get; set; }

        [Column(Name = "FIRMY_ID"), Nullable]
        public int? FirmyId { get; set; }



        [Column(Name = "JPK_WOJ"), Nullable]
        public string? JpkWoj { get; set; }

        [Column(Name = "JPK_POWIAT"), Nullable]
        public string? JpkPowiat { get; set; }

        [Column(Name = "JPK_GMINA"), Nullable]
        public string? JpkGmina { get; set; }

        [Column(Name = "JPK_URZAD"), Nullable]
        public string? JpkUrzad { get; set; }

        [Column(Name = "JPK_ULICA"), Nullable]
        public string? JpkUlica { get; set; }

        [Column(Name = "JPK_NRDOM"), Nullable]
        public string? JpkNrDom { get; set; }

        [Column(Name = "JPK_MIASTO"), Nullable]
        public string? JpkMiasto { get; set; }

        [Column(Name = "JPK_KOD"), Nullable]
        public string? JpkKod { get; set; }

        [Column(Name = "JPK_POCZTA"), Nullable]
        public string? JpkPoczta { get; set; }
        [Column(Name = "JPK_BDO"), Nullable]
        public string? JPK_BDO  { get; set; }

        [Column(Name = "STOPKA_1"), Nullable]
        public string? STOPKA_1 { get; set; }

        [Column(Name = "STOPKA_2"), Nullable]
        public string? STOPKA_2 { get; set; }

        [Column(Name = "STOPKA_3"), Nullable]
        public string? STOPKA_3 { get; set; }

    }
}
