using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.ObiektyORMLinq2DB.TS.Kierowcy
{
    
    [Table(Name = "RODZAJ_TOW")]
    internal class RODZAJ_TOW_ORM
    {
        [PrimaryKey, Identity]
        [Column(Name = "ID_RODZAJ")]
        public int ID_RODZAJ { get; set; }

        [Column(Name = "OPIS")]
        public string OPIS { get; set; }

        [Column(Name = "UWAGI")]
        public string UWAGI { get; set; }
    }

}
