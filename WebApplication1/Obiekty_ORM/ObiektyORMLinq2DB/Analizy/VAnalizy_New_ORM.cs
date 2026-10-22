using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.Analizy
{
    [Table(Name = "VANALIZY_NEW")]
    internal class VAnalizy_New_ORM
    {
        [Column(Name = "IDTOWARU")] public int? IdTowaru { get; set; }
        [Column(Name = "IDSTAWKI")] public int? IdStawki { get; set; }
        [Column(Name = "IDZLECENIA")] public int? IdZlecenia { get; set; }
        [Column(Name = "IDKONTRAHENTA")] public int? IdKontrahenta { get; set; }
        [Column(Name = "IDPRZEWOZNIKA")] public int? IdPrzewoznika { get; set; }
        [Column(Name = "KONTRAHENT")] public string Kontrahent { get; set; }
        [Column(Name = "PRZEWOZNIK")] public string Przewoznik { get; set; }
        [Column(Name = "PRZEWOZNIK1")] public string Przewoznik1 { get; set; }
        [Column(Name = "ID_USER")] public int? IdUser { get; set; }
        [Column(Name = "NAZWISKO")] public string Nazwisko { get; set; }
        [Column(Name = "IMIE")] public string Imie { get; set; }
        [Column(Name = "NUMER_PELNY_ZLECENIA")] public string NumerPelnyZlecenia { get; set; }
        [Column(Name = "DATA_ZLECENIA")] public DateTime? DataZlecenia { get; set; }
        [Column(Name = "DATA_ZALADUNKU")] public DateTime? DataZaladunku { get; set; }
        [Column(Name = "KZAL")] public string Kzal { get; set; }
        [Column(Name = "MZAL")] public string Mzal { get; set; }
        [Column(Name = "DATA_ROZLADUNKU")] public DateTime? DataRozladunku { get; set; }
        [Column(Name = "KROZL")] public string Krozl { get; set; }
        [Column(Name = "MROZL")] public string Mrozl { get; set; }
        [Column(Name = "MIESIAC")] public int? Miesiac { get; set; }
        [Column(Name = "ROK")] public int? Rok { get; set; }
        [Column(Name = "NRREJ")] public string NrRej { get; set; }
        [Column(Name = "NRREF")] public string NrRef { get; set; }
        [Column(Name = "NR_FAKTURY")] public string NrFaktury { get; set; }
        [Column(Name = "FAKTURANETT")] public double? FakturaNett { get; set; }
        [Column(Name = "KOREKTYNETT")] public double? KorektyNett { get; set; }
        [Column(Name = "KOREKTYNETT01")] public double? KorektyNett01 { get; set; }
        [Column(Name = "NOTTYNETT")] public double? NottyNett { get; set; }
        [Column(Name = "NOTTYNETT01")] public double? NottyNett01 { get; set; }
        [Column(Name = "STAWKIPLN")] public double? StawkiPLN { get; set; }
        [Column(Name = "STAWKIWALUTA")] public double? StawkiWaluta { get; set; }
        [Column(Name = "WALST")] public double WalSt { get; set; }
        [Column(Name = "NUMERFAKKOSZT")] public string NumerFakKoszt { get; set; } // ???? dziwny tym zmiennej BLOOB SUB_TYP
        [Column(Name = "FAKTURAKOSZT")] public double? FakturaKoszt { get; set; }
        [Column(Name = "STAWKAKOSZTPLN")] public double? StawkaKosztPLN { get; set; }
        [Column(Name = "STAWKAKOSZTWALUTA")] public double? StawkaKosztWaluta { get; set; }
        [Column(Name = "WALKOSZ")] public double WalKosz { get; set; }
        [Column(Name = "KOREKTAKOSZT")] public int? KorektaKoszt { get; set; }
        [Column(Name = "ID_WALUTA")] public int? IdWaluta { get; set; }
        [Column(Name = "ID_TABELA")] public int? IdTabela { get; set; }
        [Column(Name = "NRKOREKTY")] public string NrKorekty { get; set; } // ???? dziwny tym zmiennej BLOOB SUB_TYP
        [Column(Name = "TOWAR_NR")] public int TowarNr { get; set; }
        [Column(Name = "ID_ZLECENIODAWCY")] public int? IdZleceniodawcy { get; set; }
        [Column(Name = "ILDEKL")] public double? IlDekl { get; set; }
        [Column(Name = "ILCAL")] public double? IlCal { get; set; }
        [Column(Name = "DZIAL")] public int? Dzial { get; set; }
        [Column(Name = "DZIAL1")] public int? Dzial1 { get; set; }
        [Column(Name = "WAGA")] public double? Waga { get; set; }
        [Column(Name = "DEF_WYKONAWCA")] public int DefWykonawca { get; set; }
        [Column(Name = "ID_RODZAJ_DOK")] public int? IdRodzajDok { get; set; }
        [Column(Name = "KM")] public int? Km { get; set; }
        [Column(Name = "TYP")] public string Typ { get; set; }
        [Column(Name = "ZAPLACONA")] public int? Zaplacona { get; set; }
        [Column(Name = "ID_DOKUMENT")] public int? IdDokument { get; set; }
        [Column(Name = "SKORYGOWANA")] public int? Skorygowana { get; set; }
        [Column(Name = "IDFAKTURY")] public int? IdFaktury { get; set; }
        [Column(Name = "KWOTA_ZL")] public double? KwotaZl { get; set; }
        [Column(Name = "NAZWA_DZIAL")] public string NazwaDzial { get; set; }
        [Column(Name = "PRZEWOZNIK_STAWKAPLN")] public double? PrzewoznikStawkaPLN { get; set; }
        [Column(Name = "PRZEWOZNIK_STAWKAEUR")] public double? PrzewoznikStawkaEUR { get; set; }
        [Column(Name = "PRZEWOZNIK_KWOTA")] public double? PrzewoznikKwota { get; set; }
        [Column(Name = "ID_WALUTY_PS")] public int? IdWalutyPS { get; set; }
        [Column(Name = "KURS")] public double? Kurs { get; set; }
        [Column(Name = "INNY")] public double Inny { get; set; }
        [Column(Name = "MINUS")] public double? Minus { get; set; }


  

    }
}
