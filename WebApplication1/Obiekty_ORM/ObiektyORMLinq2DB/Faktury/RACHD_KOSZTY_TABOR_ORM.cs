using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.Faktury
{
    [Table(Name = "RACHD_KOSZTY_TABOR")]
    internal class RACHD_KOSZTY_TABOR_ORM
    {

            [PrimaryKey, Identity]
            [Column("ID_RACHD")]
            public int ID_RACHD { get; set; }
            [Column("NAZWA1")]
            public string NAZWA1 { get; set; }
            [Column("NAZWA2")]
            public string NAZWA2 { get; set; }
            [Column("NAZWA3")]
           public string NAZWA3 { get; set; }
           [Column("UWAGI")]
           public string UWAGI { get; set; }


        }
}
