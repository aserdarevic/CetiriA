using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App14
{
    public class Gradjanin : Korisnik
    {
        public Gradjanin(string ime, string prezime, string user, string pass)
        {
            PostaviIme(ime);
            PostaviPrezime(prezime);
            PostaviUsername(user);
            PostaviPassword(pass);

            /*Prezime = prezime;
            Username = user;
            Password = pass;*/
        }
        /*public Gradjanin(string ime, string prezime, string user, string pass) : base(ime, prezime, user, pass)
        {
        }*/
        public override string DajBrojZnacke()
        {
            string p = "";
            return p;
        }


    }
    }

