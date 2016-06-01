using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App14
{
    
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            
        }




         //List<Korisnik> korisnici = new List<Korisnik>();

        Sistem sistem = new Sistem();
        
        
       
        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "admin" || textBox2.PasswordChar == "admin")
            {
                this.Frame.Navigate(typeof(Admin));
                Sistem.e = 1;
            }

                /*Sistem.korisnici.Add(new Korisnik("Amar", "Lubovac", "alubovac1","ssarajevo"));
                Sistem.korisnici.Add(new Korisnik("Alija", "Kusur", "alubovac2", "stuzla"));
                Sistem.korisnici.Add(new Korisnik("Anes", "Lozic", "alubovac3", "gmostar"));
                Sistem.korisnici.Add(new Korisnik("Ahmed", "Serdarevic","alubovac4", "gbec"));*/

                if (textBox.Text=="" || textBox2.PasswordChar=="")
            {
                var dialog = new MessageDialog("Greška! Popunite obavezna polja. Ukoliko nemate korisnički račun potrebno je da se registrujete.");
                dialog.ShowAsync();
            } 
            
            int p = 0;
            for (int i = 0; i < Sistem.korisnici.Count; i++)
            {
                
                if (Sistem.korisnici[i].DajUsername()==textBox.Text && Sistem.korisnici[i].DajPassword()==textBox2.PasswordChar && Sistem.korisnici[i].DajBrojZnacke()=="")
                {
                    Sistem.b = i;
                    this.Frame.Navigate(typeof(BlankPage2));
                    p = 1;
                }

            }

            for (int i = 0; i < Sistem.sluzbenici.Count; i++)
            {
                if (Sistem.sluzbenici[i].DajUsername() == textBox.Text && Sistem.sluzbenici[i].DajPassword() == textBox2.PasswordChar)
                {
                    Sistem.c = i;
                    this.Frame.Navigate(typeof(BlankPage1));
                    p = 1;
                }
            }
            //if (p == 0) this.Frame.Navigate(typeof(Greska));





            //string user = "ammarr96";
            //string pass = "sarajevo";

            //if (user.Equals(textBox.Text, StringComparison.Ordinal) && pass.Equals(textBox2.Text, StringComparison.Ordinal))

            //this.Frame.Navigate(typeof(BlankPage1));

            //else
            // this.Frame.Navigate(typeof(BlankPage2));

        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Registracija));
        }

        
    }
}
