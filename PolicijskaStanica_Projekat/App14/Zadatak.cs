using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App14
{
    public class Zadatak
    {
        private string ImeZadatka;
        private string Lokacija;
        private string OpisZadatka;
        private DateTime Datum;
        
        public void PostaviImeZadatka(string ime) { ImeZadatka = ime; }
        public void PostaviLokaciju(string ime) { Lokacija = ime; }
        public void PostaviOpisZadatka(string ime) { OpisZadatka = ime; }

        public string DajImeZadatka() { return ImeZadatka; }
        public string DajLokaciju() { return Lokacija; }
        public string DajOpisZadatka() { return OpisZadatka; }

        public  Zadatak(string ime, string lokacija, string opis)
        {
            ImeZadatka = ime;
            Lokacija = lokacija;
            OpisZadatka = opis;
        }

    }
}
