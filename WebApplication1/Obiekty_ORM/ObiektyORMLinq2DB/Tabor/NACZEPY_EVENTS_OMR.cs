using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.Tabor
{
    [Table(Name = "NACZEPY_EVENTS")]
    internal class NACZEPY_EVENTS_OMR
    {
        [PrimaryKey, Identity]
        [Column(Name = "ID_NACZEPY_EVENTS")]
        public int ID_NACZEPY_EVENTS { get; set; }
        [Column(Name = "ID_EVENT")]
        public int ID_EVENT { get; set; }

        [Column(Name = "ID_NACZEPY")]
        public int ID_NACZEPY { get; set; }

        [Column(Name = "OPIS")]
        public string OPIS { get; set; }

        [Column(Name = "DATA_OD")]
        public DateTime? DATA_OD { get; set; }

        [Column(Name = "DATA_DO")]
        public DateTime? DATA_DO { get; set; }

    }
}
