using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.Tabor
{
    [Table(Name = "RODZAJ_POJ")]
    internal class RODZAJ_POJ_OMR
    {
        [PrimaryKey, Identity]
        [Column(Name = "ID_RODZAJ")]
        public int ID_RODZAJ { get; set; }
        [Column(Name = "OPIS")]
        public string OPIS { get; set; }
    }
}
