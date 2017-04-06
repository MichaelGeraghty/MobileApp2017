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
    public sealed partial class View4 : Page
    {
        public View4()
        {
            this.InitializeComponent();
        }

        private async void btn1_Tapped_1(object sender, TappedRoutedEventArgs e)
        {

            MediaElement clip = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("admiralbulldog bottom lane.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            clip.SetSource(stream, file.ContentType);
            clip.Play();
        }

        private async void btn2_Tapped_2(object sender, TappedRoutedEventArgs e)
        {
            MediaElement clip = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("double rapier double gem.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            clip.SetSource(stream, file.ContentType);
            clip.Play();
        }

        private async void btn3_Tapped_3(object sender, TappedRoutedEventArgs e)
        {
            MediaElement clip = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("instantly natures prophet.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            clip.SetSource(stream, file.ContentType);
            clip.Play();
        }

        private async void btn4_Tapped_4(object sender, TappedRoutedEventArgs e)
        {
            MediaElement clip = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("it is an illusion wot wot.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            clip.SetSource(stream, file.ContentType);
            clip.Play();
        }

        private async void btn5_Tapped_5(object sender, TappedRoutedEventArgs e)
        {
            MediaElement clip = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("its a disaster short.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            clip.SetSource(stream, file.ContentType);
            clip.Play();
        }

        private async void btn6_Tapped_6(object sender, TappedRoutedEventArgs e)
        {
            MediaElement clip = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("long its a disaster.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            clip.SetSource(stream, file.ContentType);
            clip.Play();
        }

        private async void btn7_Tapped_7(object sender, TappedRoutedEventArgs e)
        {
            MediaElement clip = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("make some noise.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            clip.SetSource(stream, file.ContentType);
            clip.Play();
        }

        private async void btn8_Tapped_8(object sender, TappedRoutedEventArgs e)
        {
            MediaElement clip = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("NO ONE HAS EVER DONE THAT.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            clip.SetSource(stream, file.ContentType);
            clip.Play();
        }

        private async void btn9_Tapped_9(object sender, TappedRoutedEventArgs e)
        {
            MediaElement clip = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("playing the ultimate rat.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            clip.SetSource(stream, file.ContentType);
            clip.Play();
        }

        private async void btn10_Tapped_10(object sender, TappedRoutedEventArgs e)
        {
            MediaElement clip = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("straight for the buildings.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            clip.SetSource(stream, file.ContentType);
            clip.Play();
        }

        private async void btn11_Tapped_11(object sender, TappedRoutedEventArgs e)
        {
            MediaElement clip = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("theres a hook.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            clip.SetSource(stream, file.ContentType);
            clip.Play();
        }

        private async void btn12_Tapped_12(object sender, TappedRoutedEventArgs e)
        {
            MediaElement clip = new MediaElement();
            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("waow.mp3");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            clip.SetSource(stream, file.ContentType);
            clip.Play();
        }
    }
}
