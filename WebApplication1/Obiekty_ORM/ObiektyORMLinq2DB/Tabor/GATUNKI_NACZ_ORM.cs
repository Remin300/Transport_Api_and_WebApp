using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.ObiektyORMLinq2DB.Tabor
{
    [Table(Name = "GATUNKI_NACZ")]
    internal class GATUNKI_NACZ_ORM
    {
        [PrimaryKey, Identity]
        [Column(Name = "ID_GATUNKU")]
        public int ID_GATUNKU { get; set; }
        [Column(Name = "OPIS")]
        public string OPIS { get; set; }

        [Column(Name = "GATUNEK_KARTY")]
        public int GATUNEK_KARTY { get; set; } = 0;

    }
}
