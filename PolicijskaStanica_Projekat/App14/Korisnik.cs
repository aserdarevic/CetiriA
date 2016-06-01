using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App14
{
    public abstract class Korisnik
    {
        private string Ime;
        private string Prezime;
        private string Username;
        private string Password;
        private string DatumRodjenja;

        /*public Korisnik (string ime, string prezime, string user, string pass)
        {
            Ime = ime;
            Prezime = prezime;
            Username = user;
            Password = pass;
        }*/

        abstract public string DajBrojZnacke();
        public string DajIme () { return Ime; }
        public string DajPrezime() { return Prezime; }
        public string DajUsername() { return Username; }
        public string DajPassword() { return Password; }
        public string DajDatumRodjenja() { return DatumRodjenja; }

        public void PostaviIme(string a) { Ime = a; }
        public void PostaviPrezime(string a) { Prezime = a; }
        public void PostaviUsername(string a) { Username = a; }
        public void PostaviPassword(string a) { Password = a; }
        public void PostaviDatumRodjenja(string a) { DatumRodjenja = a; }
    }
    }

