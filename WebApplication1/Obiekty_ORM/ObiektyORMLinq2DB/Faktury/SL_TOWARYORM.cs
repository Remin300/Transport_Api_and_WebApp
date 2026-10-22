using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.Faktury
{
    [Table(Name = "SL_TOWARY")]
    public class SL_TOWARYORM
    {
        [PrimaryKey, Identity]
        [Column("ID_TOWARU")]
        public int ID_TOWARU { get; set; }
        [Column("NAZWA")]
        public string NAZWA { get; set; }
        [Column("NAZWA_PRAWIDLOWA")]
        public string NAZWA_PRAWIDLOWA { get; set; }
        [Column("KLASA_ADR")]
        public string KLASA_ADR { get; set; }
        [Column("KOD")]
        public string KOD { get; set; }
        [Column("ADR_UN")]
        public string ADR_UN { get; set; }
        [Column("OPIS")]
        public string OPIS { get; set; }
        [Column("GRUPA_PAKOWANIA")]
        public int GRUPA_PAKOWANIA { get; set; }
        [Column("ID_KLASA_ADR")]
        public int ID_KLASA_ADR { get; set; }
        [Column("RYZYKO")]
        public string RYZYKO { get; set; }
    }

}
