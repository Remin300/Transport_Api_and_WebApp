using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.Poczta_Paczki
{
    [Table(Name = "POCZTA_PACZKI_POZYCJE")]
    internal class POCZTA_PACZKI_POZYCJE_ORM
    {
        [PrimaryKey, Identity]
        public int ID { get; set; }

        [Column]
        public int ID_PACZKI { get; set; }


        [Column]
        public int? ID_RODZAJU_DOK { get; set; }


        [Column]
        public string UWAGI { get; set; }

        [Column]
        public string NUMER_DOKUM { get; set; }


        [Column]
        public int? ID_ZLECENIA { get; set; }

        [Column]
        public int? ID_TOWARU { get; set; }


        [Column]
        public int? ID_FAKTURY { get; set; }

        [Column]
        public int? ID_RACH_KOSZT { get; set; }




    }
}
