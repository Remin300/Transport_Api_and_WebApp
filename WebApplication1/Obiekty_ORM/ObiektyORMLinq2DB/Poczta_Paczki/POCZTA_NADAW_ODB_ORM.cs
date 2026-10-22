using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.Poczta_Paczki
{
    [Table(Name = "POCZTA_NADAW_ODB")]
    internal class POCZTA_NADAW_ODB_ORM
    {
        [PrimaryKey, Identity]
        public int ID { get; set; }

        [Column, NotNull]
        public string NAZWA { get; set; }

        [Column]
        public string ADRES { get; set; }

        [Column]
        public string MIASTO { get; set; }

        [Column]
        public string KOD_POCZTOWY { get; set; }

        [Column]
        public string KRAJ { get; set; }

        [Column]
        public string TELEFON { get; set; }

        [Column]
        public string EMAIL { get; set; }


        [Column]
        public string UWAGI { get; set; }
    }
}
