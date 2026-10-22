using LinqToDB.Mapping;
using System;

namespace WebApplication1.ObiektyORMLinq2DB.ZleceniaSpedycja.Views
{
    [Table(Name = "VTOWARY_ZBIOROWE_NEW")]
    internal class VTowaryZbiorowe_ORM
    {
        [Column(Name = "ID_TOWARU"), PrimaryKey, NotNull]
        public int ID_TOWARU { get; set; }

        [Column(Name = "ID_ZLECENIA"), NotNull]
        public int ID_ZLECENIA { get; set; }

        [Column(Name = "M_NADANIA_KOD")]
        public string M_NADANIA_KOD { get; set; }

        [Column(Name = "M_NADANIA_MIEJSCOWOSC")]
        public string M_NADANIA_MIEJSCOWOSC { get; set; }

        [Column(Name = "M_NADANIA_ADRES")]
        public string M_NADANIA_ADRES { get; set; }

        [Column(Name = "M_ODBIORU_KOD")]
        public string M_ODBIORU_KOD { get; set; }

        [Column(Name = "M_ODBIORU_MIEJSCOWOSC")]
        public string M_ODBIORU_MIEJSCOWOSC { get; set; }

        [Column(Name = "M_ODBIORU_ADRES")]
        public string M_ODBIORU_ADRES { get; set; }

        [Column(Name = "DOSTAWCA_NAZWA")]
        public string DOSTAWCA_NAZWA { get; set; }

        [Column(Name = "DOSTAWCA_MIEJSCOWOSC")]
        public string DOSTAWCA_MIEJSCOWOSC { get; set; }

        [Column(Name = "DOSTAWCA_ADRES")]
        public string DOSTAWCA_ADRES { get; set; }

        [Column(Name = "ODBIORCA_NAZWA")]
        public string ODBIORCA_NAZWA { get; set; }

        [Column(Name = "ODBIORCA_MIEJSCOWOSC")]
        public string ODBIORCA_MIEJSCOWOSC { get; set; }

        [Column(Name = "ODBIORCA_ADRES")]
        public string ODBIORCA_ADRES { get; set; }

        [Column(Name = "NAZWA")]
        public string NAZWA { get; set; }

        [Column(Name = "ILOSC")]
        public double ILOSC { get; set; }

        [Column(Name = "IMPORTER_NAZWA")]
        public string IMPORTER_NAZWA { get; set; }

        [Column(Name = "IMPORTER_MIEJSCOWOSC")]
        public string IMPORTER_MIEJSCOWOSC { get; set; }

        [Column(Name = "EKSPORTER_NAZWA")]
        public string EKSPORTER_NAZWA { get; set; }

        [Column(Name = "EKSPORTER_MIEJSCOWOSC")]
        public string EKSPORTER_MIEJSCOWOSC { get; set; }

        [Column(Name = "LP")]
        public int LP { get; set; }

        [Column(Name = "INCO")]
        public string INCO { get; set; }

        [Column(Name = "TOWAR_NR")]
        public int TOWAR_NR { get; set; }

        [Column(Name = "METRY_L")]
        public float METRY_L { get; set; }

        [Column(Name = "SZTUKI")]
        public float SZTUKI { get; set; }

        [Column(Name = "ILOSC_OBL")]
        public float ILOSC_OBL { get; set; }

        [Column(Name = "UWAGI")]
        public string UWAGI { get; set; }

        [Column(Name = "ODPRAWA_WYWOZOWA")]
        public string ODPRAWA_WYWOZOWA { get; set; }

        [Column(Name = "ODPRAWA_PRZYWOZOWA")]
        public string ODPRAWA_PRZYWOZOWA { get; set; }

        [Column(Name = "METRY3")]
        public float METRY3 { get; set; }

        [Column(Name = "DATAWYSYLKI")]
        public DateTime DATAWYSYLKI { get; set; }

        [Column(Name = "NUMER_PELNY")]
        public string NUMER_PELNY { get; set; }

        [Column(Name = "OCZEKUJACE")]
        public int OCZEKUJACE { get; set; }

        [Column(Name = "NUMER1")]
        public string NUMER1 { get; set; }

        [Column(Name = "NUMER2")]
        public string NUMER2 { get; set; }

        [Column(Name = "DOKUMENTY")]
        public string DOKUMENTY { get; set; }

        [Column(Name = "WARTOSC")]
        public float WARTOSC { get; set; }

        [Column(Name = "ID_WALUTY")]
        public int ID_WALUTY { get; set; }

        [Column(Name = "WWALUTA")]
        public string WWALUTA { get; set; }

        [Column(Name = "IDFAKTURY")]
        public int IDFAKTURY { get; set; }

        [Column(Name = "FINALIZED")]
        public int FINALIZED { get; set; }
    }
}
