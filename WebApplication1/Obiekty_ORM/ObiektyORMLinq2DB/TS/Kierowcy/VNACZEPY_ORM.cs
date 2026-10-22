using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WebApplication1.ObiektyORMLinq2DB.TS.Kierowcy
{
    [Table(Name = "VNACZEPY")] // Tabela w bazie danych 
    internal class VNACZEPY_ORM
    {
        [PrimaryKey, Identity] // Klucz główny z autoincrementem
        [Column(Name = "ID_NACZEPY")]
        public int ID_NACZEPY { get; set; }
        [Column(Name = "ID_RODZAJ")]
        public int ID_RODZAJ { get; set; }
        [Column(Name = "NR_REJ")]
        public string NR_REJ { get; set; }
        [Column(Name = "MARKA")]
        public string MARKA { get; set; }
        [Column(Name = "TYP")]
        public string TYP { get; set; }
        [Column(Name = "RODZAJ")]
        public string RODZAJ { get; set; }
        [Column(Name = "ROK_PROD")]
        public int ROK_PROD { get; set; }
        [Column(Name = "DOWOD_REJ")]
        public string DOWOD_REJ { get; set; }
        [Column(Name = "IL_OSI")]
        public int IL_OSI { get; set; }
        [Column(Name = "LADOWNOSC")]
        public int LADOWNOSC { get; set; }
        [Column(Name = "KONTO2")]
        public string KONTO2 { get; set; }
        [Column(Name = "RATA")]
        public double RATA { get; set; }
        [Column(Name = "NR_EWID")]
        public string NR_EWID { get; set; }
        [Column(Name = "PT")]
        public DateTime PT { get; set; }
        [Column(Name = "AC")]
        public DateTime AC { get; set; }
        [Column(Name = "OC")]
        public DateTime OC { get; set; }
        [Column(Name = "DATA_ZAKUPU")]
        public DateTime DATA_ZAKUPU { get; set; }
        [Column(Name = "DATA_WYKUPU")]
        public DateTime DATA_WYKUPU { get; set; }
        [Column(Name = "DATA_SPRZEDAZY")]
        public DateTime DATA_SPRZEDAZY { get; set; }
        [Column(Name = "DATA_LIKWIDACJI")]
        public DateTime DATA_LIKWIDACJI { get; set; }
        [Column(Name = "KOMORA1")]
        public int KOMORA1 { get; set; }
        [Column(Name = "NIEAKTYWNY")]
        public int NIEAKTYWNY { get; set; }
    }
}
