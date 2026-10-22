using LinqToDB.Mapping;
using System.ComponentModel;

namespace WebApplication1.ObiektyORMLinq2DB
{

    //  IDFILTR_PRZYCH1 --> REJESTR DOWIĄZANY DO KONTRAHENTA !!
    //  nr_karty        --> samofakturowanie 1, 0 nie
    [Table(Name = "KONTRAHENCI")] // Tabela w bazie danych ma nazwę "KONTRAHENCI"
    public class Kontrahenci_ORM
    {
        [PrimaryKey, Identity] // Klucz główny z autoincrementem
        [Column(Name = "ID_KONTRAHENTA")]
        public int ID_KONTRAHENTA { get; set; }

        [Column(Name = "SKROT"), Nullable]
        public string SKROT { get; set; }

        [Column(Name = "NAZWA"), Nullable]
        public string NAZWA { get; set; }

        [Column(Name = "NIP"), Nullable]
        public string NIP { get; set; }

        [Column(Name = "ADRES"), Nullable]
        public string ADRES { get; set; }

        [Column(Name = "MIEJSCOWOSC"), Nullable]
        public string MIEJSCOWOSC { get; set; }

        [Column(Name = "WOJEWODZTWO"), Nullable]
        public string WOJEWODZTWO { get; set; }

        [Column(Name = "ID_KRAJU"), Nullable]
        public int? ID_KRAJU { get; set; }

        [Column(Name = "UWAGI"), Nullable]
        public string UWAGI { get; set; }

        [Column(Name = "ID_RODZ_PLATNOSCI"), Nullable]
        public int? ID_RODZ_PLATNOSCI { get; set; }

        [Column(Name = "PLATNOSC_DNI")]
        public int PLATNOSC_DNI { get; set; }

        [Column(Name = "AKTYWNY"), Nullable]
        public int? AKTYWNY { get; set; }   // 0 - nieaktywny ;   1 - aktywny

        [Column(Name = "KOD"), Nullable]
        public string KOD { get; set; }

        [Column(Name = "REGON"), Nullable]
        public string REGON { get; set; }

        [Column(Name = "NR_IDENT"), Nullable]
        public int? NR_IDENT { get; set; }

        [Column(Name = "KIERUNEK"), Nullable]
        public int? KIERUNEK { get; set; } // to jest ciąg cyfr łączący z tabelą CHARAKTER_KONTRAHENTA

        [Column(Name = "KONTRAHENT_CHARAKTER"), Nullable]
        public string? KONTRAHENT_CHARAKTER { get; set; } // pole KIERUNEK zamienione na VARCHAR

        [Column(Name = "ID_TEKSTU_STALEGO"), Nullable]
        public int? ID_TEKSTU_STALEGO { get; set; }


        // ------ Alerty dla ubepieczeń -------
        [Column(Name = "LIMIT_KREDYTOWY")]
        public double LIMIT_KREDYTOWY { get; set; }
        [Column(Name = "DATA_UB")]
        public DateTime? DATA_UB { get; set; }
        [Column(Name = "FIRMA_UB")]
        public string? FIRMA_UB { get; set; }
        [Column(Name = "KWOTA_UB")]
        public double? KWOTA_UB { get; set; }
        [Column(Name = "KWOTA_UB1")]
        public double? KWOTA_UB1 { get; set; }

        // ------- Alerty dla ubezpieczeń -------



        [Column(Name = "ID_WALUTY"), Nullable]
        public int? ID_WALUTY { get; set; }

        [Column(Name = "EURONIP_1"), Nullable]
        public string EURONIP_1 { get; set; }



        [Column(Name = "EURONIP_2"), Nullable]
        public string EURONIP_2 { get; set; }  // pole przechowujące nazweę dedykowanego XML przypisanego do kontrahenta



        [Column(Name = "DATA_KURSOW"), Nullable]
        public int? DATA_KURSOW { get; set; }

        [Column(Name = "IDKONTA"), Nullable, DefaultValue(0)]
        public int? IDKONTA = 0;

        [Column(Name = "TELEFON"), Nullable]
        public string TELEFON { get; set; }

        [Column(Name = "NIP_BK"), Nullable]
        public string NIP_BK { get; set; }

        [Column(Name = "NR_KARTY"), Nullable]
        public int? NR_KARTY { get; set; }

        [Column(Name = "STATUS"), Nullable]
        public int? STATUS { get; set; }

        [Column(Name = "OSOBA"), Nullable]
        public string OSOBA { get; set; }

        [Column(Name = "FAX"), Nullable]
        public string FAX { get; set; }

        [Column(Name = "WWW"), Nullable]
        public string WWW { get; set; }

        [Column(Name = "EMAIL"), Nullable]
        public string EMAIL { get; set; }

        [Column(Name = "DATA_WPISU")]
        public DateTime DATA_WPISU { get; set; }

        [Column(Name = "ID_OSOBA"), Nullable, DefaultValue(0)]
        public int? ID_OSOBA = 0;

        [Column(Name = "UWAGI1"), Nullable]
        public string UWAGI1 { get; set; }

        [Column(Name = "UWAGI2"), Nullable]
        public string UWAGI2 { get; set; }

        [Column(Name = "IDFILTR_PRZYCH1"), Nullable, DefaultValue(0)]
        public int? IDFILTR_PRZYCH1 = 0;

        [Column(Name = "POLE1"), Nullable]
        public string POLE1 { get; set; }

        [Column(Name = "POLE2"), Nullable]
        public string POLE2 { get; set; }

        [Column(Name = "POLE3"), Nullable]
        public string POLE3 { get; set; }
        [Column(Name = "KRD_UWAGI"), Nullable]
        public string KRD_UWAGI { get; set; }

        [Column(Name = "TRANSAKCJE"), Nullable, DefaultValue(0)]    // to jest klucz obcy do tabeli REJESTR  -  jeżeli kontrahent przypisany jest do konkretnego rejestru 
        public int? TRANSAKCJE { get; set; } = 0;

        [Column(Name = "ZAKUP"), Nullable, DefaultValue(0)]
        public int? ZAKUP { get; set; }

        [Column(Name = "SPRZEDAZ"), Nullable, DefaultValue(0)]
        public int? SPRZEDAZ { get; set; }

        [Column(Name = "KLIENT"), Nullable, DefaultValue(0)]
        public int? KLIENT { get; set; }

        [Column(Name = "WYKONAWCA"), Nullable, DefaultValue(0)]
        public int? WYKONAWCA { get; set; }

        [Column(Name = "WYKONAWCA_INNY"), Nullable, DefaultValue(0)]
        public int? WYKONAWCA_INNY { get; set; }

        [Column(Name = "ZAGRANICA"), Nullable, DefaultValue(0)]
        public int? ZAGRANICA { get; set; }

        [Column(Name = "ID_WALUTY1"), Nullable, DefaultValue(0)]
        public int? ID_WALUTY1 { get; set; }

        [Column(Name = "SAM"), Nullable, DefaultValue(0)]
        public int SAM { get; set; }

        [Column(Name = "KOLEJ"), Nullable, DefaultValue(0)] // tekst do płatności
        public int? KOLEJ { get; set; }

        [Column(Name = "PRZEW"), Nullable, DefaultValue(0)] // tekst do płatności
        public int? PRZEW { get; set; }


        [Column(Name = "ID_POZYSKUJACY"), Nullable, DefaultValue(0)] // id_przypisanego oddziału.
        public int? ID_POZYSKUJACY { get; set; }

        [Column(Name = "PLATNIK_NAZWISKO"), Nullable]
        public string PLATNIK_NAZWISKO { get; set; }

        [Column(Name = "PLATNIK_TEL"), Nullable]
        public string PLATNIK_TEL { get; set; }

    }
}
