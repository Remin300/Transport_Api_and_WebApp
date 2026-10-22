using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.Tabor
{
    [Table(Name = "MARKA_POJ")]
    internal class MARKI_POJ_ORM
    {

            [PrimaryKey, Identity]
            [Column(Name = "ID_MARKA")]
            public int ID_MARKA { get; set; }
            [Column(Name = "OPIS")]
            public string OPIS { get; set; }
    }
}
