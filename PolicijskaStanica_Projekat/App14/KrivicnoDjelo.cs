using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App14
{
    public class KrivicnoDjelo
    {
        private string Lokacija { get; set; }
        private string Opis { get; set; }

        public KrivicnoDjelo(string lokacija, string opis)
        {
            Lokacija = lokacija;
            Opis = opis;
        }

        public void PostaviLokaciju(string a) { Lokacija = a; }
        public void PostaviOpis(string a) { Opis = a; }
        
        public string DajLokaciju() { return Lokacija; }
        public string DajOpis() { return Opis; }
    }
}
