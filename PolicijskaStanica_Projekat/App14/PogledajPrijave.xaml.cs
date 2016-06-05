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
    public sealed partial class PogledajPrijave : Page
    {
        public PogledajPrijave()
        {
            this.InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (Sistem.e == 1)
            {
                this.Frame.Navigate(typeof(Admin));
            }
            else
                this.Frame.Navigate(typeof(BlankPage1));
        }

        private void textBox_Loaded(object sender, RoutedEventArgs e)
        {
            textBox.IsReadOnly = true;

            int i;
            string a, b, d;
            if (Sistem.krivicnaDjela.Count == 0)
            {
                var dialog = new MessageDialog("Nema prijava.");
                dialog.ShowAsync();
            }
            else
            {

                for (i = Sistem.krivicnaDjela.Count - 1; i >= 0; i--)
                {
                    a = Sistem.krivicnaDjela[i].DajLokaciju();
                    b = Sistem.krivicnaDjela[i].DajOpis();
    
                    d = "Lokacija: " + a + "\n" + "Opis krivičnog djela: " + b + "\n\n\n";
                    textBox.Text = textBox.Text + d;

                }

                
  
            }

        }
    }
}
