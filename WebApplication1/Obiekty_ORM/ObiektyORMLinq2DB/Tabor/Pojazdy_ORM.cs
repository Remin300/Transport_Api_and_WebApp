using LinqToDB.Mapping;
using System;

namespace WebApplication1.ObiektyORMLinq2DB.Tabor
{
    [Table(Name = "POJAZDY")]
    internal class Pojazdy_ORM
    {
        [PrimaryKey, Identity]
        [Column(Name = "ID_POJAZDU")]
        public int ID_POJAZDU { get; set; }

        [Column(Name = "ID_GATUNKU")]
        public int? ID_GATUNKU { get; set; }

        [Column(Name = "NR_REJ")]
        public string NR_REJ { get; set; }

        [Column(Name = "DOWOD_REJ")]
        public string DOWOD_REJ { get; set; }

        [Column(Name = "NR_EWID")]
        public string NR_EWID { get; set; }

        [Column(Name = "ID_MARKA")]
        public int? ID_MARKA { get; set; }

        [Column(Name = "TYP")]
        public string TYP { get; set; }

        [Column(Name = "ID_RODZAJ")]
        public int? ID_RODZAJ { get; set; }

        [Column(Name = "PRZEZNACZENIE")]
        public string PRZEZNACZENIE { get; set; }

        [Column(Name = "NR_PODW")]
        public string NR_PODW { get; set; }

        [Column(Name = "NR_SILNIKA")]
        public string NR_SILNIKA { get; set; }

        [Column(Name = "NR_NADWOZIA")]
        public string NR_NADWOZIA { get; set; }

        [Column(Name = "MASA_WL")]
        public int MASA_WL { get; set; }

        [Column(Name = "LADOWNOSC")]
        public int LADOWNOSC { get; set; }

        [Column(Name = "BARWA")]
        public string BARWA { get; set; }

        [Column(Name = "IL_MIEJSC")]
        public int IL_MIEJSC { get; set; }

        [Column(Name = "POJ_SILN")]
        public int POJ_SILN { get; set; }

        [Column(Name = "MOC_SILN")]
        public int MOC_SILN { get; set; }

        [Column(Name = "ROK_PROD")]
        public int ROK_PROD { get; set; }

        [Column(Name = "OGRZEWANIE")]
        public int OGRZEWANIE { get; set; }

        [Column(Name = "OPONY_PRZOD")]
        public string OPONY_PRZOD { get; set; }

        [Column(Name = "OPONY_TYL")]
        public string OPONY_TYL { get; set; }

        [Column(Name = "DEF_NACZEPA")]
        public int DEF_NACZEPA { get; set; }

        [Column(Name = "DEF_KIEROWCA")]
        public int DEF_KIEROWCA { get; set; }

        [Column(Name = "DEF_ZMIENNIK")]
        public int DEF_ZMIENNIK { get; set; }

        [Column(Name = "RODZAJ_PALIWA")]
        public string RODZAJ_PALIWA { get; set; }

        [Column(Name = "OPIS")]
        public string OPIS { get; set; }

        [Column(Name = "DEF_WYKONAWCA")]
        public int DEF_WYKONAWCA { get; set; }

        [Column(Name = "OLEJ2_DATA")]
        public DateTime OLEJ2_DATA { get; set; }

        [Column(Name = "OLEJ1_DATA")]
        public DateTime OLEJ1_DATA { get; set; }

        [Column(Name = "FILTR1_ID")] // IDwaluty UWAGA *->
        public int? FILTR1_ID { get; set; }

        [Column(Name = "FILTR1_WYMIENIONY")] 
        public int FILTR1_WYMIENIONY { get; set; }

        [Column(Name = "FILTR1_DATA")]
        public DateTime FILTR1_DATA { get; set; }

        [Column(Name = "FILTR1_NAZWA")] // karta 
        public string FILTR1_NAZWA { get; set; }

        [Column(Name = "FILTR1_OPIS")] //telematyka
        public string FILTR1_OPIS { get; set; }

        [Column(Name = "FILTR2_ID")] // ID dział  UWAGA *->
        public int? FILTR2_ID { get; set; } = 0;

        [Column(Name = "FILTR2_WYMIENIONY")]
        public int FILTR2_WYMIENIONY { get; set; }

        [Column(Name = "FILTR2_DATA")]
        public DateTime FILTR2_DATA { get; set; } 

        [Column(Name = "FILTR2_NAZWA")]
        public string FILTR2_NAZWA { get; set; }

        [Column(Name = "FILTR2_OPIS")]
        public string FILTR2_OPIS { get; set; }

        [Column(Name = "FILTR3_ID")]  // 
        public int FILTR3_ID { get; set; } = 0;

        [Column(Name = "KRAJ"),Nullable]  // typ truck dla buriana filtr_przych powiązanie !!! // w starym czy jeździ kraj zagraniaca
        public int? KRAJ { get; set; }
        [Column(Name = "FILTR3_NAZWA")]
        public string FILTR3_NAZWA { get; set; }

        [Column(Name = "FILTR3_OPIS")]
        public string FILTR3_OPIS { get; set; }

        [Column(Name = "W_TRASIE")]
        public int W_TRASIE { get; set; }

        [Column(Name = "POLOZENIE")]
        public string POLOZENIE { get; set; }

        [Column(Name = "IDMIASTA")]
        public int IDMIASTA { get; set; }

        [Column(Name = "REALIZACJA")]
        public DateTime REALIZACJA { get; set; }

        [Column(Name = "NORMY")]
        public string NORMY { get; set; }

        [Column(Name = "NORMY_Z")]
        public string NORMY_Z { get; set; }

        [Column(Name = "NORMA_AGREGATU2")]
        public double NORMA_AGREGATU2 { get; set; }

        [Column(Name = "NORMA_Z_PALIWA")]
        public double NORMA_Z_PALIWA { get; set; }

        [Column(Name = "NORMA_Z_AGREGATU")]
        public double NORMA_Z_AGREGATU { get; set; }

        [Column(Name = "NORMA_Z_OGRZEWANIA")]
        public double NORMA_Z_OGRZEWANIA { get; set; }

        [Column(Name = "NORMA_Z_AGREGATU2")]
        public double NORMA_Z_AGREGATU2 { get; set; }

        [Column(Name = "NORMA_PALIWA")]
        public double NORMA_PALIWA { get; set; }

        [Column(Name = "NORMA_AGREGATU")]
        public double NORMA_AGREGATU { get; set; }

        [Column(Name = "NORMA_OGRZEWANIA")]
        public double NORMA_OGRZEWANIA { get; set; }

        [Column(Name = "PRZEJECHANE")]
        public int PRZEJECHANE { get; set; }

        [Column(Name = "NIEAKTYWNY")]
        public int NIEAKTYWNY { get; set; }

        [Column(Name = "STAN_PALIWA_AGREGAT_I")] // rata leasingowa
        public double STAN_PALIWA_AGREGAT_I { get; set; }

        [Column(Name = "KONTO1")] 
        public string KONTO1 { get; set; }
        [Column(Name = "KONTO2")]
        public string KONTO2 { get; set; }
        [Column(Name = "KONTO3")]
        public string KONTO3 { get; set; }


    }
}
