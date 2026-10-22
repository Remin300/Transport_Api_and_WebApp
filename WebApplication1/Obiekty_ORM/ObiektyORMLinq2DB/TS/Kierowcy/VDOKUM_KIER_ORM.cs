using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.ObiektyORMLinq2DB.TS.Kierowcy
{
    [Table(Name = "VDOKUM_KIER")] // Tabela w bazie danych 
    internal class VDOKUM_KIER_ORM
    {
        [PrimaryKey, Identity] // Klucz główny z autoincrementem
        [Column(Name = "ID_KIEROWCA")]
        public int ID_KIEROWCA { get; set; }
        [Column(Name = "NAZWISKO"), Nullable]
        public string NAZWISKO { get; set; }
        [Column(Name = "IMIE"), Nullable]
        public string IMIE { get; set; }
        [Column(Name = "OBYWATELSTWO"), Nullable]
        public string OBYWATELSTWO { get; set; }
        [Column(Name = "IDBUS"), Nullable]
        public int IDBUS { get; set; }
        [Column(Name = "PRAWO_J"), Nullable]
        public string PRAWO_J { get; set; }
        [Column(Name = "PRAWO_JDATA"), Nullable]
        public DateTime PRAWO_JDATA { get; set; }
        [Column(Name = "DOWOD"), Nullable]
        public string DOWOD { get; set; }
        [Column(Name = "DOWOD_DATA"), Nullable]
        public DateTime DOWOD_DATA { get; set; }
        [Column(Name = "PASZPORT"), Nullable]
        public string PASZPORT { get; set; }
        [Column(Name = "PASZPORT_DATA"), Nullable]
        public DateTime PASZPORT_DATA { get; set; }
        [Column(Name = "BADANIA"), Nullable]
        public DateTime BADANIA { get; set; }
        [Column(Name = "SWIADECTWO"), Nullable]
        public DateTime SWIADECTWO { get; set; }
        [Column(Name = "SWIADECTWO_TEKST"), Nullable]
        public string SWIADECTWO_TEKST { get; set; }
        [Column(Name = "ADR"), Nullable]
        public DateTime ADR { get; set; }
        [Column(Name = "KARTA"), Nullable]
        public string KARTA { get; set; }
        [Column(Name = "KARTA_DATA"), Nullable]
        public DateTime KARTA_DATA { get; set; }
        [Column(Name = "LEKARSKIE"), Nullable]
        public DateTime LEKARSKIE { get; set; }
        [Column(Name = "NFZ"), Nullable]
        public DateTime NFZ { get; set; }
        [Column(Name = "ING"), Nullable]
        public string ING { get; set; }
        [Column(Name = "ING_DATA"), Nullable]
        public DateTime ING_DATA { get; set; }
        [Column(Name = "TEL"), Nullable]
        public string TEL { get; set; }
        [Column(Name = "TEL_DATA"), Nullable]
        public DateTime TEL_DATA { get; set; }

        [Column(Name = "TEL1"), Nullable]
        public string TEL1 { get; set; }

        [Column(Name = "TEL1_DATA"), Nullable]
        public DateTime TEL1_DATA { get; set; }
    
       [Column(Name = "PRAWO_JBEFOR"), Nullable]
        public DateTime PRAWO_JBEFOR { get; set; }
       [Column(Name = "DOWOD_BEFOR"), Nullable]
        public DateTime DOWOD_BEFOR { get; set; }
       [Column(Name = "PASZPORT_BEFOR"), Nullable]
        public DateTime PASZPORT_BEFOR { get; set; }
       [Column(Name = "KARTA_BEFOR"), Nullable]
        public DateTime KARTA_BEFOR { get; set; }
       [Column(Name = "ING_BEFOR"), Nullable]
        public DateTime ING_BEFOR { get; set; }
        [Column(Name = "TEL_BEFOR"), Nullable]
        public DateTime TEL_BEFOR { get; set; }
        [Column(Name = "TEL1_BEFOR"), Nullable]
        public DateTime TEL1_BEFOR { get; set; }
        [Column(Name = "GRUPA"), Nullable]
        public int GRUPA { get; set; }
        [Column(Name = "URZAD"), Nullable]
        public int URZAD { get; set; }

        [Column(Name = "DATA_UMOWA"), Nullable]
        public DateTime DATA_UMOWA { get; set; }      
        
        [Column(Name = "DATA_ZW"), Nullable]
        public DateTime DATA_ZW { get; set; }

        [Column(Name = "UMOWA"), Nullable]
        public string UMOWA { get; set; }  

        [Column(Name = "A1_DATA"), Nullable]
        public DateTime A1_DATA { get; set; }
        [Column(Name = "A1_UWAGI"), Nullable]
        public string A1_UWAGI { get; set; }
        [Column(Name = "AU_DATA"), Nullable]
        public DateTime AU_DATA { get; set; }        
        [Column(Name = "DE_DATA"), Nullable]
        public DateTime DE_DATA { get; set; }
        [Column(Name = "FR_DATA"), Nullable]
        public DateTime FR_DATA { get; set; }        
        [Column(Name = "IT_DATA"), Nullable]
        public DateTime IT_DATA { get; set; }
        [Column(Name = "BHP_DATA"), Nullable]
        public DateTime BHP_DATA { get; set; }
        [Column(Name = "CE_DATA"), Nullable]
        public DateTime CE_DATA { get; set; }
        [Column(Name = "CE_TEKST"), Nullable]
        public string CE_TEKST { get; set; }
        [Column(Name = "SW_DATADO"), Nullable]
        public DateTime SW_DATADO { get; set; }
        [Column(Name = "SW_DATAOD"), Nullable]
        public DateTime SW_DATAOD { get; set; }
        [Column(Name = "SW_UWAGI"), Nullable]
        public string SW_UWAGI { get; set; }
        [Column(Name = "A_DATA"), Nullable]
        public DateTime A_DATA { get; set; }
        [Column(Name = "WIZA_DATA"), Nullable]
        public DateTime WIZA_DATA { get; set; }
        [Column(Name = "KARTAP_DATA"), Nullable]
        public DateTime KARTAP_DATA { get; set; }
        [Column(Name = "TERMIN"), Nullable]
        public DateTime TERMIN { get; set; }
        [Column(Name = "TELEFON"), Nullable]
        public string TELEFON { get; set; }

        [Column(Name = "TEL_DOM"), Nullable]
        public string TEL_DOM { get; set; }
        [Column(Name = "UWAGI"), Nullable]
        public string UWAGI { get; set; }

        [Column(Name = "UWAGI1"), Nullable]
        public string UWAGI1 { get; set; }
        [Column(Name = "POJAZD"), Nullable]
        public string POJAZD { get; set; }

        [Column(Name = "TE_AU"), Nullable]
        public int TE_AU { get; set; }

        [Column(Name = "TE_CS"), Nullable]
        public int TE_CS { get; set; }

        [Column(Name = "TE_FR"), Nullable]
        public int TE_FR { get; set; }

        [Column(Name = "TE_DE"), Nullable]
        public int TE_DE { get; set; }

        [Column(Name = "TE_IT"), Nullable]
        public int TE_IT { get; set; }
        [Column(Name = "DZIAL"), Nullable]
        public int DZIAL { get; set; }
        [Column(Name = "NIEAKTYWNY"), Nullable]
        public int NIEAKTYWNY { get; set; }
        [Column(Name = "STANOWISKO"), Nullable]
        public string STANOWISKO { get; set; }

    }
}
