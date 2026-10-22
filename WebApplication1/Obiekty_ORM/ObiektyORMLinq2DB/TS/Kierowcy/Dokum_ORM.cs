using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.ObiektyORMLinq2DB.TS.Kierowcy
{
    [Table(Name = "DOKUM")]
    internal class Dokum_ORM
    {
        [PrimaryKey, Identity]
        [Column(Name = "ID_DOKUM")]
        public int ID_DOKUM { get; set; }

        [Column(Name = "OPIS")]
        public string OPIS { get; set; }

        [Column(Name = "ALERTBEFORE")]
        public int? ALERTBEFORE { get; set; } = 0;
    }
}
