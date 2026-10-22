using LinqToDB.Mapping;
using System;

namespace WebApplication1.ObiektyORMLinq2DB.ZleceniaSpedycja
{
    [Table(Name = "DOKUMENTY")]
    internal class Dokumenty_ORM
    {
        [PrimaryKey, Identity]
        [Column(Name = "ID_DOKUMENTU")]
        public int IdDokumentu { get; set; }

        [Column(Name = "NAZWA"), NotNull]
        public string Nazwa { get; set; }

        [Column(Name = "RODZAJE_AKCJI"), Nullable]
        public int? RodzajeAkcji { get; set; }

        [Column(Name = "DOMYSLNY"), NotNull]
        public int? Domyslny { get; set; }

        [Column(Name = "ID_MASKI"), Nullable]
        public int? IdMaski { get; set; }
    }
}
