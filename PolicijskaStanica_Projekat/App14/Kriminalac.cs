using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App14
{
     public class Kriminalac
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string DatumRodjena { get; set; }
        public string Prebivaliste { get; set; }
        public string JMBG { get; set; }
        public string BrojLicneKarte { get; set; }
        public string OpisKrivicnogDjela { get; set; }
       

        public Kriminalac (string ime, string prezime, string datum, string prebivaliste, string jmbg, string karta, string opis)
        {
            Ime = ime;
            Prezime = prezime;
            DatumRodjena = datum;
            Prebivaliste = prebivaliste;
            JMBG = jmbg;
            BrojLicneKarte = karta;
            OpisKrivicnogDjela = opis;
        }
    }
}
