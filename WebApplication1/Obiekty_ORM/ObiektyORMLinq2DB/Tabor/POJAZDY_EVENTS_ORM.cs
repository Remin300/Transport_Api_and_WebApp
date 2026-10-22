using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LinqToDB.Common.Configuration;
using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.Tabor
{
    [Table(Name = "POJAZDY_EVENTS")]
    internal class POJAZDY_EVENTS_ORM
    {
        [PrimaryKey, Identity]
        [Column(Name = "ID_POJAZDY_EVENTS")]
        public int ID_POJAZDY_EVENTS { get; set; }
        [Column(Name = "ID_EVENT")]
        public int ID_EVENT { get; set; }
        [Column(Name = "ID_POJAZDU")]
        public int ID_POJAZDU { get; set; }
        [Column(Name = "DATA_OD")]
        public DateTime DATA_OD { get; set; }
        [Column(Name = "DATA_DO")]
        public DateTime DATA_DO { get; set; }
        [Column(Name = "OPIS")]
        public string OPIS { get; set; }
        [Column(Name = "SERIA")]
        public string SERIA { get; set; }

        [Column(Name = "KRAJ")]
        public string KRAJ { get; set; }

        [Column(Name = "KARTA")]
        public string KARTA { get; set; }
        [Column(Name = "PIN")]
        public string PIN { get; set; }
    }
}
