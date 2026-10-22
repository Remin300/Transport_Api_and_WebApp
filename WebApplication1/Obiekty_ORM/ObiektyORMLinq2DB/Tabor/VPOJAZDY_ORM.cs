using LinqToDB.Mapping;


namespace WebApplication1.ObiektyORMLinq2DB.Tabor
{
    [Table(Name = "VPOJAZDY")]
    internal class VPOJAZDY_ORM
    {
        [Column(Name = "ID_POJAZDU")]
        public int ID_POJAZDU { get; set; }
        [Column(Name = "ID_GATUNKU")]
        public int ID_GATUNKU { get; set; }
        [Column(Name = "RODZAJ_PALIWA")]
        public string RODZAJ_PALIWA { get; set; }
        [Column(Name = "NORMA_PALIWA")]
        public double NORMA_PALIWA { get; set; }
        [Column(Name = "NORMA_Z_PALIWA")]
        public double NORMA_Z_PALIWA { get; set; }
        [Column(Name = "BARWA")]
        public string BARWA { get; set; }
        [Column(Name = "POJ_SILN")]
        public int POJ_SILN { get; set; }
        [Column(Name = "OPIS")]
        public string OPIS { get; set; }
        [Column(Name = "GATUNEK")]
        public string GATUNEK { get; set; }
        [Column(Name = "NR_REJ")]
        public string NR_REJ { get; set; }
        [Column(Name = "NR_EWID")]
        public string NR_EWID { get; set; }
        [Column(Name = "ID_MARKA")]
        public int ID_MARKA { get; set; }
        [Column(Name = "MARKA")]
        public string MARKA { get; set; }        
        [Column(Name = "TYP")]
        public string TYP { get; set; }
        [Column(Name = "LADOWNOSC")]
        public int LADOWNOSC { get; set; }
        [Column(Name = "DEF_NACZEPA")]
        public int DEF_NACZEPA { get; set; }
        [Column(Name = "REJ_NACZEPY")]
        public string REJ_NACZEPY { get; set; }
        [Column(Name = "DEF_KIEROWCA")]
        public int DEF_KIEROWCA { get; set; }
        [Column(Name = "KIEROWCA")]
        public string KIEROWCA { get; set; }
        [Column(Name = "DEF_WYKONAWCA")]
        public int DEF_WYKONAWCA { get; set; }
        [Column(Name = "WYKONAWCA")]
        public string WYKONAWCA { get; set; }
        [Column(Name = "KRAJ")]
        public int KRAJ { get; set; }
        [Column(Name = "NIEAKTYWNY")]
        public int NIEAKTYWNY { get; set; }
        [Column(Name = "DOWOD_REJ")]
        public string DOWOD_REJ { get; set; }
        [Column(Name = "OC")]
        public DateTime? OC { get; set; }
        [Column(Name = "AC")]
        public DateTime? AC { get; set; }
        [Column(Name = "PT")]
        public DateTime? PT { get; set; }
        [Column(Name = "LT")]
        public DateTime? LT { get; set; }

        [Column(Name = "LICENCJA")]
        public DateTime? LICENCJA { get; set; }

        [Column(Name = "LICENCJA_NUMER")]
        public string LICENCJA_NUMER { get; set; }
        [Column(Name = "LICZNIK")]
        public int LICZNIK { get; set; }
        [Column(Name = "SPEDYTOR")]
        public string SPEDYTOR { get; set; }
        [Column(Name = "FILTR2_ID")]
        public int FILTR2_ID { get; set; }        

        [Column(Name = "DZIAL")]
        public string DZIAL { get; set; }

        [Column(Name = "ID_RODZAJ")]
        public int ID_RODZAJ { get; set; }
        [Column(Name = "RODZAJ")]
        public string RODZAJ { get; set; }
        [Column(Name = "ROK_PROD")]
        public int ROK_PROD { get; set; }
        [Column(Name = "VIN")]
        public string NR_NADWOZIA { get; set; }
        [Column(Name = "PRZEZNACZENIE")]
        public string PRZEZNACZENIE { get; set; } // NORMA euro
        [Column(Name = "FILTR1_DATA")] //DATA_ZAKUPU ?
        public DateTime? FILTR1_DATA { get; set; }

        [Column(Name = "FILTR2_DATA")] // wykup DATA_WYKUPU
        public DateTime? FILTR2_DATA { get; set; }

        [Column(Name = "FILTR3_DATA")] // sprzedazy
        public DateTime? FILTR3_DATA { get; set; }

        [Column(Name = "DATA_KASACJI")] // DATA KASACJI OLEJ1_DATA
        public DateTime? DATA_KASACJI { get; set; }

        [Column(Name = "DATA_ZAKUPU")] // DATA ZAKUPU OLEJ2_DATA
        public DateTime? DATA_ZAKUPU { get; set; }


        [Column(Name = "KONTO4")] // Nawigacja
        public string KONTO4 { get; set; }

        [Column(Name = "KONTO3")] //Telematyka
        public string KONTO3 { get; set; }

        [Column(Name = "KONTO2")] //Karta rozliczenia
        public string KONTO2 { get; set; }
        [Column(Name = "KONTO1")] //leasing
        public string KONTO1 { get; set; }
        [Column(Name = "BUS")] //filtr_przych
        public string BUS { get; set; }

        [Column(Name = "IL_MIEJSC")] 
        public int IL_MIEJSC { get; set; }

        


    }

}
