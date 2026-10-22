using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.Faktury
{
    [Table(Name = "PRZELEW")]
    public class Przelewy_ORM
    {
        [PrimaryKey, Column(Name = "ID_PRZELEW"), NotNull]
        public int Id_Przelew_PK { get; set; }

        [Column(Name = "KONTRAHENT"), Nullable]
        public string? Kontrahent { get; set; }

        [Column(Name = "ADRES"), Nullable]
        public string? Adres { get; set; }

        [Column(Name = "MIASTO"), Nullable]
        public string? Miasto { get; set; }

        [Column(Name = "ID_KONTRAHENTA"), Nullable]
        public int? IdKontrahenta { get; set; }

        [Column(Name = "ID_RACH"), Nullable]
        public int? IdRach { get; set; }

        [Column(Name = "NR_FAKTURY"), Nullable]
        public string? NrFaktury { get; set; }

        [Column(Name = "KWOTA"), Nullable]
        public double? Kwota { get; set; }

        [Column(Name = "KONTO"), Nullable]
        public string? Konto { get; set; }

        [Column(Name = "SWITH"), Nullable]    // to chyba literówka????   CHodzi o nr swift
        public string? Swith { get; set; }

        [Column(Name = "OBCIAZENIE"), Nullable]
        public string? Obciazenie { get; set; }

        [Column(Name = "TYP"), Nullable]
        public string? Typ { get; set; }

        [Column(Name = "NUMER"), NotNull]
        public int Numer { get; set; }

        [Column(Name = "DATA"), Nullable]
        public DateTime? Data { get; set; }

        [Column(Name = "WALUTA"), Nullable]
        public string? Waluta { get; set; }

        [Column(Name = "Z_KONTA"), Nullable]
        public string? ZKonta { get; set; }

        [Column(Name = "KONTO_PROWIZJI"), Nullable]
        public string? KONTO_PROWIZJI { get; set; }="";

        [Column(Name = "IDKONTA"), Nullable]
        public int? IdKonta { get; set; }    // id konta wlasnego

        [Column(Name = "IDKONTA_WLASNE"), Nullable]
        public int? IdKontaWlasne { get; set; }

        [Column(Name = "EMAIL"), Nullable]
        public string? Email { get; set; }

        [Column(Name = "MPATH"), Nullable]
        public string? MPath { get; set; }

        [Column(Name = "PODZIELNA"), Nullable]
        public int? Podzielna { get; set; }

        [Column(Name = "VATKWOTA"), Nullable]
        public double? VatKwota { get; set; }

        [Column(Name = "IDPRACOWNIK"), Nullable]
        public int? IdPracownik { get; set; }
    }
}
