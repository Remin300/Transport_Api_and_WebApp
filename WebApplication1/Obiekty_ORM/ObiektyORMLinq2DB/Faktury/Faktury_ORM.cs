using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.Faktury
{
    // Oznaczenie klasy jako mapowanie tabeli w bazie danych
    //public int MK { get; set; }  //samoFakturowanie
    [Table(Name = "FAKTURY")]
    public class Faktury_ORM
    {
        [PrimaryKey, Identity]
        [Column("ID_FAKTURY")]
        public int ID_FAKTURY { get; set; }

        [Column("NR_KOLEJNY")]
        public int NR_KOLEJNY { get; set; }

        [Column("NUMER_PELNY")]
        public string NUMER_PELNY { get; set; }

        [Column("ID_RODZAJ_DOK")]
        public int ID_RODZAJ_DOK { get; set; }   //   klucz obcy do tabeli "DOKUMENTY"

        [Column("GATUNEK_DOK_NADRZ")]
        public int GATUNEK_DOK_NADRZ { get; set; }

        [Column("ID_KONTRAHENTA")]
        public int ID_KONTRAHENTA { get; set; }

        [Column("DATA_WYSTAWIENIA")]
        public DateTime? DATA_WYSTAWIENIA { get; set; }

        [Column("DATA_SPRZEDAZY")]
        public DateTime? DATA_SPRZEDAZY { get; set; }

        [Column("ID_RODZ_PLATNOSCI")]
        public int ID_RODZ_PLATNOSCI { get; set; }

        [Column("ILOSC_DNI_PLATN")]
        public int ILOSC_DNI_PLATN { get; set; }

        [Column("UWAGI")]
        public string UWAGI { get; set; }

        [Column("ID_STALY_TEKST")]
        public int ID_STALY_TEKST { get; set; }

        [Column("ID_WYSTAWIL")]
        public int ID_WYSTAWIL { get; set; }

        [Column("ODEBRAL")]
        public string ODEBRAL { get; set; }

        [Column("LINK_FAKTURA")]
        public int LINK_FAKTURA { get; set; }

        [Column("ZATWIERDZONY")]
        public int ZATWIERDZONY { get; set; }

        [Column("KONTO_BANKOWE")]
        public int KONTO_BANKOWE { get; set; }

        [Column("KONTO_BANKOWE1")]
        public int KONTO_BANKOWE1 { get; set; }

        [Column("ZAPLACONA")]
        public int ZAPLACONA { get; set; } //  2 - zaplacona ;  0 - niezaplacona

        [Column("ZAPLACONA_DNIA")]
        public DateTime? ZAPLACONA_DNIA { get; set; }    // UWAGA to data która jest TERMINEM PŁATNOŚCI

        [Column("MASKA")]
        public string MASKA { get; set; }

        [Column("NUMER_ROZSZERZONY")]
        public string NUMER_ROZSZERZONY { get; set; }

        [Column("ID_DOKUMENTU")]
        public int ID_DOKUMENTU { get; set; }

        [Column("DATA_ZAPLATY")]
        public DateTime? DATA_ZAPLATY { get; set; }  // UWAGA to data która jest datą w której na konto wpłynęły środki

        [Column("WYCIAG")]
        public string WYCIAG { get; set; }

        [Column("OPIS_POZYCJI")]
        public string OPIS_POZYCJI { get; set; }

        [Column("KWOTA_ZAPLACONA")]
        public double KWOTA_ZAPLACONA { get; set; }

        [Column("EURONIP_S")]
        public string EURONIP_S { get; set; }

        [Column("EURONIP_K")]
        public string EURONIP_K { get; set; }

        [Column("DATA_WPROWADZENIA")]
        public DateTime? DATA_WPROWADZENIA { get; set; }

        [Column("IDMAGAZYN")]
        public int IDMAGAZYN { get; set; }

        [Column("IDKASA_KP")]
        public int IDKASA_KP { get; set; }   //  0 - pln;   1 - walutowe ; 2 - waluta VAT w PLN  ;  3 - dwuwalutowe

        [Column("PLATNIK")]
        public int? PLATNIK { get; set; }     // dodatkowy odbiorca ( dodatkowe pole)  // //==> UWAGA ODBIORCA NA FAKTURZE 

        [Column("ID_REJESTR")]
        public int ID_REJESTR { get; set; }

        [Column("ZAPLATA_EUR")]
        public double ZAPLATA_EUR { get; set; }

        [Column("IDTABELA")]
        public int? IDTABELA { get; set; }

        [Column("IDWALUTA")]
        public int IDWALUTA { get; set; }

        [Column("NETTO_WALUTA")]
        public double NETTO_WALUTA { get; set; }   // wartość netto w WAluCIE

        [Column("WARTOSC_WALUTA")]
        public double WARTOSC_WALUTA { get; set; }   // wartość brutto w WALUCIE

        [Column("WARTOSC_NETTO")]
        public double WARTOSC_NETTO { get; set; }   // wartość netto w PLN

        [Column("WARTOSC_BRUTTO")]
        public double WARTOSC_BRUTTO { get; set; }  // wartość brutto w PLN

        [Column("PRZESLANA")]
        public int PRZESLANA = 0;

        [Column("PRZESLANA_DATA")]
        public DateTime? PRZESLANA_DATA { get; set; }

        [Column("PRZESLANA_ID")]
        public int PRZESLANA_ID = 0;

        [Column("TRANSAKCJE")]
        public int TRANSAKCJE = 0;

        [Column("ID_ZLECENIA")]
        public int ID_ZLECENIA { get; set; }

        [Column("ID_KONTRAKTU")]
        public int ID_KONTRAKTU { get; set; }  // uwaga ID_KONTRAKTU to klucz obcy do tabeli TOWARY

        [Column("IDPRZESYLEK")]
        public string IDPRZESYLEK { get; set; }

        [Column("TOWAR")]
        public string TOWAR { get; set; }

        [Column("WYSLANA_DO_KSEF")]
        public int WYSLANA_DO_KSEF { get; set; } = 0;

        [Column("VATWPLN")]
        public int VATWPLN { get; set; }

        [Column("DZIALY")]
        public int DZIALY { get; set; }
        [Column("ROK")]
        public int ROK { get; set; }

        [Column("MC")]
        public int MC { get; set; }

        [Column("TP")]  //  ===> GTU
        public int TP { get; set; }
        [Column("FISKALIZOWANY")]
        public DateTime? FISKALIZOWANY { get; set; }  //DATA ZATWIERDZENIA ZAMKNIECIA FAKTURY

        [Column("FISKALIZOWAL")]
        public int FISKALIZOWAL { get; set; }  //osoba zamykająca fakturę

        [Column("DATA_OPERACJI")]
        public DateTime? DATA_OPERACJI { get; set; }  //DATA ZATWIERDZENIA ZAMKNIECIA FAKTURY

        [Column("CZAS")]
        public DateTime? CZAS { get; set; }  //DATA ZATWIERDZENIA ZAMKNIECIA FAKTURY
        [Column("MK")]
        public int MK { get; set; }  //samoFakturowanie

        [Column("KURS")]
        public double KURS { get; set; }
        [Column("UWAGI2")]
        public string UWAGI2 { get; set; } // dodatkowy tekst na fakturze
        [Column("PRZESLANA_XML")]
        public int PRZESLANA_XML { get; set; }  //miesiac wystawienie w KUS NIEUZYWAC od nowego roku

        [Column("TT_D")]  // KURS WALUTY NA FAKTURZE
        public int TT_D { get; set; } // dodatkowy tekst na fakturze
        [Column("UWAGI3")]  // opis płatności
        public string UWAGI3 { get; set; }

        [Column("PATH_XML")]  // opis płatności
        public string PATH_XML { get; set; }

        [Column("VAT_ZA")]  // kwota zapłaty vat
        public double VAT_ZA { get; set; }
        [Column("ZAPLATA_VAT")]  // data zapłaty vat
        public DateTime? ZAPLATA_VAT { get; set; }

        [Column("KSEF_NUMER")]  // opis płatności
        public string KSEF_NUMER { get; set; }
        [Column("KSEF_DATA")]  // opis płatności
        public DateTime? KSEF_DATA { get; set; }
        [Column("I_42")]  //FAKTURA W FAKTORINGU
        public int I_42 { get; set; } // dodatkowy tekst na fakturze
        [Column("LISTPOJ")]  //FAKTURA W FAKTORINGU
        public int LISTPOJ { get; set; }
        [Column("IMP")]  // Pojedyńcza pozycja ==0
        public int IMP { get; set; }
        [Column("I_63")]  // Pojedyńcza pozycja ==0
        public int? I_63 { get; set; }


    }
}
