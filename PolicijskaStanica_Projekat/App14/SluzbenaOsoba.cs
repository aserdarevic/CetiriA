using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App14
{
    public class SluzbenaOsoba : Korisnik
    {
        public string BrojZnacke { get; set; }
        /*public SluzbenaOsoba(string ime, string prezime,  string broj, string user, string pass) : base(ime, prezime, user, pass)
        {
            BrojZnacke = broj;
        }*/

        public SluzbenaOsoba(string ime, string prezime, string broj, string user, string pass)
        {
            Ime = ime;
            Prezime = prezime;
            Username = user;
            Password = pass;
            BrojZnacke = broj;
        }

        public override string DajBrojZnacke()
        {

            return BrojZnacke;
            }

    }
}
