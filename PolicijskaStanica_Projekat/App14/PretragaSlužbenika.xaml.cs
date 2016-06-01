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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App14
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PretragaSlužbenika : Page
    {
        public PretragaSlužbenika()
        {
            this.InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "" || textBox1.Text == "")
            {
                var dialog = new MessageDialog("Greška! Popunite obavezna polja.");
                dialog.ShowAsync();
            }

            else if (Sistem.sluzbenici.Count == 0)
            {
                var dialog = new MessageDialog("Greška! Baza je prazna");
                dialog.ShowAsync();
            }
            for (int i = 0; i < Sistem.sluzbenici.Count; i++)
            {


                if (textBox.Text == Sistem.sluzbenici[i].DajIme() && textBox1.Text == Sistem.sluzbenici[i].DajPrezime())
                {
                    Sistem.d = i;


                    if (Sistem.korisnici[Sistem.b].DajBrojZnacke() == "")
                    {

                        this.Frame.Navigate(typeof(ProfilSluzbenogLica));

                    }
                    else
                    {


                        this.Frame.Navigate(typeof(ProfilSluzbenogLica2));

                    }


                }

                else
                {
                    var dialog = new MessageDialog("Tražena osoba se ne nalazi u bazi.");
                    dialog.ShowAsync();
                }
            }

        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            if (Sistem.korisnici.Count != 0)
            {

                if (Sistem.korisnici[Sistem.b].DajBrojZnacke() == "")
                {

                    this.Frame.Navigate(typeof(BlankPage2));
                }

                else
                {
                    this.Frame.Navigate(typeof(BlankPage1));
                }
            }
            else this.Frame.Navigate(typeof(BlankPage1));
        }
    }
}
