using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.ZleceniaSpedycja
{
    [Table(Name = "TOWARY")]
    internal class Towary_ORM
    {
        [PrimaryKey]
        [Column(Name = "ID_TOWARU")]
        public int IdTowaru { get; set; }

        [Column(Name = "ID_PRZESYLKI")]
        public int? IdPrzesylki { get; set; }

        [Column(Name = "ID_ZLECENIA")]
        public int? IdZlecenia { get; set; }

        [Column(Name = "ID_MIEJSCA_NAD")]
        public int? IdMiejscaNad { get; set; }

        [Column(Name = "ID_MIEJSCA_ODB")]
        public int? IdMiejscaOdb { get; set; }

        [Column(Name = "ID_DOSTAWCY")]
        public int? IdDostawcy { get; set; }

        [Column(Name = "ID_ODBIORCY")]
        public int? IdOdbiorcy { get; set; }

        [Column(Name = "NAZWA")]
        public string Nazwa { get; set; }

        [Column(Name = "NUMER3")]
        public string Numer3 { get; set; }

        [Column(Name = "NUMER4")]
        public string Numer4 { get; set; }

        [Column(Name = "NUMER5")]
        public string Numer5 { get; set; }

        [Column(Name = "NUMER6")]
        public string Numer6 { get; set; }

        [Column(Name = "NUMER7")]
        public string Numer7 { get; set; }

        [Column(Name = "ILOSC")]
        public double? Ilosc { get; set; }

        [Column(Name = "ID_JEDNOSTKI_MIARY")]
        public int? IdJednostkiMiary { get; set; }

        [Column(Name = "ILOSC_DEKLAROWANA")]
        public double? IloscDeklarowana { get; set; }

        [Column(Name = "DATADOSTARCZENIA")]
        public DateTime? DataDostarczenia { get; set; }

        [Column(Name = "ID_FRACHTU")]
        public int? IdFrachtu { get; set; }

        [Column(Name = "ID_IMPORTER")]
        public int? IdImporter { get; set; }

        [Column(Name = "ID_EXPORTER")]
        public int? IdExporter { get; set; }

        [Column(Name = "LP")]
        public int? Lp { get; set; }

        [Column(Name = "ID_INCOTERMS")]
        public int? IdIncoterms { get; set; }

        [Column(Name = "ID_TRANZYT")]
        public int? IdTranzyt { get; set; }

        [Column(Name = "BEZPOSREDNIA")]
        public bool? Bezposrednia { get; set; }

        [Column(Name = "LOTNICZA")]
        public int? Lotnicza { get; set; }

        [Column(Name = "TRANZYT")]
        public int? Tranzyt { get; set; }

        [Column(Name = "METRY")]
        public float? Metry { get; set; }

        [Column(Name = "SUBSPEDYTOR")]
        public string Subspedycja { get; set; }

        [Column(Name = "ID_SUBSPEDYCJA")]
        public int? IdSubspedycja { get; set; }

        [Column(Name = "ID_SPED_ZLECONY")]
        public int? IdSpedZlecony { get; set; }

        [Column(Name = "IDTOWARY_KOSZTY")]
        public int? IdTowaryKoszty { get; set; }

        [Column(Name = "IDTOWARY_STAWKI")]
        public int? IdTowaryStawki { get; set; }

        [Column(Name = "METRY_L")]
        public float? MetryL { get; set; }

        [Column(Name = "SZTUKI")]
        public float? Sztuki { get; set; }

        [Column(Name = "ILOSC_OBL")]
        public float? IloscObliczona { get; set; }  //   UAGA to  waga Obliczona

        [Column(Name = "ODPRAWA_WYWOZOWA")]
        public string OdprawaWywozowa { get; set; }

        [Column(Name = "ODPRAWA_PRZYWOZOWA")]
        public string OdprawaPrzywozowa { get; set; }

        [Column(Name = "TOWAR_NR")]
        public int TowarNr { get; set; }

        [Column(Name = "DATAWYSYLKI")]
        public DateTime? DataWysylki { get; set; }

        [Column(Name = "METRY3")]
        public float? Metry3 { get; set; }

        [Column(Name = "IDFAKTURY")]
        public int? IdFaktury { get; set; } = 0; // to używane ID FAKTURY

        [Column(Name = "NUMER1")]
        public string Numer1 { get; set; }

        [Column(Name = "WARTOSC")]
        public float? Wartosc { get; set; }

        [Column(Name = "ID_WALUTY")]
        public int? IdWaluty { get; set; }

        [Column(Name = "NUMER2")]
        public string Numer2 { get; set; }

        [Column(Name = "DOKUMENTY")]
        public string Dokumenty { get; set; }

        [Column(Name = "ID_TABELI")]
        public int? IdTabeli { get; set; }

        [Column(Name = "MIEJSCE_ZA")]
        public string MiejsceZa { get; set; }

        [Column(Name = "MIEJSCE_RO")]
        public string MiejsceRo { get; set; }

        [Column(Name = "FAKTURA")]
        public int Faktura { get; set; }

        [Column(Name = "BLOKADA")]
        public int? Blokada { get; set; } // flaga 0 - 1 -- > Faktura wyslana do klienta mailem

        [Column(Name = "ID_TOWARY_MAZGAZYN")]
        public int? IdTowaryMagazyn { get; set; }

        [Column(Name = "INNA_TABELA")]
        public int InnaTabela { get; set; }

        [Column(Name = "POWOD_USUNIECIA")]
        public string PowodUsuniecia { get; set; }

        [Column(Name = "ID_KONTRAKTU")]
        public int? IdKontraktu { get; set; }

        [Column(Name = "UWAGI")]
        public string Uwagi { get; set; }



        [Column(Name = "ID_ZLECENIODAWCY")]
        public int? IdZleceniodawcy { get; set; }

        [Column(Name = "ID_TRANSPORTU")]
        public int? IdTransportu { get; set; }

        [Column(Name = "ID_WAGON")]
        public int? IdWagon { get; set; }

        [Column(Name = "ID_TOWARY_STAWKI")]
        public int? Id_TowaryStawki { get; set; }



        // ------------ UWAGA !!!!  NAZWY NIEINTUICYJNE ------------------------------------
        // ------------ UWAGA !!!!  NALEŻY PAMIĘTAĆ I / LUB POPRAWIĆ -----------------------
        // ---------------------------------------------------------------------------------

        [Column(Name = "PRZEJSCIE")]             // TO JEST KIEROWCA
        public string Przejscie { get; set; }

        [Column(Name = "WAGON")]                 // TO JEST ZMIENNIK
        public string Wagon { get; set; }

        [Column(Name = "WAGON_PL1")]             // TO JEST REJESTRACJA POJAZDU
        public string WagonPl1 { get; set; }

        [Column(Name = "WAGON_PL2")]             // TO JEST REJESTRACJA NACZEPY
        public string WagonPl2 { get; set; }

        // ---------------------------------------------------------------------------------
        // ---------------------------------------------------------------------------------
        // ---------------------------------------------------------------------------------

        [Column(Name = "ID_FAKTURY")]   // nie używane ID FAKTURY
        public int? IdFaktury2 = 0;
        [Column(Name = "OPIS")]             // TO JEST REJESTRACJA NACZEPY
        public string OPIS { get; set; }
        /// ADR
        /// 
        [Column(Name = "GRUPA_PAKOWANIA")]             // TO JEST REJESTRACJA NACZEPY
        public int GRUPA_PAKOWANIA { get; set; }
        [Column(Name = "KLASA_ADR")]             // TO JEST REJESTRACJA NACZEPY
        public string KLASA_ADR { get; set; }

        [Column(Name = "ZEWNETRZNY")]             // TO JEST REJESTRACJA NACZEPY
        public int ZEWNETRZNY { get; set; }

        [Column(Name = "ID_KLASA_ADR")]             // TO JEST REJESTRACJA NACZEPY
        public int ID_KLASA_ADR { get; set; }

        [Column(Name = "RYZYKO")]             // TO JEST REJESTRACJA NACZEPY
        public string RYZYKO { get; set; }
        [Column(Name = "KOD_UN")]             // TO JEST REJESTRACJA NACZEPY
        public string KOD_UN { get; set; }

    }
}
