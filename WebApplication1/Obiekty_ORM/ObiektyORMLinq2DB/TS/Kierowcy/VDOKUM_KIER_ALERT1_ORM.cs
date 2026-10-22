using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.ObiektyORMLinq2DB.TS.Kierowcy
{
    [Table(Name = "VDOKUM_KIER_ALERT1")] // Tabela w bazie danych 
    class VDOKUM_KIER_ALERT1_ORM
    {
        [PrimaryKey, Identity] // Klucz główny z autoincrementem
        [Column(Name = "ID_DOKUM")]
        public int ID_DOKUM { get; set; }
        [Column(Name = "ID_KIEROWCA"), Nullable]
        public int ID_KIEROWCA { get; set; }
        [Column(Name = "KIEROWCA"), Nullable]
        public string KIEROWCA { get; set; }
        [Column(Name = " DOKUMENT"), Nullable]
        public string DOKUMENT { get; set; }
        [Column(Name = "WAZNY_DO"), Nullable]
        public DateTime WAZNY_DO { get; set; }
        [Column(Name = "AKTYWNY"), Nullable]
        public int AKTYWNY { get; set; }
        [Column(Name = "SERIA"), Nullable]
        public string SERIA { get; set; }
        [Column(Name = "ALERTBEFORE"), Nullable]
        public DateTime ALERTBEFORE { get; set; }
        [Column(Name = "TELEFON"), Nullable]
        public DateTime TELEFON { get; set; }
        [Column(Name = "OPERATOR"), Nullable]
        public string OPERATOR { get; set; }
        [Column(Name = "ABONAMENT"), Nullable]
        public double ABONAMENT { get; set; }
        [Column(Name = "ABONAMENT_DODATKOWY"), Nullable]
        public double ABONAMENT_DODATKOWY { get; set; }
        [Column(Name = "NAZWA_TARYFY"), Nullable]
        public string NAZWA_TARYFY { get; set; }
        [Column(Name = "DATA_OTRZYMANIA"), Nullable]
        public DateTime DATA_OTRZYMANIA { get; set; }
        [Column(Name = "UWAGI"), Nullable]
        public string UWAGI { get; set; }
        [Column(Name = "MODEL"), Nullable]
        public string MODEL { get; set; }

        [Column(Name = "WYDANY"), Nullable]
        public string WYDANY { get; set; }        

        [Column(Name = "IMEI"), Nullable]
        public string IMEI { get; set; }        
        [Column(Name = "PIN"), Nullable]
        public string PIN { get; set; }
        [Column(Name = "HASLO"), Nullable]
        public string HASLO { get; set; }
        [Column(Name = "SERIA_LIST"), Nullable]
        public string SERIA_LIST { get; set; }
        [Column(Name = "PRAKTYKA"), Nullable]
        public string PRAKTYKA { get; set; }
        [Column(Name = "UWAGA_TARYFY"), Nullable]
        public string UWAGA_TARYFY { get; set; }
        [Column(Name = "IDBUS"), Nullable]
        public int IDBUS { get; set; }
        [Column(Name = "ID"), Nullable]
        public int ID { get; set; }
        [Column(Name = "CZY_TEL"), Nullable]
        public int CZY_TEL { get; set; }
    }
}
