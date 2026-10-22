using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.TS
{
    [Table(Name = "KONFIGURACJA")]
    internal class KONFIGURACJA_ORM
    {
        [PrimaryKey, Identity] // Klucz główny z autoincrementem
        [Column(Name = "ID_KONFIG")]
        public int ID_KONFIG { get; set; }

        [Column(Name = "VALUE_INT"), Nullable]
        public int VALUE_INT { get; set; }

        [Column(Name = "POLE")]
        public string POLE { get; set; }
        [Column(Name = "VALUE_STRING")]
        public string VALUE_STRING { get; set; }
        [Column(Name = "OPIS")]
        public string OPIS { get; set; }
        [Column(Name = "VALUE_FLOAT")]
        public double VALUE_FLOAT { get; set; }

        [Column(Name = "VALUE_DATE"), Nullable]
        public DateTime? VALUE_DATE { get; set; }
    }
}
