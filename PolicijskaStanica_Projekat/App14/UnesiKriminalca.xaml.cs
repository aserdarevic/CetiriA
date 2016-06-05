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
    public sealed partial class UnesiKriminalca : Page
    {
        public UnesiKriminalca()
        {
            this.InitializeComponent();
        }

        bool IspravanJMBG(string a)
        {
            if (a.Count() != 13) return false;
            for (int i=0; i<13;i++)
            {
                if (a[i] < '0' || a[i] > '9') return false;
            }
            return true;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
            if (textBox1.Text == "" || textBox2.Text == "" || textBox7.Text == "")
            {
                var dialog = new MessageDialog("Greška! Popunite obavezna polja.");
                dialog.ShowAsync();
            }
            else if (IspravanJMBG(textBox5.Text)==false)
            {
                var dialog = new MessageDialog("Greška! Neispravno unesen JMBG");
                dialog.ShowAsync();

            }
            else
            {
                Sistem.kriminalci.Add(new Kriminalac(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text));
                this.Frame.Navigate(typeof(DodanDosije));
            }

        }
        
    }
}
