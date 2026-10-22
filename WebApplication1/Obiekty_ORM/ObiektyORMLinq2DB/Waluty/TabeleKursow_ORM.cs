using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.Waluty
{
    [Table(Name = "TABELE_KURSOW")]
    internal class TabeleKursow_ORM
    {
        [PrimaryKey, Identity] // Klucz podstawowy
        [Column(Name = "ID_TABELI")]
        public int ID_TABELI { get; set; }

        [Column(Name = "ID_NUM_TAB")] // Mapped to the column 'ID_NUM_TAB'
        public int ID_NUM_TAB { get; set; }

        [Column(Name = "ID_WALUTY")] // Mapped to the column 'ID_WALUTY'
        public int ID_WALUTY { get; set; }
        [Column(Name = "ILOSC")] // Mapped to the column 'ILOSC'
        public int ILOSC { get; set; }
        [Column(Name = "KURS")] // Mapped to the column 'KURS'
        public double KURS { get; set; }
        [Column(Name = "SREDNI")]
        public int SREDNI { get; set; } = 0;
        [Column(Name = "BANK")]
        public int BANK { get; set; } = 0;        
    }
}
