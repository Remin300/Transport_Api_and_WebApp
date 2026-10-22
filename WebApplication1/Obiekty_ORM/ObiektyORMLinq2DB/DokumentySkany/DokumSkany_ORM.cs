using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.DokumentySkany
{
    [Table(Name = "DOKUM_SKANY")]
    internal class DokumSkany_ORM
    {
        [PrimaryKey, Identity]
        [Column("ID_DOKUM_SKANY")]
        public int? ID_DOKUM_SKANY { get; set; }

        [Column("IDOBIEKT")]
        public int IDOBIEKT { get; set; } = 0;

        [Column("TYPOBIEKT")]
        public int TYPOBIEKT { get; set; } = 0;

        // Typy obiektów:    
        // 1 - Zlecenia_Sped
        // 2 - Kontrahent
        // 3 - Faktura
        // 4 - Paczki



        [Column("DATA_WPISU")]
        public DateTime DATA_WPISU { get; set; }

        [Column("OPIS")]
        public string OPIS { get; set; }

        [Column("ORYGNAME")]
        public string ORYGNAME { get; set; }

    }
}
