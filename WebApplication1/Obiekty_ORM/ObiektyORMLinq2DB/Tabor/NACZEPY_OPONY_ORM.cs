using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LinqToDB.Common.Configuration;
using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.Tabor
{
    [Table(Name = "NACZEPY_OPONY")]
    internal class NACZEPY_OPONY_ORM
    {
        [PrimaryKey, Identity]
        [Column(Name = "ID_NACZEPY_OPONY")]
        public int ID_NACZEPY_OPONY { get; set; }
        [Column(Name = "ID_NACZEPY")]
        public int ID_NACZEPY { get; set; }
        [Column(Name = "NAZWA")]
        public string NAZWA { get; set; }
        [Column(Name = "ROZMIAR")]
        public string ROZMIAR { get; set; }
        [Column(Name = "OS")]
        public string OS { get; set; }
        [Column(Name = "FAKTURA")]
        public string FAKTURA { get; set; }
        [Column(Name = "ILOSC")]
        public int ILOSC { get; set; }
        [Column(Name = "LICZNIK")]
        public int LICZNIK { get; set; }
        [Column(Name = "PRZEBIEG")]
        public int PRZEBIEG { get; set; }
        [Column(Name = "ZDJECIE_LICZNIK_PRZEBIEG")]
        public int ZDJECIE_LICZNIK_PRZEBIEG { get; set; }
        [Column(Name = "NETTO")]
        public double NETTO { get; set; }
        [Column(Name = "BRUTTO")]
        public double BRUTTO { get; set; }

        [Column(Name = "DATA")]
        public DateTime? DATA { get; set; }

        [Column(Name = "DATA_ZALOZENIA")]
        public DateTime? DATA_ZALOZENIA { get; set; }

        [Column(Name = "DATA_ZDJECIA")]
        public DateTime? DATA_ZDJECIA { get; set; }


        

    }
}
