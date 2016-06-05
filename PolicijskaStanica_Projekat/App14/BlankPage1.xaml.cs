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
    public sealed partial class BlankPage1 : Page
    {
        public BlankPage1()
        {
            this.InitializeComponent();
        }

        private void textBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Sistem.c = -1;
            this.Frame.Navigate(typeof(MainPage));
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(UnesiKriminalca));
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PretragaKriminalaca));
        }

        private void button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(UrediKriminalca));
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PretragaSlužbenika));

        }

        private void button1_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DodjelaZadatka));
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(VidiZadatke));
        }

        private void button_Copy3_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(UnesiPolicajca));
        }

        private void button_Copy3_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PogledajPrijave));
        }
    }
}
