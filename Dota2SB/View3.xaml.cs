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
    public sealed partial class View3 : Page
    {
        public View3()
        {
            //initialize
            this.InitializeComponent();
        }
        //Tap events set to play the sound once pressed , will not stop previous sound from ending unless back button is pressed
        private async void btn1_Tapped_1(object sender, TappedRoutedEventArgs e)
        {

            MediaElement clip = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("alright you messed up.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            clip.SetSource(stream, file.ContentType);
            clip.Play();
        }

        private async void btn2_Tapped_2(object sender, TappedRoutedEventArgs e)
        {
            MediaElement clip = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("choosing not to farm.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            clip.SetSource(stream, file.ContentType);
            clip.Play();
        }

        private async void btn3_Tapped_3(object sender, TappedRoutedEventArgs e)
        {
            MediaElement clip = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("he hasnt done sht.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            clip.SetSource(stream, file.ContentType);
            clip.Play();
        }

        private async void btn4_Tapped_4(object sender, TappedRoutedEventArgs e)
        {
            MediaElement clip = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("huge mistake.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            clip.SetSource(stream, file.ContentType);
            clip.Play();
        }

        private async void btn5_Tapped_5(object sender, TappedRoutedEventArgs e)
        {
            MediaElement clip = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("i am gonna screw you.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            clip.SetSource(stream, file.ContentType);
            clip.Play();
        }

        private async void btn6_Tapped_6(object sender, TappedRoutedEventArgs e)
        {
            MediaElement clip = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("i have no idea.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            clip.SetSource(stream, file.ContentType);
            clip.Play();
        }

        private async void btn7_Tapped_7(object sender, TappedRoutedEventArgs e)
        {
            MediaElement clip = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("infinitely better.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            clip.SetSource(stream, file.ContentType);
            clip.Play();
        }

        private async void btn8_Tapped_8(object sender, TappedRoutedEventArgs e)
        {
            MediaElement clip = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("it is like league.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            clip.SetSource(stream, file.ContentType);
            clip.Play();
        }

        private async void btn9_Tapped_9(object sender, TappedRoutedEventArgs e)
        {
            MediaElement clip = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("it is not worth watching.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            clip.SetSource(stream, file.ContentType);
            clip.Play();
        }

        private async void btn10_Tapped_10(object sender, TappedRoutedEventArgs e)
        {
            MediaElement clip = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("not playing dota.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            clip.SetSource(stream, file.ContentType);
            clip.Play();
        }

        private async void btn11_Tapped_11(object sender, TappedRoutedEventArgs e)
        {
            MediaElement clip = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("oh no mistake.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            clip.SetSource(stream, file.ContentType);
            clip.Play();
        }

        private async void btn12_Tapped_12(object sender, TappedRoutedEventArgs e)
        {
            MediaElement clip = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("problem with 1k mmr players.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            clip.SetSource(stream, file.ContentType);
            clip.Play();
        }

        private async void btn13_Tapped_13(object sender, TappedRoutedEventArgs e)
        {
            MediaElement clip = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("right click.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            clip.SetSource(stream, file.ContentType);
            clip.Play();
        }

        private async void btn14_Tapped_14(object sender, TappedRoutedEventArgs e)
        {
            MediaElement clip = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("shit playstyle.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            clip.SetSource(stream, file.ContentType);
            clip.Play();
        }

        private async void btn15_Tapped_15(object sender, TappedRoutedEventArgs e)
        {
            MediaElement clip = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("that was a pretty big mistake.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            clip.SetSource(stream, file.ContentType);
            clip.Play();
        }

        private async void btn16_Tapped_16(object sender, TappedRoutedEventArgs e)
        {
            MediaElement clip = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("this game is not about you.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            clip.SetSource(stream, file.ContentType);
            clip.Play();
        }

        private async void btn17_Tapped_17(object sender, TappedRoutedEventArgs e)
        {
            MediaElement clip = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("time spent worthless.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            clip.SetSource(stream, file.ContentType);
            clip.Play();
        }

        private async void btn18_Tapped_18(object sender, TappedRoutedEventArgs e)
        {
            MediaElement clip = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("weak players.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            clip.SetSource(stream, file.ContentType);
            clip.Play();
        }

        private async void btn19_Tapped_19(object sender, TappedRoutedEventArgs e)
        {
            MediaElement clip = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("yellow this is purge 1.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            clip.SetSource(stream, file.ContentType);
            clip.Play();
        }

        private async void btn20_Tapped_20(object sender, TappedRoutedEventArgs e)
        {
            MediaElement clip = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("you dont understand.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            clip.SetSource(stream, file.ContentType);
            clip.Play();
        }
    }
}
