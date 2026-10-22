using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.Poczta_Paczki
{
    [Table(Name = "POCZTA_PACZKI")]
    internal class POCZTA_PACZKI_ORM
    {
        [PrimaryKey, Identity]
        public int ID { get; set; }

        [Column]
        public DateTime DATA { get; set; }

        [Column]
        public int ODEB_1_WYSL_2 { get; set; } // 1=odebrane, 2=wysłane

        [Column]
        public int ID_NADAWCA_ODBIORCA { get; set; }

        [Column]
        public int USER_ID { get; set; }


        [Column]
        public string UWAGI { get; set; }

        [Association(ThisKey = "ID_NADAWCA_ODBIORCA", OtherKey = "ID", CanBeNull = false)]
        public POCZTA_NADAW_ODB_ORM NadawcaOdbiorca { get; set; }


    }
}
