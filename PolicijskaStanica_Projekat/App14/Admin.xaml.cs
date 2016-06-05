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
    public sealed partial class Admin : Page
    {
        public Admin()
        {
            this.InitializeComponent();
        }

       

        private void button_Copy3_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(UnesiPolicajca));
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
            Sistem.e = 0;
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DodjelaZadatka));
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DodjelaZadatka));
        }

        private void button1_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(UnesiPolicajca));
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PretragaKriminalaca));
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PretragaSlužbenika));
        }

        private void button1_Copy_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(UnesiPolicajca));
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PretragaSlužbenika));
        }

        private void button_Copy6_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PogledajPrijave));
        }

        private void button_Copy5_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(UrediKriminalca));
        }

        private void button_Copy4_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(UnesiKriminalca));
        }
    }
}
