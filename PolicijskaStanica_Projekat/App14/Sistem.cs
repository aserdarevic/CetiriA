using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App14
{

    public class Sistem
    {
        internal static List<Gradjanin> korisnici = new List<Gradjanin>();
        internal static List<KrivicnoDjelo> krivicnaDjela = new List<KrivicnoDjelo>();
        internal static List<Kriminalac> kriminalci = new List<Kriminalac>();
        internal static List<SluzbenaOsoba> sluzbenici = new List<SluzbenaOsoba>();
        internal static int a; //trenutni kriminalac
        internal static int b; //trenutni korisnik
        internal static int c; //trenutni policajac
        internal static int d; //trenutni policajac koji nije ulogovan
        internal static int e=0; //da li je admin
  
    }
}
