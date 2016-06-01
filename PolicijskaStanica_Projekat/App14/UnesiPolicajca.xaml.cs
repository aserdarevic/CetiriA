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
    public sealed partial class UnesiPolicajca : Page
    {
        public UnesiPolicajca()
        {
            this.InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Sistem.sluzbenici.Add(new SluzbenaOsoba(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text));
        
            var dialog = new MessageDialog("Uspješno je dodan novi profil.");
            dialog.ShowAsync();
            
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            if (Sistem.e == 1)
            {
                this.Frame.Navigate(typeof(Admin));
            }
            else
                this.Frame.Navigate(typeof(BlankPage1));
        }

        
    }
}
