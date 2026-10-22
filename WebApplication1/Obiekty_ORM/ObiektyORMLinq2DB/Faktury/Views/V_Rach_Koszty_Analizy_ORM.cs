using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.Faktury.Views
{
    [Table(Name = "V_RACH_KOSZTY_ANALIZY_NEW")]
    internal class V_Rach_Koszty_Analizy_ORM
    {
        // Kolumny z tabeli rachp_koszty_tabor (p.*) 

        [Column(Name = "ID_RACHP"), NotNull]
        public int ID_RACHP { get; set; }

        [Column(Name = "ID_RACH"), Nullable]
        public int? ID_RACH { get; set; }

        [Column(Name = "DOTYCZY"), Nullable]
        public int? DOTYCZY { get; set; }

        [Column(Name = "POJAZD"), Nullable]
        public int? POJAZD { get; set; }

        [Column(Name = "NETTO"), Nullable]
        public float? NETTO { get; set; }

        [Column(Name = "BRUTTO"), Nullable]
        public float? BRUTTO { get; set; }

        [Column(Name = "ILOSC"), Nullable]
        public float? ILOSC { get; set; }

        [Column(Name = "ID_WALUTY"), Nullable]
        public int? ID_WALUTY { get; set; }

        [Column(Name = "ID_TABELI"), Nullable]
        public int? ID_TABELI { get; set; }

        [Column(Name = "NAZWA1"), Nullable]
        public string NAZWA1 { get; set; }

        [Column(Name = "NAZWA2"), Nullable]
        public string NAZWA2 { get; set; }

        [Column(Name = "NAZWA3"), Nullable]
        public string NAZWA3 { get; set; }

        [Column(Name = "NACZEPA"), Nullable]
        public int? NACZEPA { get; set; }

        [Column(Name = "UWAGI"), Nullable]
        public string UWAGI { get; set; }

        [Column(Name = "KIEROWCA"), Nullable]
        public int? KIEROWCA { get; set; }

        [Column(Name = "NETTO_W"), Nullable]
        public float? NETTO_W { get; set; }

        [Column(Name = "BRUTTO_W"), Nullable]
        public float? BRUTTO_W { get; set; }

        [Column(Name = "LICZNIK"), Nullable]
        public int? LICZNIK { get; set; }

        [Column(Name = "WYSYLKA"), NotNull]
        public int WYSYLKA { get; set; } = 0;

        [Column(Name = "WYSLANO"), Nullable]
        public DateTime? WYSLANO { get; set; }

        [Column(Name = "ID_ZLECENIA"), Nullable]
        public int? ID_ZLECENIA { get; set; }

        [Column(Name = "IDZLECENIA"), Nullable]
        public int? IDZLECENIA { get; set; }

        [Column(Name = "KW"), Nullable]
        public double? KW { get; set; }

        [Column(Name = "ID_POJAZD"), Nullable]
        public int? ID_POJAZD { get; set; }

        [Column(Name = "IDKIEROWCY"), Nullable]
        public int? IDKIEROWCY { get; set; }

        [Column(Name = "SLOWNIK"), Nullable]
        public string SLOWNIK { get; set; }

        [Column(Name = "FAKT_GLOWNA"), Nullable]
        public int? FAKT_GLOWNA { get; set; }

        [Column(Name = "VAT"), Nullable]
        public double? VAT { get; set; }

        [Column(Name = "IDVAT"), Nullable]
        public int? IDVAT { get; set; }

        [Column(Name = "IDFAKTURY"), Nullable]
        public int? IDFAKTURY { get; set; }

        [Column(Name = "IDKONTRAKT"), Nullable]
        public int? IDKONTRAKT { get; set; }

        [Column(Name = "RODZAJ_TAB"), Nullable]
        public int? RODZAJ_TAB { get; set; }

        [Column(Name = "RODZAJ_KURSU"), Nullable]
        public int? RODZAJ_KURSU { get; set; }

        [Column(Name = "KURS"), Nullable]
        public double? KURS { get; set; }

        [Column(Name = "BANK"), Nullable]
        public int? BANK { get; set; }

        [Column(Name = "IDDZIAL"), Nullable]
        public int? IDDZIAL { get; set; }

        [Column(Name = "ID_FAKTURY"), Nullable]
        public int? ID_FAKTURY { get; set; }

        [Column(Name = "POSREDNI"), Nullable]
        public int? POSREDNI { get; set; }

        [Column(Name = "ID_SRODKA"), Nullable]
        public int? ID_SRODKA { get; set; }

        [Column(Name = "IDKOSZTU"), Nullable]
        public int? IDKOSZTU { get; set; }

        [Column(Name = "VATPLN"), Nullable]
        public double? VATPLN { get; set; }

        [Column(Name = "ALIOR"), Nullable]
        public double? ALIOR { get; set; }

        [Column(Name = "ALIOR_K"), Nullable]
        public double? ALIOR_K { get; set; }

        [Column(Name = "IDUSER"), Nullable]
        public int? IDUSER { get; set; }

        [Column(Name = "NAZWA_TOWARU"), Nullable]
        public string NAZWA_TOWARU { get; set; }

        [Column(Name = "ILOSC_TOWARU"), Nullable]
        public double? ILOSC_TOWARU { get; set; }

        [Column(Name = "ID_TOWARU"), Nullable]
        public int? ID_TOWARU { get; set; }

        [Column(Name = "OGL"), Nullable]
        public string OGL { get; set; }

        [Column(Name = "ID_OGL"), Nullable]
        public int? ID_OGL { get; set; }

        [Column(Name = "RODZAJ_DOKUMENTU"), Nullable]
        public int? RODZAJ_DOKUMENTU { get; set; }



        // reszta

        [Column(Name = "NAZWA_REJ")]
        public string? NazwaRej { get; set; }

        [Column(Name = "SKROT")]
        public string? Skrot { get; set; }

        [Column(Name = "DATADOSTARCZENIA")]
        public DateTime? DataDostarczenia { get; set; }

        [Column(Name = "KONTRAHENT_NAZWA")]
        public string? Kontrahent_Nazwa { get; set; }

        [Column(Name = "RACHUNEK")]
        public string? Rachunek { get; set; }

        [Column(Name = "DATA_WYSTAWIENIA")]
        public DateTime? DATA_WYSTAWIENIA { get; set; }

        [Column(Name = "DATA_SPRZEDAZY")]
        public DateTime? DataSprzedazy { get; set; }

        [Column(Name = "DATA_KSIEGOWA")]
        public DateTime? DataKsiegowa { get; set; }

        [Column("RODZAJ_FAKTURY")]
        public int RODZAJ_FAKTURY { get; set; }

        [Column("IDVATPLN")]
        public int IDVATPLN { get; set; }

        [Column(Name = "KONTRAHENT")]
        public string? Kontrahent { get; set; }

        [Column(Name = "NUMER_PELNY")]
        public string? NumerPelny { get; set; }

        [Column(Name = "ODDZIAL_SKROT")]
        public string? ODDZIAL_SKROT { get; set; }
    }
}
