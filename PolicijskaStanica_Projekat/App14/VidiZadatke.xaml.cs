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
    public sealed partial class VidiZadatke : Page
    {
        public VidiZadatke()
        {
            this.InitializeComponent();
        }



        private void textBox_Loaded(object sender, RoutedEventArgs e)
        {
            textBox.IsReadOnly = true;
            List<Zadatak> l = new List<Zadatak>();
            int i;
            string a, b, c, d;
            l = Sistem.sluzbenici[Sistem.c].DajZadatke();
            if (l.Count == 0)
            {
                var dialog = new MessageDialog("Nemate dodijeljenih zadataka.");
                dialog.ShowAsync();
            }
            else
            {

                for (i = l.Count - 1; i >= 0; i--)
                {
                    a = l[i].DajImeZadatka();
                    b = l[i].DajLokaciju();
                    c = l[i].DajOpisZadatka();
                    d = "Ime zadatka: " + a + "\n" + "Lokacija: " + b + "\n" + "Opis zadatka: " + c + "\n\n\n";
                    textBox.Text = textBox.Text + d;

                }

            }

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            this.Frame.Navigate(typeof(BlankPage1));
        }

        

     /*  private void scrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            nesto.Content = "VScrollBar Value:(OnScroll Event) " + e.NewValue.ToString();
        }*/

        private void ScrollViewer_Loaded(object sender, RoutedEventArgs e)
        {
            

            List<Zadatak> l = new List<Zadatak>();
            int i;
            string a, b, c, d;
            string f = "";
            l = Sistem.sluzbenici[Sistem.c].DajZadatke();
            if (l.Count == 0)
            {
                var dialog = new MessageDialog("Nemate dodijeljenih zadataka.");
                dialog.ShowAsync();
            }
            else
            {

                for (i = l.Count - 1; i >= 0; i--)
                {
                    a = l[i].DajImeZadatka();
                    b = l[i].DajLokaciju();
                    c = l[i].DajOpisZadatka();
                    d = "Ime zadatka: " + a + "\n" + "Lokacija: " + b + "\n" + "Opis zadatka: " + c + "\n\n\n";
                    f= f + d;

                    //nesto.Content = f;
                }
               

                
            }
        }
    }
}

