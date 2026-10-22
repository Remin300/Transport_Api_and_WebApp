using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.ObiektyORMLinq2DB.TS.Zlecenia
{
    [Table(Name = "VZLECENIA_SPED_TRASY")] // Tabela w bazie danych 
    internal class VZLECENIA_SPED_TRASY_ORM
    {        
        [PrimaryKey, Identity] // Klucz główny z autoincrementem
        [Column(Name = "ID_ZLECENIA_SPED")]
        public int ID_ZLECENIA_SPED { get; set; }

        [Column(Name = "ID_ZLECENIODAWCY")]
        public int ID_ZLECENIODAWCY { get; set; }
        [Column(Name = "ID_ZLECENIODAWCY")]
        public int ID_FAKTURY { get; set; }
        [Column(Name = "IMP_EXP_KRAJ")]
        public int IMP_EXP_KRAJ { get; set; }
        [Column(Name = "NR_KOLEJNY")]
        public int NR_KOLEJNY { get; set; }

        [Column(Name = "OCZEKUJACE")]
        public int OCZEKUJACE { get; set; }

        [Column(Name = "JAZDA")]
        public int JAZDA { get; set; }

        [Column(Name = "ID_WYKONAWCY")]
        public int ID_WYKONAWCY { get; set; }
       [Column(Name = "IDKARTY")]
        public int IDKARTY { get; set; }
        [Column(Name = "KOLKO")]
        public int KOLKO { get; set; }        
        [Column(Name = "IDFILTR1")]
        public int IDFILTR1 { get; set; }
        [Column(Name = "FILTR1")]
        public int FILTR1 { get; set; }
        [Column(Name = "ID_TABELI_SW")]
        public int ID_TABELI_SW { get; set; }
        [Column(Name = "ID_KIEROWCA")]
        public int ID_KIEROWCA { get; set; }
        [Column(Name = "ID_POJAZD")]
        public int ID_POJAZD { get; set; }        
        [Column(Name = "ID_WALUTY_PS")]
        public int ID_WALUTY_PS { get; set; }
        [Column(Name = "FILTR2")]
        public int FILTR2 { get; set; }
        [Column(Name = "ID_USER")]
        public int ID_USER { get; set; }
        [Column(Name = "IDKARTY1")]
        public int IDKARTY1 { get; set; }
        [Column(Name = "ZAP_WLASNA")]
        public int ZAP_WLASNA { get; set; }
        [Column(Name = "ZAP_OBCA")]
        public int ZAP_OBCA { get; set; }
        [Column(Name = "ZBIOROWKA")]
        public int ZBIOROWKA { get; set; }
        [Column(Name = "ID_WALUTY_SW")]
        public int ID_WALUTY_SW { get; set; }
        [Column(Name = "DATA_ZLECENIA")]
        public DateTime? DATA_ZLECENIA { get; set; }
        [Column(Name = "OBCA_DATA")]
        public DateTime? OBCA_DATA { get; set; }
        [Column(Name = "OBCA_DATA_ZAPLATY")]
        public DateTime? OBCA_DATA_ZAPLATY { get; set; }
        [Column(Name = "DATA_ZALADUNKU")]
        public DateTime? DATA_ZALADUNKU { get; set; }
        [Column(Name = "DATA_ROZLADUNKU")]
        public DateTime? DATA_OTRZYMANIA { get; set; } 
        [Column(Name = "FAK_DATA_WYS")]
        public DateTime? FAK_DATA_WYS { get; set; }
        [Column(Name = "FAK_DATA_SPRZ")]
        public DateTime? FAK_DATA_SPRZ { get; set; }
        [Column(Name = "NUMER_PELNY"), Nullable]
        public string NUMER_PELNY { get; set; }
        [Column(Name = "NAZWAZLECENIODAWCY"), Nullable]
        public string NAZWAZLECENIODAWCY { get; set; }
        [Column(Name = "REJPOJAZDU"), Nullable]
        public string REJPOJAZDU { get; set; }
        [Column(Name = "NUMER_FAKTURY"), Nullable]
        public string NUMER_FAKTURY { get; set; }
        [Column(Name = "NAZWAWYKONAWCY"), Nullable]
        public string NAZWAWYKONAWCY { get; set; }
        [Column(Name = "REJ_NACZEPY_OBCEJ"), Nullable]
        public string REJ_NACZEPY_OBCEJ { get; set; }
        [Column(Name = "PRZELADUNEK"), Nullable]
        public string PRZELADUNEK { get; set; }
        [Column(Name = "NR_FAKTURY_OBCEJ"), Nullable]
        public string NR_FAKTURY_OBCEJ { get; set; }
        [Column(Name = "KIEROWCA"), Nullable]
        public string KIEROWCA { get; set; }
        [Column(Name = "OPERATOR"), Nullable]
        public string OPERATOR { get; set; }
        [Column(Name = "ZMIENNIK"), Nullable]
        public string ZMIENNIK { get; set; }
        [Column(Name = "WALUTA"), Nullable]
        public string WALUTA { get; set; }
        [Column(Name = "KRAJ"), Nullable]
        public string KRAJ { get; set; }
        [Column(Name = "KRAJ1"), Nullable]
        public string KRAJ1 { get; set; }
        [Column(Name = "NRKOREKTY"), Nullable]
        public string NRKOREKTY { get; set; }
        [Column(Name = "TRASA_OD"), Nullable]
        public string TRASA_OD { get; set; }
        [Column(Name = "TRASA_DO"), Nullable]
        public string TRASA_DO { get; set; }
        [Column(Name = "ZMIENNIK_OBCY"), Nullable]
        public string ZMIENNIK_OBCY { get; set; }
        [Column(Name = "oddzial"), Nullable]
        public string oddzial { get; set; }   
        [Column(Name = "WARUNKI_DODKOWE_CDY"), Nullable]
        public string WARUNKI_DODKOWE_CD { get; set; }
        [Column(Name = "STAWKA_WLASNA")]
        public double STAWKA_WLASNA { get; set; }
        [Column(Name = "PRZEWOZNIK_STAWKA")]
        public double PRZEWOZNIK_STAWKA { get; set; }
        [Column(Name = "OBCA_BRUTTO")]
        public double OBCA_BRUTTO { get; set; }
        [Column(Name = "OBCA_ZAPLATA")]
        public double OBCA_ZAPLATA { get; set; }
        [Column(Name = "RABAT")]
        public double RABAT { get; set; }
        [Column(Name = "KWOTA_PO_RABACIE")]
        public double KWOTA_PO_RABACIE { get; set; }
        [Column(Name = "KWOTA_PLN")]
        public double KWOTA_PLN { get; set; }
        [Column(Name = "KWOTA_WAL")]
        public double KWOTA_WAL { get; set; }
        [Column(Name = "PRZEWOZNIK_NETTO")]
        public double PRZEWOZNIK_NETTO { get; set; }
        [Column(Name = "KOSZTY_DODATKOWE")]
        public double KOSZTY_DODATKOWE { get; set; }
        [Column(Name = "KOREKTA")]
        public double KOREKTA { get; set; }
        [Column(Name = "KOSZT_DODATKOWY")]
        public double KOSZT_DODATKOWY { get; set; }
    }


}
