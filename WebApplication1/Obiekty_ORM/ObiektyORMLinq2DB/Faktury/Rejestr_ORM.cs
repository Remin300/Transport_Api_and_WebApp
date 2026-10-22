using LinqToDB.Mapping;

namespace WebApplication1.ObiektyORMLinq2DB.Faktury
{

    [Table(Name = "REJESTRY")]
    internal class Rejestr_ORM
    {
        [PrimaryKey, Identity]
        [Column("ID_REJESTRY")]
        public int ID_REJESTRY { get; set; }
        [Column("NUMER_REJESTRU")]
        public int NUMER_REJESTRU { get; set; }
        [Column("OPIS")]
        public string OPIS { get; set; }
        [Column("MASKA")]
        public string MASKA { get; set; }
        [Column("RODZAJ_TRANSPORT")]
        public int RODZAJ_TRANSPORT { get; set; }
        [Column("RODZAJ_EXPIMP")]  //  RODZAJ_EXPIMP =1 samofakturowanie !!!! wystawienie faktury podać numer z reki
        public int RODZAJ_EXPIMP { get; set; }
        [Column("REJESTR_FK")]
        public string REJESTR_FK { get; set; }
        [Column("SKROT_FK")]  ///uwaga -> wstawić po *numer*numer*  id defoltowo wystawjających faktury
        public string SKROT_FK { get; set; }

        [Column("KONTO_MA")]
        public string? KONTO_MA { get; set; }
        [Column("KONTO_WN")]
        public string? KONTO_WN { get; set; }
        [Column("KONTO_VAT")]
        public string? KONTO_VAT { get; set; }


    }
}
