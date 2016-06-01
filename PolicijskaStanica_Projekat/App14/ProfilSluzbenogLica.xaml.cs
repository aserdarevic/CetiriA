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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App14
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ProfilSluzbenogLica : Page
    {
        public ProfilSluzbenogLica()
        {
            this.InitializeComponent();
        }

       

        private void textBox1_Loaded(object sender, RoutedEventArgs e)
        {
            textBox1.Text = Sistem.sluzbenici[Sistem.d].DajIme();
            textBox2.Text = Sistem.sluzbenici[Sistem.d].DajPrezime();
            textBox3.Text = Sistem.sluzbenici[Sistem.d].DajDatumRodjenja();
            textBox4.Text = Sistem.sluzbenici[Sistem.d].DajCin();
            textBox5.Text = Sistem.sluzbenici[Sistem.d].DajRadnuJedinicu();
            textBox6.Text = Sistem.sluzbenici[Sistem.d].DajGodineIskustva().ToString();
            textBox1.Text = Sistem.sluzbenici[Sistem.d].DajKvalifikacije();
            var textbox = (TextBox)sender;
            textbox.IsEnabled = false;
        }

        private void textBox3_Loaded(object sender, RoutedEventArgs e)
        {
            var textbox = (TextBox)sender;
            textbox.IsEnabled = false;
        }
        private void textBox2_Loaded(object sender, RoutedEventArgs e)
        {
            var textbox = (TextBox)sender;
            textbox.IsEnabled = false;

        }

        private void textBox4_Loaded(object sender, RoutedEventArgs e)
        {
            var textbox = (TextBox)sender;
            textbox.IsEnabled = false;
        }

        private void textBox5_Loaded(object sender, RoutedEventArgs e)
        {
            var textbox = (TextBox)sender;
            textbox.IsEnabled = false;
        }

        private void textBox6_Loaded(object sender, RoutedEventArgs e)
        {
            var textbox = (TextBox)sender;
            textbox.IsEnabled = false;
        }

        private void textBox7_Loaded(object sender, RoutedEventArgs e)
        {
            var textbox = (TextBox)sender;
            textbox.IsEnabled = false;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BlankPage2));
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PretragaKriminalaca));
        }
    }
}
