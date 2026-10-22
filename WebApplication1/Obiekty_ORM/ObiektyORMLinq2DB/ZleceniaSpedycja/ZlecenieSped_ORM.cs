using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.ZleceniaSpedycja
{
    //                 ObrotyNetto  w walucie stawki wysumowane
    //                NettoFakturaObca  w walucie stawki wysumowane
    /*
     * 
    seStawkaEur.Value= ZlecenieSped.STAWKA_KRAJOWA_PS;
                    seKoszt.Value= ZlecenieSped.STAWKA_KRAJOWA_SW;
                    edKurs.Value= ZlecenieSped.ZYSK;
         ODPRAWA_CELNA_GRANICZNA := edDC.Text;
         ODPRAWA_CELNA_WYWOZOWA := EdOpisRos.Text;
//       UWAGI_DO_FAKTURY;

     */
    // ZlecenieSped.ZYSK kurs waluty 
    [Table(Name = "ZLECENIA_SPED")]
    public class ZlecenieSped_ORM
    {
        [PrimaryKey, Identity]
        [Column(Name = "ID_ZLECENIA_SPED")]
        public int IdZleceniaSped { get; set; }

        [Column(Name = "NR_KOLEJNY")]
        public int NrKolejny { get; set; }

        [Column(Name = "NUMER_PELNY")]
        public string NumerPelny { get; set; }

        [Column(Name = "ID_ZLECENIODAWCY")]
        public int? IdZleceniodawcy { get; set; }

        [Column(Name = "DATA_ZLECENIA")]
        public DateTime? DataZlecenia { get; set; }

        [Column(Name = "NR_FAKTURY_OBCEJ")]
        public string NR_FAKTURY_OBCEJ { get; set; }


        [Column(Name = "ID_FAKTURY")]
        public int? IdFaktury { get; set; }

        [Column(Name = "UWAGI_DO_FAKTURY")]
        public string UWAGI_DO_FAKTURY { get; set; }

        //[Column(Name = "DNI_PLAT_FAKTURY_WLASNEJ")]
        //public int? DniPlatFakturyWlasnej { get; set; }

        [Column(Name = "ID_WYKONAWCY")]
        public int? IdWykonawcy { get; set; }

        [Column(Name = "REJ_POJAZDU_OBCEGO")]
        public string RejPojazduObcego { get; set; }

        [Column(Name = "REJ_NACZEPY_OBCEJ")]
        public string RejNaczepyObcej { get; set; }

        [Column(Name = "KIEROWCA_OBCY")]
        public string KierowcaObcy { get; set; }

        [Column(Name = "ZMIENNIK_OBCY")]
        public string ZmiennikObcy { get; set; }

        [Column(Name = "WARUNKI_DODATKOWE")]
        public string WarunkiDodatkowe { get; set; }

        [Column(Name = "ODPRAWA_CELNA_WYWOZOWA")]
        public string ODPRAWA_CELNA_WYWOZOWA { get; set; }

        //        [Column(Name = "ODPRAWA_CELNA_PRZYWOZ")]
        //        public string OdprawaCelnaPrzywoz { get; set; }

        [Column(Name = "ODPRAWA_CELNA_GRANICZNA")]
        public string ODPRAWA_CELNA_GRANICZNA { get; set; }

        [Column(Name = "ID_USER")]
        public int? IdUser { get; set; }

        [Column(Name = "IMP_EXP_KRAJ")]
        public int ImpExpKraj { get; set; }

        [Column(Name = "ID_TEKSTU_STALEGO")]
        public int? IdTekstuStalego { get; set; }

        [Column(Name = "DATA_ZALADUNKU")]
        public DateTime? DataZaladunku { get; set; }

        [Column(Name = "DATA_ROZLADUNKU")]
        public DateTime? DataRozladunku { get; set; }

        [Column(Name = "GODZINA_ROZLADUNKU")]
        public string GodzinaRozladunku { get; set; }

        [Column(Name = "STAWKA_WLASNA"), Nullable]
        public double? StawkaWlasna { get; set; }

        [Column(Name = "STAWKA_WLASNA_NA_PLN"), Nullable]
        public double? STAWKA_WLASNA_NA_PLN { get; set; }

        [Column(Name = "ID_WALUTY_SW")]
        public int? IdWalutySw { get; set; }

        [Column(Name = "ID_TABELI_SW")]
        public int? IdTabeliSw { get; set; }

        [Column(Name = "STAWKA_KRAJOWA_SW"), Nullable]
        public double? STAWKA_KRAJOWA_SW { get; set; }

        [Column(Name = "ID_VAT_KRAJOWA_SW")]
        public int? ID_VAT_KRAJOWA_SW { get; set; }

        [Column(Name = "PRZEWOZNIK_STAWKA"), Nullable]
        public double? PrzewoznikStawka { get; set; }

        [Column(Name = "PRZEWOZNIK_STAWKA_NA_PLN"), Nullable]
        public double? PRZEWOZNIK_STAWKA_NA_PLN { get; set; }

        [Column(Name = "ID_WALUTY_PS")]
        public int? IdWalutyPs { get; set; }

        [Column(Name = "ID_TABELI_PS")]
        public int? IdTabeliPs { get; set; }

        [Column(Name = "STAWKA_KRAJOWA_PS"), Nullable]
        public double? STAWKA_KRAJOWA_PS { get; set; }

        [Column(Name = "ID_VAT_KRAJOWA_PS")]
        public int? IdVatKrajowaPs { get; set; }

        [Column(Name = "LINK_ZLECENIE")]
        public int LinkZlecenie { get; set; }

        [Column(Name = "GODZINA_ZALADUNKU")]
        public string GodzinaZaladunku { get; set; }

        [Column(Name = "ID_KATEGORIA")]
        public int? IdKategoria { get; set; }   // powiązanie z tabelą "ODDZIAŁY"

        [Column(Name = "PRZELADUNEK")]
        public string Przeladunek { get; set; }

        [Column(Name = "OCZEKUJACE")]
        public int? Oczekujace { get; set; }

        [Column(Name = "KILOMETRY")]
        public int? Kilometry { get; set; }

        [Column(Name = "ZYSK")] // // ZlecenieSped.ZYSK kurs waluty 
        public double? ZYSK { get; set; }

        [Column(Name = "ID_IMPORTER")]
        public int? IdImporter { get; set; }

        [Column(Name = "ID_EXPORTER")]
        public int? IdExporter { get; set; }

        [Column(Name = "DODATKOWY_OPIS_LADUNKU")]
        public string DodatkowyOpisLadunku { get; set; }

        [Column(Name = "NR_JAZDY")]
        public int? NR_JAZDY { get; set; }  // klucz oby do tabeli OSOBY_KONTAKTOWE  wykonawca

        [Column(Name = "IDKARTY")]
        public int IDKARTY { get; set; } // klucz oby do tabeli OSOBY_KONTAKTOWE   zleceniodawca

        [Column(Name = "IDKARTY1")] // jmiary
        public int IDKARTY1 { get; set; } //

        [Column(Name = "NR_KSIEGOWY")]
        public string NrKsiegowy { get; set; }


        [Column(Name = "EURONIP_1")]
        public string EURONIP_1 { get; set; }  // przechowuje Uwagi do Pojazdu

        [Column(Name = "RADIO_KOD")]
        public string RADIO_KOD { get; set; } // przechowuje Uwagi do Kierowcy

        [Column(Name = "DODATKOWY_OPIS_LADUNKU_CD")]
        public string DodatkowyOpisLadunkuCd { get; set; }

        [Column(Name = "WARUNKI_DODATKOWE_CD")]
        public string WarunkiDodatkoweCd { get; set; }

        [Column(Name = "ZBIOROWKA")]
        public int? Zbiorowka { get; set; }

        [Column(Name = "DEF_WYKONAWCA")]
        public int? DEF_WYKONAWCA { get; set; }

        [Column(Name = "TRASA_OD")]
        public string TrasaOd { get; set; }

        [Column(Name = "TRASA_DO")]
        public string TrasaDo { get; set; }

        [Column(Name = "ID_VAT_SW")]
        public int? IdVatSw { get; set; } = 0;

        [Column(Name = "ID_VAT_PS")]
        public int? IdVatPs { get; set; } = 0;

        [Column(Name = "FINALIZED")]
        public int? Finalized { get; set; } = 0;   // 0 - otwarte;  1 - w trakcie fakturowania;  2 - zafakturowane;  3 - do wyjasnienia;   4 - zamkniete

        [Column(Name = "KRAJ_NAD")]
        public int KrajNad { get; set; }

        [Column(Name = "KRAJ_ODB")]
        public int KrajOdb { get; set; }

        [Column(Name = "POWOD_USUNIECIA")]
        public string PowodUsuniecia { get; set; }

        [Column(Name = "OBROTY_NETTO")]
        public double? ObrotyNetto { get; set; } = 0;

        [Column(Name = "ANULOWANO")]
        public int? ANULOWANO { get; set; } = 0;

        [Column(Name = "ANULOWANO_POWOD")]
        public string? ANULOWANO_POWOD { get; set; }

        [Column(Name = "DATA_ANULOWANIA")]
        public DateTime? DATA_ANULOWANIA { get; set; }

        [Column(Name = "IDKIEROWCA")]
        public int? IDKIEROWCA { get; set; }

        [Column(Name = "IDPOJAZD")]
        public int? IDPOJAZD { get; set; }
        // UWAGA NAZWY NIEINTUICYJNE - NAlEŻY ZMIENIć JE NA KONIEC PROJEKTU
        [Column(Name = "FILTR2")]
        public int? FILTR2 { get; set; }     // to pole przechowuje id działu w kus - id_kategorii obecnie

        [Column(Name = "FILTR3")]
        public int? FILTR3 { get; set; }     // rok trzymany     Filtr3 := seRok.AsInteger , rok i miesiac w edycji zlecenia ????

        [Column(Name = "FILTR1")]
        public int? FILTR1 { get; set; }     // to pole przechowuje id do rekordu z tabeli "FILTRY_PRZYCH"

        [Column(Name = "KATEGORIAZ")]
        public int? KATEGORIAZ { get; set; } = 0;    // id_zmiennika 

        [Column(Name = "ID_REJESTRY")]
        public int? ID_REJESTRY { get; set; } = 0;    // ID_REJESTRY rejestr faktur do którego idzie faktura ze zlecenia

        [Column(Name = "KWOTA_ZA_TONE_PS")] // ilosc ton przewoźnik
        public double? KWOTA_ZA_TONE_PS { get; set; } = 0;

        [Column(Name = "KWOTA_ZA_TONE_SW")] // stawka za tonę  własna
        public double? KWOTA_ZA_TONE_SW { get; set; } = 0;

        [Column(Name = "TONAZ")] // stawka za tonę 
        public double? TONAZ { get; set; } = 0;

        [Column(Name = "PRZEJSCIE")] // numer SAP
        public string PRZEJSCIE { get; set; }

        [Column(Name = "KOLKO")]
        public int? KOLKO { get; set; } = 0;

        [Column(Name = "DNI_PLAT_FAKTURY_WLASNEJ")]  // to ilosc palet
        public int? DNI_PLAT_FAKTURY_WLASNEJ { get; set; }

        [Column(Name = "OPLATA_SKARBOWA")]
        public double? OPLATA_SKARBOWA { get; set; } = 0;

        [Column(Name = "DNI_PLAT_FAKTURY_OBCEJ")]  // na zleceniu płatnośc obcej 
        public int? DNI_PLAT_FAKTURY_OBCEJ { get; set; }
        [Column(Name = "SW_KM")]
        public double? SW_KM { get; set; } = 0;

        [Column(Name = "CRM")]
        public string CRM { get; set; }

        [Column(Name = "ODPRAWA_CELNA_PRZYWOZ")]
        public string ODPRAWA_CELNA_PRZYWOZ { get; set; }

        [Column(Name = "EURONIP_2")]
        public string EURONIP_2 { get; set; }

        [Column(Name = "WARUNKI_DODKOWE_CD")]
        public string WARUNKI_DODKOWE_CD { get; set; } // adres

        [Column(Name = "ZLADAUNEK0")] //
        public string ZLADAUNEK0 { get; set; }

        [Column(Name = "WYLADUNEK0")]
        public string WYLADUNEK0 { get; set; }

        // WYLADUNEK0 ZLADAUNEK0
        [Column(Name = "ID_TRANSPORTU")] // przedpłata
        public int? ID_TRANSPORTU { get; set; }

        [Column(Name = "DATA_FAKTURY_OBCEJ")]
        public DateTime? DATA_FAKTURY_OBCEJ { get; set; }

        [Column(Name = "BRUTTO_FAKTURA_OBCA")] // przedpłata
        public double? BRUTTO_FAKTURA_OBCA { get; set; }

        [Column(Name = "NETTO_FAKTURA_OBCA")]
        public double? NETTO_FAKTURA_OBCA { get; set; } = 0;

        [Column(Name = "STAWKA_POZA_UNIA")]
        public double? STAWKA_POZA_UNIA { get; set; } = 0;
        [Column(Name = "ZAPLACONO_FAKTURE_OBCA")] // przedpłata
        public int? ZAPLACONO_FAKTURE_OBCA { get; set; }

        [Column(Name = "DATA_ZAPL_FAKTURY_OBCEJ")]
        public DateTime? DATA_ZAPL_FAKTURY_OBCEJ { get; set; }

        [Column(Name = "ID_TEKSTY")] // przedpłata
        public int? ID_TEKSTY { get; set; } = 0;
        [Column(Name = "DATA_PRZEWIDYWANA")]
        public DateTime? DATA_PRZEWIDYWANA { get; set; }
        
        [Column(Name = "DATA_OTRZYMANIA")]
        public DateTime? DATA_OTRZYMANIA { get; set; }
        [Column(Name = "ID_KRAJU")] // przedpłata
        public int? ID_KRAJU { get; set; }=1;        

        [Column(Name = "KRAJ1")] // przedpłata
        public int? KRAJ1 { get; set; } =1;
        [Column(Name = "PRZEWOZNIK_NETTO")]
        public double? PRZEWOZNIK_NETTO { get; set; } = 0;

        [Column(Name = "KONIEC_FRACHTU")]
        public int? KONIEC_FRACHTU { get; set; } = 0;
        [Column(Name = "OBROTY_PO_RABACIE")]
        public double? OBROTY_PO_RABACIE { get; set; } = 0;
        [Column(Name = "ID_KONTRAKTU")]
        public int? ID_KONTRAKTU { get; set; } = 0;


        


    }
}
