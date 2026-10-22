using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.Faktury
{
    [Table(Name = "KONTA_KSIEGOWE")]
    internal class Konta_Ksiegowe_ORM
    {
        
     [PrimaryKey, Identity]
     [Column("ID_KONTA_KSIEGOWE")]
    public int ID_KONTA_KSIEGOWE { get; set; }
     [Column("NAZWA")]
     public string NAZWA {  get; set; }
    [Column("KONTO")]
    public string KONTO { get; set; }

    [Column("TRESC_FAKT")]
    public string TRESC_FAKT { get; set; }

/*        NIEWIDOCZNE INTEGER default 0 NOT NULL,
    KOSZTY_INNE        INTEGER default 0 NOT NULL,
    DODATKOWE1         INTEGER default 0 NOT NULL,
    DODATKOWE2         INTEGER default 0 NOT NULL,
    DODATKOWE3         VARCHAR(25),
    DODATKOWE4 VARCHAR(50),
    DODATKOWE5 DOUBLE PRECISION default 0 NOT NULL,
    DODATKOWE6         DOUBLE PRECISION default 0 NOT NULL,
    IDREJESTR          INTEGER,
     VARCHAR(250),
    PKWIU VARCHAR(20),
    JM VARCHAR(10),
    KWOTA DOUBLE PRECISION,
    KONTOMA VARCHAR(20) */

    }
}
