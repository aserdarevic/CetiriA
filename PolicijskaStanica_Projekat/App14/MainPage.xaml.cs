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
            //Sistem.korisnici.Add(new Gradjanin("admin", "admin", "admin", "admin"));
            int p = 0;
            if (textBox.Text == "admin" ||  textBox2.PasswordChar == "admin")
            {
                Sistem.e = 1;
                Sistem.b = -1;
                Sistem.c = -1;

                p = 1;
                this.Frame.Navigate(typeof(Admin));
            }

            /*Sistem.korisnici.Add(new Korisnik("Amar", "Lubovac", "alubovac1","ssarajevo"));
            Sistem.korisnici.Add(new Korisnik("Alija", "Kusur", "alubovac2", "stuzla"));
            Sistem.korisnici.Add(new Korisnik("Anes", "Lozic", "alubovac3", "gmostar"));
            Sistem.korisnici.Add(new Korisnik("Ahmed", "Serdarevic","alubovac4", "gbec"));*/

            int r = 0;
                if (textBox.Text=="" || textBox2.PasswordChar=="")
            {
                var dialog = new MessageDialog("Greška! Popunite obavezna polja. Ukoliko nemate korisnički račun potrebno je da se registrujete.");
                dialog.ShowAsync();
                r = 1;
            } 
            
           
            for (int i = 0; i < Sistem.korisnici.Count; i++)
            {
                
                if (Sistem.korisnici[i].DajUsername()==textBox.Text && Sistem.korisnici[i].DajPassword()==textBox2.PasswordChar && Sistem.korisnici[i].DajBrojZnacke()=="")
                {
                    Sistem.b = i;
                    Sistem.e = 0;
                    p = 1;
                    this.Frame.Navigate(typeof(BlankPage2));
                    
                }

            }

            for (int i = 0; i < Sistem.sluzbenici.Count; i++)
            {
                if (Sistem.sluzbenici[i].DajUsername() == textBox.Text && Sistem.sluzbenici[i].DajPassword() == textBox2.PasswordChar)
                {   
                   
                    {
                        Sistem.c = i;
                        Sistem.b = -1;
                        Sistem.e = 0;
                        p = 1;
                        this.Frame.Navigate(typeof(BlankPage1));
                    }
                }
            }

            if (p == 0 && r!=1)
            {
                var dialog = new MessageDialog("Greška! Netačan username ili password.");
                dialog.ShowAsync();
            }



        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Registracija));
        }

        
    }
}
