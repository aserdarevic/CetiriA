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
    public sealed partial class UrediKriminalca2 : Page
    {
        public UrediKriminalca2()
        {
            this.InitializeComponent();
        }

        private void textBox1_Loaded(object sender, RoutedEventArgs e)
        {
            textBox1.Text = Sistem.kriminalci[Sistem.a].Ime;
            textBox2.Text = Sistem.kriminalci[Sistem.a].Prezime;
            textBox3.Text = Sistem.kriminalci[Sistem.a].DatumRodjena;
            textBox4.Text = Sistem.kriminalci[Sistem.a].Prebivaliste;
            textBox5.Text = Sistem.kriminalci[Sistem.a].JMBG;
            textBox6.Text = Sistem.kriminalci[Sistem.a].BrojLicneKarte;
            textBox7.Text = Sistem.kriminalci[Sistem.a].OpisKrivicnogDjela;

            var textbox = (TextBox)sender;
            textbox.IsEnabled = false;
            
        }

        private void textBox2_Loaded(object sender, RoutedEventArgs e)
        {
            var textbox = (TextBox)sender;
            textbox.IsEnabled = false;
        }

        private void textBox3_Loaded(object sender, RoutedEventArgs e)
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
            this.Frame.Navigate(typeof(BlankPage1));
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (textBox8.Text.Length > 0) Sistem.kriminalci[Sistem.a].Ime = textBox8.Text;
            if (textBox9.Text.Length > 0) Sistem.kriminalci[Sistem.a].Prezime = textBox9.Text;
            if (textBox10.Text.Length > 0) Sistem.kriminalci[Sistem.a].DatumRodjena = textBox10.Text;
            if (textBox11.Text.Length > 0) Sistem.kriminalci[Sistem.a].Prebivaliste = textBox11.Text;
            if (textBox12.Text.Length > 0) Sistem.kriminalci[Sistem.a].JMBG = textBox12.Text;
            if (textBox13.Text.Length > 0) Sistem.kriminalci[Sistem.a].BrojLicneKarte = textBox13.Text;
            if (textBox14.Text.Length > 0) Sistem.kriminalci[Sistem.a].OpisKrivicnogDjela = textBox14.Text;

            var dialog = new MessageDialog("Promjene su spašene.");
            dialog.ShowAsync();
        }

        
    }
}
