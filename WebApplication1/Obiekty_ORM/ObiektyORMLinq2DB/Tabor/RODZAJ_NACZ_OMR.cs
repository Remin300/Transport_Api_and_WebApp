using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB.Mapping;
namespace WebApplication1.ObiektyORMLinq2DB.Tabor
{
    [Table(Name = "RODZAJ_NACZ")]
    internal class RODZAJ_NACZ_OMR
    {
        [PrimaryKey, Identity]
        [Column(Name = "ID_RODZAJ")]
        public int ID_RODZAJ { get; set; }

        [Column(Name = "OPIS")]
        public string OPIS { get; set; }

        [Column(Name = "INTERNALTYP")]
        public int INTERNALTYP { get; set; }
         

    }
}
