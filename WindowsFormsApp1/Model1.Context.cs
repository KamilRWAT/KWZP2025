﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KWZPEntities : DbContext
    {
        public KWZPEntities()
            : base("name=KWZPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cecha_wydatku> Cecha_wydatku { get; set; }
        public virtual DbSet<Czynnosci_produkcyjne> Czynnosci_produkcyjne { get; set; }
        public virtual DbSet<Dostawa> Dostawa { get; set; }
        public virtual DbSet<Dostawca> Dostawca { get; set; }
        public virtual DbSet<Dzien_wolny_od_pracy> Dzien_wolny_od_pracy { get; set; }
        public virtual DbSet<Element> Element { get; set; }
        public virtual DbSet<Element_materialy> Element_materialy { get; set; }
        public virtual DbSet<Grafik_obecnosci> Grafik_obecnosci { get; set; }
        public virtual DbSet<Kalendarz_pracy> Kalendarz_pracy { get; set; }
        public virtual DbSet<Kalendarz_roku> Kalendarz_roku { get; set; }
        public virtual DbSet<Klient> Klient { get; set; }
        public virtual DbSet<Kontrola_jakosci_elementu> Kontrola_jakosci_elementu { get; set; }
        public virtual DbSet<Kontrola_jakosci_produktu> Kontrola_jakosci_produktu { get; set; }
        public virtual DbSet<Marza> Marza { get; set; }
        public virtual DbSet<Marza_zamowienie> Marza_zamowienie { get; set; }
        public virtual DbSet<Maszyny> Maszyny { get; set; }
        public virtual DbSet<Material> Material { get; set; }
        public virtual DbSet<Miary> Miary { get; set; }
        public virtual DbSet<Model_maszyny> Model_maszyny { get; set; }
        public virtual DbSet<Model_pojazdu> Model_pojazdu { get; set; }
        public virtual DbSet<Narzedzia> Narzedzia { get; set; }
        public virtual DbSet<Narzedzia_w_obsludze> Narzedzia_w_obsludze { get; set; }
        public virtual DbSet<Niedostepnosc> Niedostepnosc { get; set; }
        public virtual DbSet<Obslugi_maszyn> Obslugi_maszyn { get; set; }
        public virtual DbSet<Osoba> Osoba { get; set; }
        public virtual DbSet<Pensja> Pensja { get; set; }
        public virtual DbSet<Platnosc> Platnosc { get; set; }
        public virtual DbSet<Pojazd> Pojazd { get; set; }
        public virtual DbSet<Pracownik> Pracownik { get; set; }
        public virtual DbSet<Pracownik_stanowiska> Pracownik_stanowiska { get; set; }
        public virtual DbSet<Produkcja_elementu> Produkcja_elementu { get; set; }
        public virtual DbSet<Produkcja_produktu> Produkcja_produktu { get; set; }
        public virtual DbSet<Produkt> Produkt { get; set; }
        public virtual DbSet<Produkt_elementy> Produkt_elementy { get; set; }
        public virtual DbSet<Przeglady_pojazdy> Przeglady_pojazdy { get; set; }
        public virtual DbSet<Rodzaj_wlasciwosci> Rodzaj_wlasciwosci { get; set; }
        public virtual DbSet<Stan_pracownika> Stan_pracownika { get; set; }
        public virtual DbSet<Stanowisko> Stanowisko { get; set; }
        public virtual DbSet<Stanowisko_produkcyjne> Stanowisko_produkcyjne { get; set; }
        public virtual DbSet<Status_obecnosci> Status_obecnosci { get; set; }
        public virtual DbSet<Status_transakcji> Status_transakcji { get; set; }
        public virtual DbSet<Stawka_RB> Stawka_RB { get; set; }
        public virtual DbSet<Szczegoly_dostawa> Szczegoly_dostawa { get; set; }
        public virtual DbSet<Szczegoly_obslugi> Szczegoly_obslugi { get; set; }
        public virtual DbSet<Szczegoly_parametry_maszyny> Szczegoly_parametry_maszyny { get; set; }
        public virtual DbSet<Szczegoly_wydania> Szczegoly_wydania { get; set; }
        public virtual DbSet<Szczegoly_wydatku> Szczegoly_wydatku { get; set; }
        public virtual DbSet<Szczegoly_wyplata> Szczegoly_wyplata { get; set; }
        public virtual DbSet<Szczegoly_zamowienia> Szczegoly_zamowienia { get; set; }
        public virtual DbSet<Szczegoly_zaopatrzenia> Szczegoly_zaopatrzenia { get; set; }
        public virtual DbSet<Szczegoly_zuzycia> Szczegoly_zuzycia { get; set; }
        public virtual DbSet<Szczegoly_zwrotu_z_produkcji> Szczegoly_zwrotu_z_produkcji { get; set; }
        public virtual DbSet<Transakcje> Transakcje { get; set; }
        public virtual DbSet<Transport> Transport { get; set; }
        public virtual DbSet<Typ_maszyny> Typ_maszyny { get; set; }
        public virtual DbSet<Typ_materialu> Typ_materialu { get; set; }
        public virtual DbSet<Typ_narzedzia> Typ_narzedzia { get; set; }
        public virtual DbSet<Typ_obslugi> Typ_obslugi { get; set; }
        public virtual DbSet<Typ_pojazdu> Typ_pojazdu { get; set; }
        public virtual DbSet<Typ_stanowiska> Typ_stanowiska { get; set; }
        public virtual DbSet<Typ_wydatku> Typ_wydatku { get; set; }
        public virtual DbSet<Ubezpieczenia_pojazdy> Ubezpieczenia_pojazdy { get; set; }
        public virtual DbSet<Uprawnienia> Uprawnienia { get; set; }
        public virtual DbSet<Urlop_dni_wolne> Urlop_dni_wolne { get; set; }
        public virtual DbSet<Urlop_pracownik> Urlop_pracownik { get; set; }
        public virtual DbSet<Urlopy_nieobecnosc> Urlopy_nieobecnosc { get; set; }
        public virtual DbSet<Wlasciwosci_element> Wlasciwosci_element { get; set; }
        public virtual DbSet<Wlasciwosci_materialu> Wlasciwosci_materialu { get; set; }
        public virtual DbSet<Wlasciwosci_miar> Wlasciwosci_miar { get; set; }
        public virtual DbSet<Wlasciwosci_model_maszyny> Wlasciwosci_model_maszyny { get; set; }
        public virtual DbSet<Wlasciwosci_model_pojazdu> Wlasciwosci_model_pojazdu { get; set; }
        public virtual DbSet<Wlasciwosci_narzedzia> Wlasciwosci_narzedzia { get; set; }
        public virtual DbSet<Wlasciwosci_produkt> Wlasciwosci_produkt { get; set; }
        public virtual DbSet<Wplywy> Wplywy { get; set; }
        public virtual DbSet<Wydanie_na_produkcje> Wydanie_na_produkcje { get; set; }
        public virtual DbSet<Wydatki> Wydatki { get; set; }
        public virtual DbSet<Wyposazenie_stanowiska_maszyny> Wyposazenie_stanowiska_maszyny { get; set; }
        public virtual DbSet<Wyposazenie_stanowiska_narzedzia> Wyposazenie_stanowiska_narzedzia { get; set; }
        public virtual DbSet<Zamowienie> Zamowienie { get; set; }
        public virtual DbSet<Zaopatrzenie> Zaopatrzenie { get; set; }
        public virtual DbSet<Zwroty_z_produkcji> Zwroty_z_produkcji { get; set; }
        public virtual DbSet<V_AktualneStawkiRbStanowiska> V_AktualneStawkiRbStanowiska { get; set; }
        public virtual DbSet<V_Bilans> V_Bilans { get; set; }
        public virtual DbSet<V_CenaMaterialow1> V_CenaMaterialow1 { get; set; }
        public virtual DbSet<V_CenaMaterialuDoZamowienia> V_CenaMaterialuDoZamowienia { get; set; }
        public virtual DbSet<V_CenaWytworzeniaElementowDoZamowieniaPosrednia> V_CenaWytworzeniaElementowDoZamowieniaPosrednia { get; set; }
        public virtual DbSet<V_CenaWytworzeniaProduktowDoZamowieniaPosrednia> V_CenaWytworzeniaProduktowDoZamowieniaPosrednia { get; set; }
        public virtual DbSet<V_CenaZaDostawe> V_CenaZaDostawe { get; set; }
        public virtual DbSet<V_CenaZamowienia> V_CenaZamowienia { get; set; }
        public virtual DbSet<V_CenaZaSztukeMaterialu> V_CenaZaSztukeMaterialu { get; set; }
        public virtual DbSet<V_CzasProdukcjiElementowDoZamowienia> V_CzasProdukcjiElementowDoZamowienia { get; set; }
        public virtual DbSet<V_CzasProdukcjiProduktowDoZamowienia> V_CzasProdukcjiProduktowDoZamowienia { get; set; }
        public virtual DbSet<V_CzasRealizacjiZamowienia> V_CzasRealizacjiZamowienia { get; set; }
        public virtual DbSet<V_ElementDlugosc> V_ElementDlugosc { get; set; }
        public virtual DbSet<V_IloscElementowNaProdukt> V_IloscElementowNaProdukt { get; set; }
        public virtual DbSet<V_IlosElementowNaZamowienieKoniec> V_IlosElementowNaZamowienieKoniec { get; set; }
        public virtual DbSet<V_IlosElementowNaZamowieniePosrednie> V_IlosElementowNaZamowieniePosrednie { get; set; }
        public virtual DbSet<V_IlosMaterialuDoZamowieniaKoniec> V_IlosMaterialuDoZamowieniaKoniec { get; set; }
        public virtual DbSet<V_IlosMaterialuDoZamowieniaPosrednia> V_IlosMaterialuDoZamowieniaPosrednia { get; set; }
        public virtual DbSet<V_IlosProdotkowWZamowieniu> V_IlosProdotkowWZamowieniu { get; set; }
        public virtual DbSet<V_KalendarzDniPracujacych> V_KalendarzDniPracujacych { get; set; }
        public virtual DbSet<V_KosztProdukcjaElementuDoZamowienia> V_KosztProdukcjaElementuDoZamowienia { get; set; }
        public virtual DbSet<V_KosztProdukcjaProduktuDoZamowienia> V_KosztProdukcjaProduktuDoZamowienia { get; set; }
        public virtual DbSet<V_Kosztytransportuklientow> V_Kosztytransportuklientow { get; set; }
        public virtual DbSet<V_MaterialDlugosc> V_MaterialDlugosc { get; set; }
        public virtual DbSet<V_NiedostepnoscPracownika> V_NiedostepnoscPracownika { get; set; }
        public virtual DbSet<V_NieobecnosciPracownikaWMiesiacu> V_NieobecnosciPracownikaWMiesiacu { get; set; }
        public virtual DbSet<V_OstatniaDostawaDoKlienta> V_OstatniaDostawaDoKlienta { get; set; }
        public virtual DbSet<V_PozostalyUrlop> V_PozostalyUrlop { get; set; }
        public virtual DbSet<V_ProdukcjaElementy> V_ProdukcjaElementy { get; set; }
        public virtual DbSet<V_ProdukcjaProdukty> V_ProdukcjaProdukty { get; set; }
        public virtual DbSet<V_RbStanowiskoModel> V_RbStanowiskoModel { get; set; }
        public virtual DbSet<V_Stan_uzytkowania_narzedzi> V_Stan_uzytkowania_narzedzi { get; set; }
        public virtual DbSet<V_StanMagazynowyPodsumowanie> V_StanMagazynowyPodsumowanie { get; set; }
        public virtual DbSet<V_StanMagazynowyWydanie> V_StanMagazynowyWydanie { get; set; }
        public virtual DbSet<V_StanMagazynowyZwrot> V_StanMagazynowyZwrot { get; set; }
        public virtual DbSet<V_StanMaszyn> V_StanMaszyn { get; set; }
        public virtual DbSet<V_StanNarzedzi> V_StanNarzedzi { get; set; }
        public virtual DbSet<V_Statuspojazdow> V_Statuspojazdow { get; set; }
        public virtual DbSet<V_WplywySumaPerKlient> V_WplywySumaPerKlient { get; set; }
        public virtual DbSet<V_WplywySumaPerZamowienie> V_WplywySumaPerZamowienie { get; set; }
        public virtual DbSet<V_WydatkiSuma> V_WydatkiSuma { get; set; }
        public virtual DbSet<V_WynagrodzeniePracownika> V_WynagrodzeniePracownika { get; set; }
        public virtual DbSet<V_WyprodukowaneElementyDobre> V_WyprodukowaneElementyDobre { get; set; }
        public virtual DbSet<V_WyprodukowaneProduktyDobre> V_WyprodukowaneProduktyDobre { get; set; }
        public virtual DbSet<V_WyszukajPoStanowisku> V_WyszukajPoStanowisku { get; set; }
        public virtual DbSet<V_ZatrudnieniPracownicy> V_ZatrudnieniPracownicy { get; set; }
    }
}
