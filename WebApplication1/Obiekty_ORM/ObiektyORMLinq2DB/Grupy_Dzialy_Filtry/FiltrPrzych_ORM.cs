using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.Grupy_Dzialy_Filtry
{
    [Table(Name = "FILTRY_PRZYCH")]
    public class FiltrPrzych_ORM
    {
        [PrimaryKey, Column(Name = "ID_FILTRY_PRZYCH")]
        public int ID_FILTRY_PRZYCH { get; set; }

        [Column(Name = "NR_FILTRA")]
        public int NR_FILTRA { get; set; }

        [Column(Name = "IDENT")]
        public int IDENT { get; set; }

        [Column(Name = "OPIS")]
        public string? OPIS { get; set; }
    }
}
