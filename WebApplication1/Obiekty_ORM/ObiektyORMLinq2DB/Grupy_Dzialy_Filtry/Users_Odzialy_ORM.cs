using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.Grupy_Dzialy_Filtry
{

    [Table(Name = "USERS_ODDZIALY")]
    internal class Users_Odzialy_ORM
    {
        [PrimaryKey, Identity]
        [Column(Name = "ID_USERS_ODDZIALY")]
        public int ID_USERS_ODDZIALY { get; set; }

        [Column(Name = "IDUSER")]
        public int IDUSER { get; set; }

        [Column(Name = "IDODDZIALY")]
        public int IDODDZIALY { get; set; }

        [Column(Name = "ODDZIALYRIGHTS")]
        public string ODDZIALYRIGHTS { get; set; }
    }
}
