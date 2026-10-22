using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.ZleceniaSpedycja.Views
{
    [Table(Name = "VZLECENIA_SPED_NEW")]
    public class VZleceniaSpedNew_ORM
    {
        [Column(Name = "ID_ZLECENIA_SPED")]
        public int ID_ZLECENIA_SPED { get; set; }

        [Column(Name = "NR_KOLEJNY"), Nullable]
        public int NR_KOLEJNY { get; set; }

        [Column(Name = "NUMER_PELNY"), Nullable]
        public string NUMER_PELNY { get; set; }

        [Column(Name = "NAZWAZLECENIODAWCY"), Nullable]
        public string NAZWAZLECENIODAWCY { get; set; }

        [Column(Name = "DATA_ZLECENIA"), Nullable]
        public DateTime? DATA_ZLECENIA { get; set; }

        [Column(Name = "ID_FAKTURY"), Nullable]
        public int ID_FAKTURY { get; set; }

        [Column(Name = "REJPOJAZDU"), Nullable]
        public string REJPOJAZDU { get; set; }

        [Column(Name = "REJNACZEPY"), Nullable]
        public string REJNACZEPY { get; set; }

        [Column(Name = "NUMER_FAKTURY"), Nullable]
        public string NUMER_FAKTURY { get; set; }

        [Column(Name = "NAZWAWYKONAWCY"), Nullable]
        public string NAZWAWYKONAWCY { get; set; }

        [Column(Name = "ID_WYKONAWCY"), Nullable]
        public int? ID_WYKONAWCY { get; set; }

        [Column(Name = "IMP_EXP_KRAJ"), Nullable]
        public int IMP_EXP_KRAJ { get; set; }

        [Column(Name = "OCZEKUJACE"), Nullable]
        public int OCZEKUJACE { get; set; }

        [Column(Name = "LINK_ZLECENIE"), Nullable]
        public int LINK_ZLECENIE { get; set; }

        [Column(Name = "ID_KATEGORIA"), Nullable]
        public int ID_KATEGORIA { get; set; }    //  powiązanie z tabelą "ODDZIAŁY"

        [Column(Name = "NAZWAKAT"), Nullable] //  UWAGA *->  /* powiązanie z grupą dziaŁem  NIE Z TABELĄ KATEGORIA ZLECEŃ !!!!*/
        public string NAZWAKAT { get; set; }

        [Column(Name = "JAZDA"), Nullable] // RACZEJ NIEUŻYWANE -> BURIAN TAK
        public int JAZDA { get; set; }

        [Column(Name = "NUMER_KSIEGOWY"), Nullable]
        public string NUMER_KSIEGOWY { get; set; }

        [Column(Name = "ZBIOROWKA"), Nullable]
        public int ZBIOROWKA { get; set; }

        [Column(Name = "TRASA_DO"), Nullable]
        public string TRASA_DO { get; set; }

        [Column(Name = "TRASA_OD"), Nullable]
        public string TRASA_OD { get; set; }


        [Column(Name = "NRLECENIODAWCY"), Nullable]
        public int NRLECENIODAWCY { get; set; }

        [Column(Name = "PRZELADUNEK"), Nullable]
        public string PRZELADUNEK { get; set; }   // to jest nr referencyjny zlecenia obcego

        [Column(Name = "FINALIZED"), Nullable]
        public int FINALIZED { get; set; } = 0;   // 0 - zlecenie standardoew  ;  1 -  // częściowo zafakturowane  ; 2 - zamkniete/ zafakturowane   ; 3 -   do wyjasnienia

        [Column(Name = "KRAJ_NAD"), Nullable]
        public string KRAJ_NAD { get; set; }

        [Column(Name = "KRAJ_ODB"), Nullable]
        public string KRAJ_ODB { get; set; }
        [Column(Name = "OSOBA"), Nullable]
        public string OSOBA { get; set; }

        [Column(Name = "DATA_ZALADUNKU"), Nullable]
        public DateTime? DATA_ZALADUNKU { get; set; }

        [Column(Name = "DATA_ROZLADUNKU"), Nullable]
        public DateTime? DATA_ROZLADUNKU { get; set; }

        [Column(Name = "DATA_WYSTAWIENIA_FAKTURY"), Nullable]
        public DateTime? DATA_WYSTAWIENIA_FAKTURY { get; set; }

        [Column(Name = "DATA_SPRZEDAZY_FAKTURY"), Nullable]
        public DateTime? DATA_SPRZEDAZY_FAKTURY { get; set; }
        [Column(Name = "STAWKA_WLASNA_WALUTA"), Nullable]
        public double STAWKA_WLASNA_WALUTA { get; set; }

        [Column(Name = "STAWKA_WLASNA_PLN"), Nullable]
        public double STAWKA_WLASNA_PLN { get; set; }

        [Column(Name = "WALUTA_SW"), Nullable]
        public string WALUTA_SW { get; set; }

        [Column(Name = "PRZEWOZNIK_STAWKA_WALUTA"), Nullable]
        public double PRZEWOZNIK_STAWKA_WALUTA { get; set; }

        [Column(Name = "STAWKA_PRZEWOZNIK_PLN"), Nullable]
        public double STAWKA_PRZEWOZNIK_PLN { get; set; }

        [Column(Name = "WALUTA_PS"), Nullable]
        public string WALUTA_PS { get; set; }

        [Column(Name = "ANULOWANO"), Nullable]
        public int? ANULOWANO { get; set; }

        [Column(Name = "ANULOWANO_POWOD"), Nullable]
        public string ANULOWANO_POWOD { get; set; }

        [Column(Name = "DATA_ANULOWANIA"), Nullable]
        public DateTime? DATA_ANULOWANIA { get; set; }

        [Column(Name = "ID_USER"), Nullable]
        public int ID_USER { get; set; } //UWAGA NAZWY NIEINTUICYJNE - NAlEŻY ZMIENIć JE NA KONIEC PROJEKTU
        [Column(Name = "FILTR1"), Nullable]
        public int FILTR1 { get; set; } // to pole przechowuje id do rekordu z tabeli "FILTRY_PRZYCH"
        [Column(Name = "NRLECENIODAWCY")]
        public int? NR_ZLECENIODAWCY { get; set; }

        [Column(Name = "DODATKOWYOPISLADUNKU"), Nullable]
        public string DodatkowyOpisLadunku { get; set; }

        [Column(Name = "WARUNKIDODATKOWE"), Nullable]
        public string WarunkiDodatkowe { get; set; }
        [Column(Name = "KIEROWCA_OBCY"), Nullable]
        public string KIEROWCA_OBCY { get; set; }

        [Column(Name = "RADIO_KOD"), Nullable]
        public string RADIO_KOD { get; set; }

        [Column(Name = "EURONIP_1"), Nullable]
        public string EURONIP_1 { get; set; }


        [Column(Name = "GODZINA_ROZLADUNKU"), Nullable]
        public string GODZINA_ROZLADUNKU { get; set; }

        [Column(Name = "GODZINA_ZALADUNKU"), Nullable]
        public string GODZINA_ZALADUNKU { get; set; }




        // <summary>
        // /
        // </summary>
        /*
                [Column(Name = "ID_ZLECENIA_SPED"), PrimaryKey]
                public int ID_ZLECENIA_SPED { get; set; }

                [Column(Name = "NR_KOLEJNY")]
                public int? NR_KOLEJNY { get; set; }

                [Column(Name = "NUMER_PELNY")]
                public string NUMER_PELNY { get; set; }

                [Column(Name = "NAZWAZLECENIODAWCY")]
                public string NAZWA_ZLECENIODAWCY { get; set; }

                [Column(Name = "DATA_ZLECENIA")]
                public DateTime? DATA_ZLECENIA { get; set; }

                [Column(Name = "ID_FAKTURY")]
                public int? ID_FAKTURY { get; set; }

                [Column(Name = "REJPOJAZDU")]
                public string REJ_POJAZDU { get; set; }

                [Column(Name = "REJNACZEPY")]
                public string REJ_NACZEPY { get; set; }

                [Column(Name = "NUMER_FAKTURY")]
                public string NUMER_FAKTURY { get; set; }

                [Column(Name = "NAZWAWYKONAWCY")]
                public string NAZWA_WYKONAWCY { get; set; }

                [Column(Name = "ID_WYKONAWCY")]
                public int? ID_WYKONAWCY { get; set; }

                [Column(Name = "IMP_EXP_KRAJ")]
                public string IMP_EXP_KRAJ { get; set; }

                [Column(Name = "OCZEKUJACE")]
                public bool? OCZEKUJACE { get; set; }

                [Column(Name = "STAWKA_WLASNA_WALUTA")]
                public decimal? STAWKA_WLASNA_WALUTA { get; set; }

                [Column(Name = "PRZEWOZNIK_STAWKA_WALUTA")]
                public decimal? PRZEWOZNIK_STAWKA_WALUTA { get; set; }

                [Column(Name = "LINK_ZLECENIE")]
                public string LINK_ZLECENIE { get; set; }

                [Column(Name = "ID_KATEGORIA"), Nullable]
                public int ID_KATEGORIA { get; set; }

                [Column(Name = "NAZWAKAT")]
                public string NAZWA_KATEGORII { get; set; }

                [Column(Name = "JAZDA")]
                public string NR_JAZDY { get; set; }

                [Column(Name = "NUMER_KSIEGOWY")]
                public string NUMER_KSIEGOWY { get; set; }

                [Column(Name = "ZBIOROWKA")]
                public bool? ZBIOROWKA { get; set; }

                [Column(Name = "TRASA_DO")]
                public string TRASA_DO { get; set; }

                [Column(Name = "NRLECENIODAWCY")]
                public int? NR_ZLECENIODAWCY { get; set; }

                [Column(Name = "PRZELADUNEK")]
                public string PRZELADUNEK { get; set; }

                [Column(Name = "FINALIZED")]
                public bool? FINALIZED { get; set; }

                [Column(Name = "KRAJ_NAD")]
                public string KRAJ_NAD { get; set; }

                [Column(Name = "KRAJ_ODB")]
                public string KRAJ_ODB { get; set; }

                [Column(Name = "OSOBA")]
                public string OSOBA { get; set; }

                [Column(Name = "DATA_ZALADUNKU")]
                public DateTime? DATA_ZALADUNKU { get; set; }

                [Column(Name = "DATA_ROZLADUNKU")]
                public DateTime? DATA_ROZLADUNKU { get; set; }

                [Column(Name = "DATA_WYSTAWIENIA_FAKTURY")]
                public DateTime? DATA_WYSTAWIENIA_FAKTURY { get; set; }

                [Column(Name = "DATA_SPRZEDAZY_FAKTURY")]
                public DateTime? DATA_SPRZEDAZY_FAKTURY { get; set; }

                [Column(Name = "WALUTA_SW")]
                public string WALUTA_SW { get; set; }

                [Column(Name = "WALUTA_PS")]
                public string WALUTA_PS { get; set; }

                [Column(Name = "STAWKA_WLASNA_PLN")]
                public decimal? STAWKA_WLASNA_PLN { get; set; }

                [Column(Name = "STAWKA_PRZEWOZNIK_PLN")]
                public decimal? STAWKA_PRZEWOZNIK_PLN { get; set; }

                [Column(Name = "FILTR1")]
                public int FILTR1 { get; set; }

                [Column(Name = "ANULOWANO")]
                public int? ANULOWANO { get; set; }

                [Column(Name = "ANULOWANO_POWOD")]
                public string ANULOWANO_POWOD { get; set; }

                [Column(Name = "DATA_ANULOWANIA")]
                public DateTime? DATA_ANULOWANIA { get; set; }

                [Column(Name = "ID_USER")]
                public int? ID_USER { get; set; } */

    }
}
