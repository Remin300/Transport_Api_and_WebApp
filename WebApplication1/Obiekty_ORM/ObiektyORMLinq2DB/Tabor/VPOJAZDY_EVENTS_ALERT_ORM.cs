using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB.Mapping;
namespace WebApplication1.ObiektyORMLinq2DB.Tabor
{
    [Table(Name = "VPOJAZDY_EVENTS_ALERT")]
    internal class VPOJAZDY_EVENTS_ALERT_ORM
    {
        [Column(Name = "ID_POJAZDY_EVENTS")]
        public int ID_POJAZDY_EVENTS { get; set; }
        [Column(Name = "ID_EVENTSLIST")]
        public int ID_EVENTSLIST { get; set; }
        [Column(Name = "ID_POJAZDU")]
        public int ID_POJAZDU { get; set; }
        [Column(Name = "DATA_OD")]
        public DateTime? DATA_OD { get; set; }
        [Column(Name = "DATA_DO")]
        public DateTime? DATA_DO { get; set; }

        [Column(Name = "SERIA")]
        public string SERIA { get; set; }

        [Column(Name = "KRAJ")]
        public string KRAJ { get; set; }

        [Column(Name = "KARTA")]
        public string KARTA { get; set; }
        [Column(Name = "PIN")]
        public string PIN { get; set; }
        [Column(Name = "OPIS")]
        public string OPIS { get; set; }

        [Column(Name = "UWAGI")]
        public string UWAGI { get; set; }

        [Column(Name = "EWIDPOJAZD")]
        public string EWIDPOJAZD { get; set; }

        [Column(Name = "EVENTSNAME")]
        public string EVENTSNAME { get; set; }

        [Column(Name = "SERIA_LIST")]
        public string SERIA_LIST { get; set; }

        [Column(Name = "ALERTBEFORE")]
        public int ALERTBEFORE { get; set; }

        [Column(Name = "ID_GATUNKU")]
        public int ID_GATUNKU { get; set; }

        [Column(Name = "NR_REJ")]
        public string NR_REJ { get; set; }

        [Column(Name = "GRUPA")]
        public string GRUPA { get; set; }
        [Column(Name = "RODZAJ_DOK")]
        public string RODZAJ_DOK { get; set; }

        [Column(Name = "ALERTBEFORE_ALERT"), Nullable]
        public DateTime? ALERTBEFORE_ALERT { get; set; }

    }
}
