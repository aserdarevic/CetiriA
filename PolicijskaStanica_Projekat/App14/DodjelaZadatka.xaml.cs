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
    public sealed partial class DodjelaZadatka : Page
    {
        public DodjelaZadatka()
        {
            this.InitializeComponent();
        }
        

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int p = 0;

            for (int i=0;i<Sistem.sluzbenici.Count;i++)
            {
                if (Sistem.sluzbenici[i].DajBrojZnacke()==textBox5.Text)
                {
                    Sistem.sluzbenici[i].DodajZadatak(textBox2.Text, textBox3.Text, textBox4.Text);
                    p = 1;
                    var dialog = new MessageDialog("Zadatak je uspješno dodijeljen odgovarajućem službeniku.");
                    dialog.ShowAsync();
                }
                
            }
            if (p==0)
            {
                var dialog = new MessageDialog("Greška! Ne postoji službenik sa unesenim brojem značke.");
                dialog.ShowAsync();
            }
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            int r = 0;
            for (int i = 0; i < Sistem.sluzbenici.Count(); i++)
            {
                if (Sistem.sluzbenici[i].DajRadnuJedinicu() == textBox1.Text)
                {
                    Sistem.sluzbenici[i].DodajZadatak(textBox2.Text, textBox3.Text, textBox4.Text);
                    r = 1;

                    var dialog = new MessageDialog("Zadatak je uspješno dodijeljen odgovarajućoj Specijalnoj Jedinici.");
                    dialog.ShowAsync();
                }
                
            }
            if (r == 0)
            {
                var dialog = new MessageDialog("Greška! Ne postoji Specijalna Jedinica sa unesenim nazivom.");
                dialog.ShowAsync();
            }

        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BlankPage1));
        }
    }
}
