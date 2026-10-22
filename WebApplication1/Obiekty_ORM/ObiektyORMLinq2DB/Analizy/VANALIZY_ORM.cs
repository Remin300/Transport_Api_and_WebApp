using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.Analizy
{

    [Table(Name = "VANALIZY")]
    public class VANALIZY_ORM
    {
        [Column] public int IDTOWARU { get; set; }

        [Column] public int? IDSTAWKI { get; set; }
        [Column] public int? IDZLECENIA { get; set; }
        [Column] public int? IDKONTRAHENTA { get; set; }
        [Column] public int? IDPRZEWOZNIKA { get; set; }

        [Column, Nullable] public string KONTRAHENT { get; set; }
        [Column, Nullable] public string PRZEWOZNIK { get; set; }
        [Column, Nullable] public string PRZEWOZNIK1 { get; set; }

        [Column] public int? ID_USER { get; set; }

        [Column, Nullable] public string NAZWISKO { get; set; }
        [Column, Nullable] public string IMIE { get; set; }

        [Column, Nullable] public string NUMER_PELNY_ZLECENIA { get; set; }

        [Column] public DateTime? DATA_ZLECENIA { get; set; }
        [Column] public DateTime? DATA_ZALADUNKU { get; set; }

        [Column, Nullable] public string KZAL { get; set; }
        [Column, Nullable] public string MZAL { get; set; }

        [Column] public DateTime? DATA_ROZLADUNKU { get; set; }

        [Column, Nullable] public string KROZL { get; set; }
        [Column, Nullable] public string MROZL { get; set; }

        [Column] public short? MIESIAC { get; set; }
        [Column] public short? ROK { get; set; }

        [Column, Nullable] public string NRREJ { get; set; }
        [Column, Nullable] public string NRREF { get; set; }
        [Column, Nullable] public string NR_FAKTURY { get; set; }

        [Column] public double? FAKTURANETT { get; set; }
        [Column] public double? KOREKTYNETT { get; set; }
        [Column] public double? KOREKTYNETT01 { get; set; }
        [Column] public double? NOTTYNETT { get; set; }
        [Column] public double? NOTTYNETT01 { get; set; }

        [Column] public double? STAWKIPLN { get; set; }
        [Column] public double? STAWKIWALUTA { get; set; }
        [Column] public double? WALST { get; set; }

        [Column, Nullable] public string NUMERFAKKOSZT { get; set; }

        [Column] public double? FAKTURAKOSZT { get; set; }
        [Column] public double? STAWKAKOSZTPLN { get; set; }
        [Column] public double? STAWKAKOSZTWALUTA { get; set; }
        [Column] public double? WALKOSZ { get; set; }

        [Column] public int? KOREKTAKOSZT { get; set; }
        [Column] public int? ID_WALUTA { get; set; }
        [Column] public int? ID_TABELA { get; set; }

        [Column, Nullable] public string NRKOREKTY { get; set; }

        [Column] public int? TOWAR_NR { get; set; }
        [Column] public int? ID_ZLECENIODAWCY { get; set; }

        [Column] public double? ILDEKL { get; set; }
        [Column] public int? ILCAL { get; set; }

        [Column] public int? DZIAL { get; set; }
        [Column] public int? DZIAL1 { get; set; }

        [Column] public double? WAGA { get; set; }

        [Column] public int? DEF_WYKONAWCA { get; set; }
        [Column] public int? ID_RODZAJ_DOK { get; set; }

        [Column] public int? KM { get; set; }

        [Column, Nullable] public string TYP { get; set; }

        [Column] public int? ZAPLACONA { get; set; }
        [Column] public int? ID_DOKUMENT { get; set; }
        [Column] public int? SKORYGOWANA { get; set; }
        [Column] public int? IDFAKTURY { get; set; }

        [Column] public double? KWOTA_ZL { get; set; }

        [Column, Nullable] public string NAZWA_DZIAL { get; set; }

        [Column] public double? PRZEWOZNIK_STAWKAPLN { get; set; }
        [Column] public double? PRZEWOZNIK_STAWKAEUR { get; set; }
        [Column] public double? PRZEWOZNIK_KWOTA { get; set; }

        [Column] public int? ID_WALUTY_PS { get; set; }

        [Column] public double? KURS { get; set; }
        [Column] public double? INNY { get; set; }
        [Column] public double? MINUS { get; set; }

    }
}
