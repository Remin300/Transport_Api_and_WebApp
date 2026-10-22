using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.Analizy
{
    [Table(Name = "V_ANALIZY_NEW")]
    internal class V_ANALIZY_NEW_ORM
    {


        [Column("ZLEC_DATA")]
        public DateTime? Zlec_Data { get; set; }

        [Column("FAKTURA_DATA_SPRZED")]
        public DateTime? FakturaDataSprzed { get; set; }

        [Column("FAKTURA_DATA_WYSTAW")]
        public DateTime? FakturaDataWystaw { get; set; }

        [Column("FAKTURA_NUMER"), Nullable]
        public string? FakturaNumer { get; set; }

        [Column("ID_FAKTURY")]
        public int? IdFaktury { get; set; }

        [Column("ID_ODBIORCA")]
        public int? IdOdbiorca { get; set; }

        [Column("ID_ZLECENIODAWCA")]
        public int? IdZleceniodawca { get; set; }

        [Column("IDTOWARU")]
        public int? IdTowaru { get; set; }

        [Column("IDZLECENIA")]
        public int? IdZlecenia { get; set; }

        [Column("ODBIORCA_NAZWA"), Nullable]
        public string? OdbiorcaNazwa { get; set; }

        [Column("OPLATA_ZA"), Nullable]
        public string? OplataZa { get; set; }

        [Column("OPLATA_ZA_SP"), Nullable]
        public string? OplataZaSp { get; set; }

        [Column("RACH_KOSZT_DATA_WYSTAW")]
        public DateTime? RachKosztDataWystaw { get; set; }

        [Column("RACH_KOSZT_NR"), Nullable]
        public string? RachKosztNr { get; set; }

        [Column("STAKA_WLAS_ILOSC")]
        public double? StawkaWlasIlosc { get; set; }

        [Column("STAWKA_WLAS_ID_WALUTA")]
        public int? StawkaWlasIdWaluta { get; set; }

        [Column("STAWKA_WLAS_WALUTA_SYMB"), Nullable]
        public string? StawkaWlasWalutaSymb { get; set; }

        [Column("SW_ID_TABELA")]
        public int? SwIdTabela { get; set; }

        [Column("SW_KURS")]
        public double? SwKurs { get; set; }

        [Column("SW_KWOTA_W_WALUCIE")]
        public double? SwKwotaWWalucie { get; set; }

        [Column("SW_PLN")]
        public double? SwPln { get; set; }

        [Column("SW_VAT_SYMBOL"), Nullable]
        public string? SwVatSymbol { get; set; }

        [Column("TOW_KOSZ_ID_TABELA")]
        public int? TowKoszIdTabela { get; set; }

        [Column("TOW_KOSZ_KURS")]
        public double? TowKoszKurs { get; set; }

        [Column("TOW_KOSZ_KWOTA_W_WALUCIE")]
        public double? TowKoszKwotaWWalucie { get; set; }

        [Column("TOW_KOSZ_PLN")]
        public double? TowKoszPln { get; set; }

        [Column("TOW_KOSZ_VAT_SYMBOL"), Nullable]
        public string? TowKoszVatSymbol { get; set; }

        [Column("TOW_KOSZTY_ID_WALUTA")]
        public int? TowKosztyIdWaluta { get; set; }

        [Column("TOW_KOSZTY_WALUTA_SYMB"), Nullable]
        public string? TowKosztyWalutaSymb { get; set; }

        [Column("TOWAR_NR")]
        public int? TowarNr { get; set; }

        [Column("ZLEC_PRZELAD"), Nullable]
        public string? ZlecPrzelad { get; set; }

        [Column("ZLECENIODAWNA_NAZWA"), Nullable]
        public string? ZleceniodawnaNazwa { get; set; }

        [Column("ZYSK_PLN")]
        public double? ZyskPln { get; set; }
    }
}
