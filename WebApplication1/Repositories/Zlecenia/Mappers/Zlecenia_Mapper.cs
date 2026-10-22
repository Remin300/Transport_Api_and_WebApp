using System.Collections;
using WebApplication1.ObiektyORMLinq2DB.ZleceniaSpedycja;
using WebApplication1.ObiektyORMLinq2DB.ZleceniaSpedycja.Views;
using WebApplication1.Repositories.Zlecenia.DTO;

namespace WebApplication1.Repositories.Zlecenia.Mappers
{
    public static class Zlecenia_Mapper
    {
        // ==== ZLECENIA ========================================
        public static ZlecenieSped_ORM From_Create_Zlecenia_to_ZlecenieSped_ORM_mapper(Create_Zlecenie_Dto dto)
        {
            ZlecenieSped_ORM zlecenie_obiekt = new ZlecenieSped_ORM();

            //zlecenie_obiekt.IdZleceniaSped = dto.IdZleceniaSped;


            zlecenie_obiekt.NumerPelny = dto.NumerPelny ?? "";
            zlecenie_obiekt.IdZleceniodawcy = dto.IdZleceniodawcy;
            zlecenie_obiekt.DataZlecenia = dto.DataZlecenia;
            zlecenie_obiekt.NumerPelny = dto.NumerPelny ?? "";
            zlecenie_obiekt.IdZleceniodawcy = dto.IdZleceniodawcy;
            zlecenie_obiekt.IdWykonawcy = dto.IdWykonawcy;
            zlecenie_obiekt.DataZlecenia = dto.DataZlecenia;
            zlecenie_obiekt.DataZaladunku = dto.DataZaladunku;
            zlecenie_obiekt.DataRozladunku = dto.DataRozladunku;
            zlecenie_obiekt.RejPojazduObcego = dto.RejPojazduObcego ?? "";
            zlecenie_obiekt.RejNaczepyObcej = dto.RejNaczepyObcej ?? "";
            zlecenie_obiekt.KierowcaObcy = dto.KierowcaObcy ?? "";
            zlecenie_obiekt.ZmiennikObcy = dto.ZmiennikObcy ?? "";
            zlecenie_obiekt.WarunkiDodatkowe = dto.WarunkiDodatkowe ?? "";
            zlecenie_obiekt.IdUser = dto.IdUser;
            zlecenie_obiekt.StawkaWlasna = dto.StawkaWlasna;

            zlecenie_obiekt.IdWalutySw = dto.IdWalutySw;
            zlecenie_obiekt.IdTabeliSw = dto.IdTabeliSw;
            zlecenie_obiekt.PrzewoznikStawka = dto.PrzewoznikStawka;

            zlecenie_obiekt.IdWalutyPs = dto.IdWalutyPs;
            zlecenie_obiekt.IdTabeliPs = dto.IdTabeliPs;
            zlecenie_obiekt.IdKategoria = dto.IdKategoria;
            zlecenie_obiekt.DodatkowyOpisLadunku = dto.DodatkowyOpisLadunku;
            zlecenie_obiekt.TrasaOd = dto.TrasaOd ?? "";
            zlecenie_obiekt.TrasaDo = dto.TrasaDo ?? "";
            zlecenie_obiekt.IdVatSw = dto.IdVatSw;
            zlecenie_obiekt.IdVatPs = dto.IdVatPs;
            zlecenie_obiekt.Finalized = dto.Finalized;

            zlecenie_obiekt.FILTR1 = dto.FILTR1 ?? 0;
            zlecenie_obiekt.ZLADAUNEK0 = dto.ZLADAUNEK0 ?? "";
            zlecenie_obiekt.WYLADUNEK0 = dto.WYLADUNEK0 ?? "";
            zlecenie_obiekt.FILTR2 = 0;


            return zlecenie_obiekt;
        }
        public static ZlecenieSped_ORM From_Update_Zlecenia_to_ZlecenieSped_ORM_mapper(ZlecenieSped_ORM zlecenie_obiekt, Update_Zlecenie_Dto dto)
        {



            zlecenie_obiekt.NumerPelny = dto.NumerPelny ?? "";
            zlecenie_obiekt.IdZleceniodawcy = dto.IdZleceniodawcy;
            zlecenie_obiekt.DataZlecenia = dto.DataZlecenia;
            zlecenie_obiekt.NumerPelny = dto.NumerPelny ?? "";
            zlecenie_obiekt.IdZleceniodawcy = dto.IdZleceniodawcy;
            zlecenie_obiekt.IdWykonawcy = dto.IdWykonawcy;
            zlecenie_obiekt.DataZlecenia = dto.DataZlecenia;
            zlecenie_obiekt.DataZaladunku = dto.DataZaladunku;
            zlecenie_obiekt.DataRozladunku = dto.DataRozladunku;
            zlecenie_obiekt.RejPojazduObcego = dto.RejPojazduObcego ?? "";
            zlecenie_obiekt.RejNaczepyObcej = dto.RejNaczepyObcej ?? "";
            zlecenie_obiekt.KierowcaObcy = dto.KierowcaObcy ?? "";
            zlecenie_obiekt.ZmiennikObcy = dto.ZmiennikObcy ?? "";
            zlecenie_obiekt.WarunkiDodatkowe = dto.WarunkiDodatkowe ?? "";
            zlecenie_obiekt.IdUser = dto.IdUser;
            zlecenie_obiekt.StawkaWlasna = dto.StawkaWlasna;

            zlecenie_obiekt.IdWalutySw = dto.IdWalutySw;
            zlecenie_obiekt.IdTabeliSw = dto.IdTabeliSw;
            zlecenie_obiekt.PrzewoznikStawka = dto.PrzewoznikStawka;

            zlecenie_obiekt.IdWalutyPs = dto.IdWalutyPs;
            zlecenie_obiekt.IdTabeliPs = dto.IdTabeliPs;
            zlecenie_obiekt.IdKategoria = dto.IdKategoria;
            zlecenie_obiekt.DodatkowyOpisLadunku = dto.DodatkowyOpisLadunku;
            zlecenie_obiekt.TrasaOd = dto.TrasaOd ?? "";
            zlecenie_obiekt.TrasaDo = dto.TrasaDo ?? "";
            zlecenie_obiekt.IdVatSw = dto.IdVatSw;
            zlecenie_obiekt.IdVatPs = dto.IdVatPs;
            zlecenie_obiekt.Finalized = dto.Finalized;

            zlecenie_obiekt.FILTR1 = dto.FILTR1 ?? 0;
            zlecenie_obiekt.ZLADAUNEK0 = dto.ZLADAUNEK0 ?? "";
            zlecenie_obiekt.WYLADUNEK0 = dto.WYLADUNEK0 ?? "";
            zlecenie_obiekt.FILTR2 = 0;

            return zlecenie_obiekt;
        }
        public static Update_Zlecenie_Dto From_ZlecenieSped_ORM_to_Update_Zlecenia_Dto_mapper(ZlecenieSped_ORM zlecenie_obiekt)
        {

            Update_Zlecenie_Dto dto = new Update_Zlecenie_Dto();

            dto.NumerPelny = zlecenie_obiekt.NumerPelny;
            dto.IdZleceniodawcy = zlecenie_obiekt.IdZleceniodawcy;
            dto.DataZlecenia = zlecenie_obiekt.DataZlecenia;
            dto.NumerPelny = zlecenie_obiekt.NumerPelny;
            dto.IdZleceniodawcy = zlecenie_obiekt.IdZleceniodawcy;
            dto.IdWykonawcy = zlecenie_obiekt.IdWykonawcy;
            dto.DataZlecenia = zlecenie_obiekt.DataZlecenia;
            dto.DataZaladunku = zlecenie_obiekt.DataZaladunku;
            dto.DataRozladunku = zlecenie_obiekt.DataRozladunku;
            dto.RejPojazduObcego = zlecenie_obiekt.RejPojazduObcego;
            dto.RejNaczepyObcej = zlecenie_obiekt.RejNaczepyObcej;
            dto.KierowcaObcy = zlecenie_obiekt.KierowcaObcy;
            dto.ZmiennikObcy = zlecenie_obiekt.ZmiennikObcy;
            dto.WarunkiDodatkowe = zlecenie_obiekt.WarunkiDodatkowe;
            dto.IdUser = zlecenie_obiekt.IdUser;

            //dto.StawkaWlasna = zlecenie_obiekt.StawkaWlasna;
            //dto.STAWKA_WLASNA_NA_PLN = zlecenie_obiekt.STAWKA_WLASNA_NA_PLN;
            //dto.IdWalutySw = zlecenie_obiekt.IdWalutySw;
            //dto.IdTabeliSw = zlecenie_obiekt.IdTabeliSw;
            //dto.IdVatSw = zlecenie_obiekt.IdVatSw;


            //dto.PrzewoznikStawka = zlecenie_obiekt.PrzewoznikStawka;
            //dto.PRZEWOZNIK_STAWKA_NA_PLN = zlecenie_obiekt.PRZEWOZNIK_STAWKA_NA_PLN;
            //dto.IdWalutyPs = zlecenie_obiekt.IdWalutyPs;
            //dto.IdTabeliPs = zlecenie_obiekt.IdTabeliPs;
            //dto.IdVatPs = zlecenie_obiekt.IdVatPs;

            dto.IdKategoria = zlecenie_obiekt.IdKategoria;
            dto.DodatkowyOpisLadunku = zlecenie_obiekt.DodatkowyOpisLadunku;
            dto.TrasaOd = zlecenie_obiekt.TrasaOd;
            dto.TrasaDo = zlecenie_obiekt.TrasaDo;


            dto.Finalized = zlecenie_obiekt.Finalized;

            dto.FILTR1 = zlecenie_obiekt.FILTR1;
            dto.ZLADAUNEK0 = zlecenie_obiekt.ZLADAUNEK0;
            dto.WYLADUNEK0 = zlecenie_obiekt.WYLADUNEK0;

            return dto;
        }
        // ======================================================


        // ==== STAWKI KOSZTOWE =================================
        internal static List<Stawka_kosztowa_Dto>? From_L_TowaryStawki_ORM_L_Stawka_kosztowa_Dto(List<VTowaryKoszty_ORM> stawki_kosztowe)
        {
            var l_dto = new List<Stawka_kosztowa_Dto>();
            foreach (var koszt in stawki_kosztowe)
            {
                var dto = new Stawka_kosztowa_Dto();

                dto.IdTowaryKoszty = koszt.IdTowaryKoszty;
                dto.IdTowaru = koszt.IdTowaru;

                dto.NrFaktury = koszt.NrFaktury;
                dto.Opis = koszt.Opis;
                dto.Ilosc = koszt.Ilosc;
                dto.KwotaJednostkowa = koszt.KwotaWWalucie;
                dto.KwotaCalkowita = koszt.KwotaWWalucie * koszt.Ilosc;
                dto.Waluta = koszt.Waluta;
                dto.Vat = koszt.Vat;

                dto.JednostkaMiary = koszt.JednostkaMiary;
                dto.Uwagi = koszt.Uwagi;



                l_dto.Add(dto);
            }

            return l_dto;
        }
        internal static Update_Stawka_Kosztowa_Dto From_TowaryKoszty_ORM_to_Update_Stawka_Kosztowa_Dto(TowaryKoszty_ORM stawka)
        {
            var dto = new Update_Stawka_Kosztowa_Dto();

            dto.IdTowaru = stawka.IdTowaru;
            dto.IdTowaryKoszty = stawka.IdTowaryKoszty;
            dto.IdSlownikKosztow = stawka.IdKosztu;
            dto.KwotaWWalucie = stawka.KwotaWWalucie;
            dto.Ilosc = stawka.Ilosc;
            dto.IdWaluty = stawka.IdWaluty;
            dto.IdVat = stawka.IdVat;
            dto.IdJednostkaMiar = stawka.IdJednostkaMiar;
            dto.Uwagi = stawka.Uwagi;

            return dto;
        }
        internal static TowaryKoszty_ORM From_Update_Stawka_Kosztowa_Dto_to_TowaryKoszty_ORM(TowaryKoszty_ORM stawka, Update_Stawka_Kosztowa_Dto update_dto)
        {

            stawka.IdTowaru = update_dto.IdTowaru;

            stawka.IdKosztu = update_dto.IdSlownikKosztow;
            stawka.KwotaWWalucie = update_dto.KwotaWWalucie;
            stawka.Ilosc = update_dto.Ilosc;
            stawka.IdWaluty = update_dto.IdWaluty;
            stawka.IdVat = update_dto.IdVat;
            stawka.IdJednostkaMiar = update_dto.IdJednostkaMiar;
            stawka.Uwagi = update_dto.Uwagi;

            return stawka;
        }
        
        // ======================================================


        // ==== STAWKI WLASNE =================================== 
        internal static List<Stawka_wlasna_Dto>? From_L_TowaryStawki_ORM_L_Stawka_wlasna_Dto(List<VTowaryStawki_ORM> stawki_wlasne)
        {
            var l_dto = new List<Stawka_wlasna_Dto>();
            foreach (var stawka in stawki_wlasne)
            {
                var dto = new Stawka_wlasna_Dto();

                dto.IdTowaryStawki = stawka.IdTowaryStawki;
                dto.IdTowaru = stawka.IdTowaru;

                dto.Numer_Faktury = stawka.Numer_Faktury;
                dto.Opis = stawka.Opis;
                dto.Ilosc = stawka.Ilosc;
                dto.KwotaJednostkowa = stawka.KwotaWWalucie;
                dto.KwotaCalkowita = stawka.KwotaWWalucie * stawka.Ilosc;
                dto.Waluta = stawka.Waluta;
                dto.Vat = stawka.Vat;

                dto.JednostkaMiary = stawka.JednostkaMiary;
                dto.Uwagi = stawka.Uwagi;


                dto.TRASA = stawka.TRASA;
                dto.IdFakturyPozycje = stawka.IdTowaryStawki;
                dto.IdFaktury = stawka.IdTowaryStawki;



                l_dto.Add(dto);
            }


            return l_dto;
        }
        internal static Update_Stawka_Wlasna_Dto From_TowaryStawki_ORM_to_Update_Stawka_Wlasna_Dto(TowaryStawki_ORM stawka)
        {
            var dto = new Update_Stawka_Wlasna_Dto();

            dto.IdTowaru = stawka.IdTowaru;
            dto.IdTowaryStawki = stawka.IdTowaryStawki;
            dto.IdSlownikStawek = stawka.IdSlownikStawek;
            dto.KwotaWWalucie = stawka.KwotaWWalucie;
            dto.Ilosc = stawka.Ilosc;
            dto.IdWaluty = stawka.IdWaluty;
            dto.IdVat = stawka.IdVat;
            dto.IdJednostkaMiar = stawka.IdJednostkaMiar;
            dto.Uwagi = stawka.Uwagi;

            return dto;
        }
        internal static TowaryStawki_ORM From_Update_Stawka_Wlasna_Dto_to_TowaryStawki_ORM(TowaryStawki_ORM stawka, Update_Stawka_Wlasna_Dto update_dto)
        {


            stawka.IdTowaru = update_dto.IdTowaru;
            stawka.IdSlownikStawek = update_dto.IdSlownikStawek ?? 0;
            stawka.KwotaWWalucie = update_dto.KwotaWWalucie;
            stawka.Ilosc = update_dto.Ilosc;
            stawka.IdWaluty = update_dto.IdWaluty;
            stawka.IdVat = update_dto.IdVat ?? 0;
            stawka.IdJednostkaMiar = update_dto.IdJednostkaMiar ?? 0;
            stawka.Uwagi = update_dto.Uwagi ?? "";

            return stawka;
        }
        // ======================================================


        // ==== TOWARY ==========================================
        internal static Towar_Dto? From_Towary_ORM_to_Towar_Dto(VTowaryZbiorPojazd_ORM towar)
        {
            var dto = new Towar_Dto();
            dto.IdTowaru = towar.IdTowaru;
            dto.NR_FAKTURY = towar.NR_FAKTURY;
            dto.Odbiorca = towar.Odbiorca;
            dto.Dostawca = towar.Dostawca;
            dto.Towar = towar.Towar;
            dto.DATAWYSYLKI = towar.DATAWYSYLKI;
            dto.DATADOSTARCZENIA = towar.DATADOSTARCZENIA;
            dto.PLATNIK = towar.PLATNIK;


            return dto;

        }
        internal static Update_Towar_Dto From_Towary_ORM_to_Update_Towar_Dto(Towary_ORM towar)
        {
            var dto = new Update_Towar_Dto();

            dto.IdZlecenia = towar.IdZlecenia;
            dto.IdTowaru = towar.IdTowaru;
            dto.Nazwa = towar.Nazwa;

            dto.IdZleceniodawcy = towar.IdZleceniodawcy;
            dto.IdOdbiorca = towar.IdExporter;
            dto.IdDostawcy = towar.IdDostawcy;


            dto.DataZalad = towar.DataWysylki;
            dto.DataRozlad = towar.DataDostarczenia;
          


            //zaszłości starej bazy !!! błędne nazwy w tabeli.
            // ================================
            dto.Waga = towar.Ilosc;

            dto.GodzinaZalad = towar.Numer3;
            dto.GodzinaRozlad = towar.Numer5;

            dto.Pojazd = towar.WagonPl1;
            dto.Naczepa = towar.WagonPl2;
            dto.Kierowca = towar.Numer4;
            // ================================


            dto.MiejsceZa = towar.MiejsceZa;
            dto.MiejsceRo = towar.MiejsceRo;
            dto.Ilosc = towar.Sztuki;
            dto.Uwagi = towar.Uwagi;

            return dto;
        } 
        internal static Towary_ORM From_Update_Towar_Dto_to_Towary_ORM(Towary_ORM towar, Update_Towar_Dto update_dto)
        {

            towar.IdZlecenia = update_dto.IdZlecenia;
            towar.Nazwa = update_dto.Nazwa;

            towar.IdZleceniodawcy = update_dto.IdZleceniodawcy;
            towar.IdExporter = update_dto.IdOdbiorca;
            towar.IdDostawcy = update_dto.IdDostawcy;
          

            towar.DataWysylki = update_dto.DataZalad;
            towar.DataDostarczenia = update_dto.DataRozlad;
      


            //zaszłości starej bazy !!! błędne nazwy w tabeli.
            // ================================
            towar.Ilosc = update_dto.Waga;
            towar.Numer3 = update_dto.GodzinaZalad ?? "";
            towar.Numer5 = update_dto.GodzinaRozlad ?? "";
            towar.WagonPl1 = update_dto.Pojazd ?? "";
            towar.WagonPl2 = update_dto.Naczepa ?? "";
            towar.Numer4 = update_dto.Kierowca ?? "";

            // ================================


            towar.MiejsceZa = update_dto.MiejsceZa ?? "";
   


            towar.MiejsceRo = update_dto.MiejsceRo ?? "";
   


            towar.Sztuki = (float)(update_dto.Ilosc ?? 0);


            towar.Uwagi = update_dto.Uwagi ?? "";
   
            return towar;
        }
        // ====================================================== 
    }
}
