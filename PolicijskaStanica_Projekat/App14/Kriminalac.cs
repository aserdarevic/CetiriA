using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App14
{
     public class Kriminalac
    {
        private string Ime;
        private string Prezime;
        private string DatumRodjena;
        private string Prebivaliste;
        private string JMBG;
        private string BrojLicneKarte;
        private string OpisKrivicnogDjela;
       

        public Kriminalac (string ime, string prezime, string datum, string prebivaliste, string jmbg, string karta, string opis)
        {
            PostaviIme(ime);
            PostaviPrezime(prezime);
            PostaviDatumRodjenja(datum);
            PostaviPrebivaliste(prebivaliste);
            PostaviJMBG(jmbg);
            PostaviBrojLicneKarte(karta);
            PostaviOpisKrivicnogDjela(opis);
            /*Ime = ime;
            Prezime = prezime;
            DatumRodjena = datum;
            Prebivaliste = prebivaliste;
            JMBG = jmbg;
            BrojLicneKarte = karta;
            OpisKrivicnogDjela = opis;*/
        }

        public string DajIme() { return Ime; }
        public string DajPrezime() { return Prezime; }
        public string DajDatumRodjenja() { return DatumRodjena; }
        public string DajPrebivaliste() { return Prebivaliste; }
        public string DajJMBG() { return JMBG; }
        public string DajBrojLicneKarte() { return BrojLicneKarte; }
        public string DajOpisKrivicnogDjela() { return OpisKrivicnogDjela; }

        public void PostaviIme(string a) { Ime = a; }
        public void PostaviPrezime(string a) { Prezime = a; }
        public void PostaviDatumRodjenja(string a) { DatumRodjena = a; }
        public void PostaviPrebivaliste(string a) { Prebivaliste = a; }
        public void PostaviJMBG(string a) { JMBG = a; }
        public void PostaviBrojLicneKarte(string a) { BrojLicneKarte = a; }
        public void PostaviOpisKrivicnogDjela(string a) { OpisKrivicnogDjela = a; }

    }
}
