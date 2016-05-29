using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App14
{
    public class KrivicnoDjelo
    {
        public string Lokacija { get; set; }
        public string Opis { get; set; }

        public KrivicnoDjelo(string lokacija, string opis)
        {
            Lokacija = lokacija;
            Opis = opis;
        }
    }
}
