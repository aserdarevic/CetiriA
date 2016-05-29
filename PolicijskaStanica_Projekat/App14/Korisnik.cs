using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App14
{
    public abstract class Korisnik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        /*public Korisnik (string ime, string prezime, string user, string pass)
        {
            Ime = ime;
            Prezime = prezime;
            Username = user;
            Password = pass;
        }*/

        abstract public string DajBrojZnacke();
    }
    }

