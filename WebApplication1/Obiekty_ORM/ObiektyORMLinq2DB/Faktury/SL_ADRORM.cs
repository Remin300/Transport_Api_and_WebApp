using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.Faktury
{
    [Table(Name = "SL_ADR")]
    public class SL_ADRORM
    {
        [PrimaryKey, Identity]
        [Column("ID_ADR")]
        public int ID_ADR { get; set; }
        [Column("KLASA_ADR")]
        public string KLASA_ADR { get; set; }
        [Column("OPIS")]
        public string OPIS { get; set; }
        [Column("KOD_UN")]
        public string KOD_UN { get; set; }
        [Column("KOD_UN")]
        public string KOD { get; set; }
    }
}
