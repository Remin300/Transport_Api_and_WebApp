using LinqToDB.Mapping;
using System;

namespace WebApplication1.ObiektyORMLinq2DB.ZleceniaSpedycja
{
    [Table(Name = "TOWARY_MAGAZYN")]
    internal class TowaryMagazyn_ORM
    {
        [PrimaryKey, Identity]
        [Column("ID_TOWARY_MAGAZYN")]
        public int ID_TOWARY_MAGAZYN { get; set; }

        [Column("ID_PRZESYLKI")]
        public int ID_PRZESYLKI { get; set; }

        [Column("ID_ZLECENIA")]
        public int ID_ZLECENIA { get; set; }

        [Column("ID_TOWARY_SRC")]
        public int ID_TOWARY_SRC { get; set; }

        [Column("ID_TOWARY_DST")]
        public int ID_TOWARY_DST { get; set; }

        [Column("WYDANO")]
        public int WYDANO { get; set; }

        [Column("ID_MIEJSCA_NAD")]
        public int? ID_MIEJSCA_NAD { get; set; }

        [Column("ID_MIEJSCA_ODB")]
        public int? ID_MIEJSCA_ODB { get; set; }

        [Column("ID_DOSTAWCY")]
        public int? ID_DOSTAWCY { get; set; }

        [Column("ID_ODBIORCY")]
        public int? ID_ODBIORCY { get; set; }

        [Column("NAZWA")]
        public string NAZWA { get; set; }

        [Column("NUMER3")]
        public string NUMER3 { get; set; }

        [Column("NUMER4")]
        public string NUMER4 { get; set; }

        [Column("NUMER5")]
        public string NUMER5 { get; set; }

        [Column("NUMER6")]
        public string NUMER6 { get; set; }

        [Column("NUMER7")]
        public string NUMER7 { get; set; }

        [Column("ILOSC")]
        public double ILOSC { get; set; }

        [Column("ID_JEDNOSTKI_MIARY")]
        public int ID_JEDNOSTKI_MIARY { get; set; }

        [Column("ILOSC_DEKLAROWANA")]
        public double ILOSC_DEKLAROWANA { get; set; }

        [Column("ID_FRACHTU")]
        public int ID_FRACHTU { get; set; }

        [Column("ID_IMPORTER")]
        public int? ID_IMPORTER { get; set; }

        [Column("ID_EXPORTER")]
        public int? ID_EXPORTER { get; set; }

        [Column("LP")]
        public int LP { get; set; }

        [Column("ID_INCOTERMS")]
        public int ID_INCOTERMS { get; set; }

        [Column("ID_TRANZYT")]
        public int ID_TRANZYT { get; set; }

        [Column("BEZPOSREDNIA")]
        public int BEZPOSREDNIA { get; set; }

        [Column("LOTNICZA")]
        public int LOTNICZA { get; set; }

        [Column("TRANZYT")]
        public int TRANZYT { get; set; }

        [Column("METRY")]
        public double METRY { get; set; }

        [Column("SUBSPEDYTOR")]
        public int SUBSPEDYTOR { get; set; }

        [Column("ID_SUBSPEDYCJA")]
        public int ID_SUBSPEDYCJA { get; set; }

        [Column("ID_SPED_ZLECONY")]
        public int ID_SPED_ZLECONY { get; set; }

        [Column("IDTOWARY_KOSZTY")]
        public int IDTOWARY_KOSZTY { get; set; }

        [Column("IDTOWARY_STAWKI")]
        public int IDTOWARY_STAWKI { get; set; }

        [Column("METRY_L")]
        public double METRY_L { get; set; }

        [Column("SZTUKI")]
        public double SZTUKI { get; set; }

        [Column("ILOSC_OBL")]
        public double ILOSC_OBL { get; set; }

        [Column("ODPRAWA_WYWOZOWA")]
        public string ODPRAWA_WYWOZOWA { get; set; }

        [Column("ODPRAWA_PRZYWOZOWA")]
        public string ODPRAWA_PRZYWOZOWA { get; set; }

        [Column("TOWAR_NR")]
        public int TOWAR_NR { get; set; }

        [Column("DATA_PRZYJECIA")]
        public DateTime DATA_PRZYJECIA { get; set; }

        [Column("DATA_WYDANIA")]
        public DateTime DATA_WYDANIA { get; set; }

        [Column("METRY3")]
        public double METRY3 { get; set; }

        [Column("IDFAKTURY")]
        public int IDFAKTURY { get; set; }

        [Column("NUMER1")]
        public string NUMER1 { get; set; }

        [Column("WARTOSC")]
        public double WARTOSC { get; set; }

        [Column("ID_WALUTY")]
        public int ID_WALUTY { get; set; }

        [Column("NUMER2")]
        public string NUMER2 { get; set; }

        [Column("DOKUMENTY")]
        public string DOKUMENTY { get; set; }

        [Column("ID_TABELI")]
        public int ID_TABELI { get; set; }

        [Column("MIEJSCE_ZA")]
        public string MIEJSCE_ZA { get; set; }

        [Column("MIEJSCE_RO")]
        public string MIEJSCE_RO { get; set; }

        [Column("FAKTURA")]
        public int FAKTURA { get; set; }

        [Column("BLOKADA")]
        public int BLOKADA { get; set; }
    }
}
