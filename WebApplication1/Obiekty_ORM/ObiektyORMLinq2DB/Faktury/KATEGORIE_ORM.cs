using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.Faktury
{

    [Table(Name = "KATEGORIE")]
    public class KATEGORIE_ORM
    {
        [PrimaryKey, Identity]
        [Column(Name = "ID_KATEGORIE")]
        public int ID_KATEGORIE { get; set; }

        [Column(Name = "NAZWA_KAT")]
        public string NAZWA_KAT { get; set; }

        [Column(Name = "SYMBOL")]
        public string SYMBOL { get; set; }

        [Column(Name = "UWAGI")]
        public string UWAGI { get; set; }

    }
}
