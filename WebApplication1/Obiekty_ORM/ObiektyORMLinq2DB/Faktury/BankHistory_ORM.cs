using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.Faktury
{
    [Table(Name = "BANK_HISTORY")]
    public class BankHistory_ORM
    {
        [PrimaryKey, Identity]
        [Column(Name = "ID_BANKH")]
        public int IdBankh { get; set; }

        [Column(Name = "DATA_KSIEGOWANIA"), Nullable]
        public DateTime? DataKsiegowania { get; set; }

        [Column(Name = "DATA_TRANSAKCJI"), Nullable]
        public DateTime? DataTransakcji { get; set; }

        [Column(Name = "NADAWCA"), Nullable]
        public string Nadawca { get; set; }

        [Column(Name = "ODBIORCA"), Nullable]
        public string Odbiorca { get; set; }

        [Column(Name = "TYTUL_PLATNOSCI"), Nullable]
        public string TytulPlatnosci { get; set; }

        [Column(Name = "TYTUL_PLATNOSCI1"), Nullable]
        public string TytulPlatnosci1 { get; set; }

        [Column(Name = "TYTUL_PLATNOSCI2"), Nullable]
        public string TytulPlatnosci2 { get; set; }

        [Column(Name = "ID_NADAWCA"), Nullable]
        public int? IdNadawca { get; set; }

        [Column(Name = "ID_ODBIORCA"), Nullable]
        public int? IdOdbiorca { get; set; }

        [Column(Name = "OPIS_TRANSAKCJI"), Nullable]
        public string OpisTransakcji { get; set; }

        [Column(Name = "KWOTA"), Nullable]
        public double Kwota { get; set; }

        [Column(Name = "WALUTA"), Nullable]
        public string Waluta { get; set; }

        [Column(Name = "SALDO_PO_OPERACJI"), Nullable]
        public double? SaldoPoOperacji { get; set; }

        [Column(Name = "ID_DOKUMENTU"), Nullable]
        public int? IdDokumentu { get; set; }

        [Column(Name = "PRZYCHOD_ROZCHOD"), Nullable]
        public int? PrzychodRozchod { get; set; }

        [Column(Name = "IDKONTA_BANKOWEGO"), Nullable]
        public int? IdKontaBankowego { get; set; }

        [Column(Name = "UWAGI"), Nullable]
        public string Uwagi { get; set; }

        [Column(Name = "NUMER"), Nullable]
        public int? Numer { get; set; }

        [Column(Name = "NUMER_FK"), Nullable]
        public int? NumerFk { get; set; }

        [Column(Name = "POZOSTALO"), Nullable]
        public double? Pozostalo { get; set; }

        [Column(Name = "ROZLICZONE"), Nullable]
        public double? Rozliczone { get; set; }

        [Column(Name = "KURS"), Nullable]
        public double? Kurs { get; set; }

        [Column(Name = "ID_KIEROWCY"), Nullable]
        public int? IdKierowcy { get; set; }

        [Column(Name = "RODZAJ"), Nullable]
        public int? Rodzaj { get; set; }

        [Column(Name = "NADPLATA"), Nullable]
        public int? Nadplata { get; set; }

        [Column(Name = "ZWROT"), Nullable]
        public int? Zwrot { get; set; }

        [Column(Name = "FAKTID"), Nullable]
        public int? FaktId { get; set; }

        [Column(Name = "ID_RAPORT_KAS"), Nullable]
        public int? IdRaportKas { get; set; }

        [Column(Name = "ID_DOK_KAS"), Nullable]
        public int? IdDokKas { get; set; }

        [Column(Name = "KOD"), Nullable]
        public string Kod { get; set; }

        [Column(Name = "TRANSAKCJA"), Nullable]
        public string Transakcja { get; set; }

        [Column(Name = "OPIS1"), Nullable]
        public string Opis1 { get; set; }

        [Column(Name = "IDDZIAL"), Nullable]
        public int? IdDzial { get; set; }

        [Column(Name = "PELNY_RACHUNEK_KONTRAHENTA"), Nullable]
        public string Pelny_Rachunek_Kontrahenta { get; set; }
    }
}
