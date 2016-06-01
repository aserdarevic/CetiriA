using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App14
{
    public class SluzbenaOsoba : Korisnik
    {
        private string DatumRodjenja;
        private string BrojZnacke;
        private string Cin;
        private string RadnaJedinica;
        private string GodineIskustva;
        private string Kvalifikacije;
        private string HistorijaZadataka;
       // private string RadnaJedinica;
        private List<Zadatak> zadaci = new List<Zadatak>();
        

       /* public SluzbenaOsoba(string ime, string prezime, string broj, string user, string pass)
        {
            PostaviIme(ime);
            PostaviPrezime(prezime);
            PostaviUsername(user);
            PostaviPassword(pass);
            PostaviBrojZnacke(broj);
           
        }*/

        public SluzbenaOsoba(string ime, string prezime, string datum,  string cin, string jedinica, string iskustvo, string broj, string klasifikacije, string historija)
        {
            PostaviIme(ime);
            PostaviPrezime(prezime);
            PostaviBrojZnacke(broj);
            PostaviCin(cin);
            PostaviGodineIskustva(iskustvo);
            PostaviRadnuJedinicu(jedinica);
            PostaviHistorijuZadataka(historija);
            PostaviKlasifikacije(klasifikacije);
            PostaviDatumRodjenja(datum);
              
        }



        public string DajCin() { return Cin; }
        public string DajRadnuJedinicu() { return RadnaJedinica; }
        public string DajGodineIskustva() { return GodineIskustva; }
        public string DajKvalifikacije() { return Kvalifikacije; }
        public string DajHistorijuZadataka() { return HistorijaZadataka; }

        public void PostaviCin(string a) { Cin = a; }
        public void PostaviRadnuJedinicu(string a) { RadnaJedinica = a; }
        public void PostaviGodineIskustva(string a) { GodineIskustva = a; }
        public void PostaviKlasifikacije(string a) { Kvalifikacije = a; }
        public void PostaviHistorijuZadataka(string a) { HistorijaZadataka = a; }
        public void PostaviBrojZnacke(string a) { BrojZnacke = a; }


        public void DodajZadatak(string ime, string lokacija, string opis)
        {
            zadaci.Add(new Zadatak(ime, lokacija, opis));
        }

        public List<Zadatak> DajZadatke()
        {
            return zadaci;
        }

        public override string DajBrojZnacke()
        {

            return BrojZnacke;
            }

    }
}
