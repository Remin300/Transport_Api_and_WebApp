using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.Tabor
{
    [Table(Name = "EVENTSLIST")]
    internal class EVENTSLIST_ORM
    {
        [PrimaryKey] // Klucz główny
        [Column(Name = "ID_EVENTSLIST")]
        public int ID_EVENTSLIST { get; set; }


        [Column(Name = "SERIA")]
        public int SERIA { get; set; }

        [Column(Name = "SHORTINFO")]
        public string SHORTINFO { get; set; }


        [Column(Name = "FULLINFO")]
        public string FULLINFO { get; set; }


        [Column(Name = "ALERTBEFORE")]
        public int ALERTBEFORE { get; set; }


    }
}
