using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.Waluty
{
    [Table(Name = "NUMERY_TABEL_KURSOW")]
    public class NumerTabeliKursow_ORM
    {
        [PrimaryKey, Identity]
        [Column(Name = "ID_NUM_TAB")]
        public int IdNumTab { get; set; }

        [Column(Name = "NUMER"), NotNull]
        public string Numer { get; set; }

        [Column(Name = "Z_DNIA"), NotNull]
        public DateTime? ZDnia { get; set; }
        [Column(Name = "BANK"), NotNull]
        public int BANK { get; set; } = 0;

    }
}
