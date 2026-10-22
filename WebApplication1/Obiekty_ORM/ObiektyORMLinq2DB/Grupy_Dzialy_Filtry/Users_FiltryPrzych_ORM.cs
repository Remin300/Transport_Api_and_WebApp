using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.Grupy_Dzialy_Filtry
{
    [Table(Name = "USERS_FILTRY_PRZYCH")]
    internal class Users_FiltryPrzych_ORM
    {
        [PrimaryKey, Identity]
        [Column(Name = "ID_USERS_FILTR")]
        public int ID_USERS_FILTR { get; set; }

        [Column(Name = "ID_USER")]
        public int ID_USER { get; set; }

        [Column(Name = "ID_FILTRY_PRZYCH")]
        public int ID_FILTRY_PRZYCH { get; set; }
    }
}
