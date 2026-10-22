using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.Tabor
{

    [Table(Name = "GATUNKI_POJ")]
    internal class GATUNKI_POJ_ORM
    {
        [PrimaryKey, Identity]
        [Column(Name = "ID_GATUNKU")]
        public int ID_GATUNKU { get; set; }
        [Column(Name = "OPIS")]
        public string OPIS { get; set; }
        [Column(Name = "GATUNEK_KARTY")]
        public int GATUNEK_KARTY { get; set; }
    }
}
