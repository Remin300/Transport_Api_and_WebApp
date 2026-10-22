using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB.Mapping;
namespace WebApplication1.ObiektyORMLinq2DB.Tabor
{
    [Table(Name = "NORMY")]
    internal class NORMY_OMR
    {
        [PrimaryKey, Identity]
        [Column(Name = "ID_NORMY")]
        public int ID_NORMY { get; set; }

        [Column(Name = "NUMER")]
        public int NUMER { get; set; }

        [Column(Name = "OPIS")]
        public string OPIS { get; set; }

        [Column(Name = "ODTONY")]
        public double ODTONY { get; set; }

        [Column(Name = "DOTONY")]
        public double DOTONY { get; set; }
        [Column(Name = "NORMA")]
        public double NORMA { get; set; }
    }
}
