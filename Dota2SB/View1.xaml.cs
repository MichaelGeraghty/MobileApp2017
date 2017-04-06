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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Dota2SB
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class View1 : Page
    {
        public View1()
        {
            this.InitializeComponent();
        }

        private async void btn1_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            
            MediaElement clip = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Get Out.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            clip.SetSource(stream, file.ContentType);
            clip.Play();
        }

        private async void btn2_Tapped_2(object sender, TappedRoutedEventArgs e)
        {
            MediaElement clip = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Defend the Base.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            clip.SetSource(stream, file.ContentType);
            clip.Play();
        }

        private async void btn3_Tapped_3(object sender, TappedRoutedEventArgs e)
        {
            MediaElement clip = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("El Grande Dongerino.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            clip.SetSource(stream, file.ContentType);
            clip.Play();
        }

        private async void btn4_Tapped_4(object sender, TappedRoutedEventArgs e)
        {
            MediaElement clip = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Fucking Idiot.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            clip.SetSource(stream, file.ContentType);
            clip.Play();
        }

        private async void btn5_Tapped_5(object sender, TappedRoutedEventArgs e)
        {
            MediaElement clip = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Im Panicking.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            clip.SetSource(stream, file.ContentType);
            clip.Play();
        }

        private async void btn6_Tapped_6(object sender, TappedRoutedEventArgs e)
        {
            MediaElement clip = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Im Ratting Boys.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            clip.SetSource(stream, file.ContentType);
            clip.Play();
        }

        private async void btn7_Tapped_7(object sender, TappedRoutedEventArgs e)
        {
            MediaElement clip = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Its a Trap.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            clip.SetSource(stream, file.ContentType);
            clip.Play();
        }

        private async void btn8_Tapped_8(object sender, TappedRoutedEventArgs e)
        {
            MediaElement clip = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("NotLikeThis.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            clip.SetSource(stream, file.ContentType);
            clip.Play();
        }

        private async void btn9_Tapped_9(object sender, TappedRoutedEventArgs e)
        {
            MediaElement clip = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Oh the Jukes.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            clip.SetSource(stream, file.ContentType);
            clip.Play();
        }

        private async void btn10_Tapped_10(object sender, TappedRoutedEventArgs e)
        {
            MediaElement clip = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Please Sir Help me.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            clip.SetSource(stream, file.ContentType);
            clip.Play();
        }

        private async void btn11_Tapped_11(object sender, TappedRoutedEventArgs e)
        {
            MediaElement clip = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Run Alfredo.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            clip.SetSource(stream, file.ContentType);
            clip.Play();
        }

        private async void btn12_Tapped_12(object sender, TappedRoutedEventArgs e)
        {
            MediaElement clip = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Unlimited Power.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            clip.SetSource(stream, file.ContentType);
            clip.Play();
        }

        private async void btn13_Tapped_13(object sender, TappedRoutedEventArgs e)
        {
            MediaElement clip = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Use your Spells.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            clip.SetSource(stream, file.ContentType);
            clip.Play();
        }

        private async void btn14_Tapped_14(object sender, TappedRoutedEventArgs e)
        {
            MediaElement clip = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("Yohoooo.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            clip.SetSource(stream, file.ContentType);
            clip.Play();
        }

        private async void btn15_Tapped_15(object sender, TappedRoutedEventArgs e)
        {
            MediaElement clip = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("You Underestimate my Power.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            clip.SetSource(stream, file.ContentType);
            clip.Play();
        }
    }
}
