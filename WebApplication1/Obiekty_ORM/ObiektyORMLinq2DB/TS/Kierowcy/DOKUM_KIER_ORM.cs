using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.ObiektyORMLinq2DB.TS.Kierowcy
{
    [Table(Name = "DOKUM_KIER")] // Tabela w bazie danych 
    internal class DOKUM_KIER_ORM
    {
        [PrimaryKey, Identity] // Klucz główny z autoincrementem
        [Column(Name = "ID_DOKUM_KIER")]
        public int ID_DOKUM_KIER { get; set; }
        [Column(Name = "ID_DOKUM")]
        public int ID_DOKUM { get; set; }
        [Column(Name = "AKTYWNY")]
        public int AKTYWNY { get; set; }
        [Column(Name = "ID_KIEROWCA")]
        public int ID_KIEROWCA { get; set; }
        [Column(Name = "UWAGI")]
        public string UWAGI { get; set; }
        [Column(Name = "WAZNY_DO")]
        public DateTime WAZNY_DO { get; set; }
        [Column(Name = "WYDANY")]
        public DateTime WYDANY { get; set; }
        [Column(Name = "SERIA")]
        public string SERIA { get; set; }
        [Column(Name = "DATA_OTRZYMANIA"), Nullable]
        public DateTime DATA_OTRZYMANIA { get; set; }
        [Column(Name = "OPERATOR")]
        public string OPERATOR { get; set; }
        [Column(Name = "NAZWA_TARYFY"), Nullable]
        public string NAZWA_TARYFY { get; set; }
        [Column(Name = "ABONAMENT"), Nullable]
        public double ABONAMENT { get; set; }
        [Column(Name = "ABONAMENT_DODATKOWY"), Nullable]
        public double ABONAMENT_DODATKOWY { get; set; }
        [Column(Name = "MODEL"), Nullable]
        public string MODEL { get; set; }
        [Column(Name = "IMEI"), Nullable]
        public string IMEI { get; set; }
        [Column(Name = "PIN"), Nullable]
        public string PIN { get; set; }
        [Column(Name = "HASLO"), Nullable]
        public string HASLO { get; set; }
    }
}
