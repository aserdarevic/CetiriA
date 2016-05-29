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
    public sealed partial class PretragaKriminalaca : Page
    {
        public PretragaKriminalaca()
        {
            this.InitializeComponent();
        }
        int i = 0;
        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "" || textBox1.Text == "")
            {
                var dialog = new MessageDialog("Greška! Popunite obavezna polja.");
                dialog.ShowAsync();
            }

            else if (Sistem.kriminalci.Count==0)
            {
                var dialog = new MessageDialog("Greška! Baza je prazna");
                dialog.ShowAsync();
            }

            else
            {
                for (i = 0; i < Sistem.kriminalci.Count; i++)
                {
                    if (textBox.Text == Sistem.kriminalci[i].Ime && textBox1.Text == Sistem.kriminalci[i].Prezime)
                        Sistem.a = i;
                }
                this.Frame.Navigate(typeof(Profil));
            }
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
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
    }
}
