using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.Kontrahenci
{
    [Table(Name = "KONTRAHENCI_SLOWNIKI")] // Tabela w bazie danych ma nazwę "KONTRAHENCI"
    internal class Kontrahenci_Slowniki_ORM
    {
        [PrimaryKey, Identity] // Klucz główny z autoincrementem
        [Column(Name = "ID")]
        public int ID { get; set; }

        [Column(Name = "ID_KONTRAHENTA")]
        public int ID_KONTRAHENTA { get; set; }

        [Column(Name = "ZLECENIA_UWAGI"), Nullable]
        public string ZLECENIA_UWAGI { get; set; }

        [Column(Name = "ZLECENIA_DOD_OPIS"), Nullable]
        public string ZLECENIA_DOD_OPIS { get; set; }

        [Column(Name = "POLE1"), Nullable]
        public string POLE1 { get; set; }

        [Column(Name = "POLE2"), Nullable]
        public string POLE2 { get; set; }

        [Column(Name = "POLE3"), Nullable]
        public string POLE3 { get; set; }

        [Column(Name = "POLE4"), Nullable]
        public string POLE4 { get; set; }

        [Column(Name = "POLE5"), Nullable]
        public string POLE5 { get; set; }
    }
}
