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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Dota2SB
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            //initialize
            this.InitializeComponent();
        }
        //Navigates to selected page once button is tapped
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(View1));
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(View2));
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(View3));
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(View4));
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(View5));
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(View6));
        }
    }
}
