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
using System.IO.IsolatedStorage;
using Windows.Storage;
using Windows.Storage.Streams;
using System.Threading.Tasks;
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Dota2SB
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class View6 : Page
    {
        const string TEXT_FILE_NAME = "SampleTextFile.txt";

        public View6()
        {
            this.InitializeComponent();
        }

        private async void readFile_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string str = await FileHelper.ReadTextFile(TEXT_FILE_NAME);
                textBlock.Text = str;
            }
            catch { string textFilePath = await FileHelper.WriteTextFile(TEXT_FILE_NAME, textBox.Text); }
           
            //var dialog = new MessageDialog("Enter Message First!");
            //await dialog.ShowAsync();

        }

        private async void writeFile_Click(object sender, RoutedEventArgs e)
        {
            string textFilePath = await FileHelper.WriteTextFile(TEXT_FILE_NAME, textBox.Text);
            //seemsgood.Visibility = Visibility.Collapsed;

        }
    }

    public static class FileHelper
    {

        // Write a text file to the app's local folder. 

        public static async Task<string>
           WriteTextFile(string filename, string contents)
        {

            StorageFolder localFolder = ApplicationData.Current.LocalFolder;
            StorageFile textFile = await localFolder.CreateFileAsync(filename,
               CreationCollisionOption.ReplaceExisting);

            using (IRandomAccessStream textStream = await
               textFile.OpenAsync(FileAccessMode.ReadWrite))
            {

                using (DataWriter textWriter = new DataWriter(textStream))
                {
                    textWriter.WriteString(contents);
                    await textWriter.StoreAsync();
                }
            }

            return textFile.Path;
        }
        // Read the contents of a text file from the app's local folder.

        public static async Task<string> ReadTextFile(string filename)
        {
            string contents;
            StorageFolder localFolder = ApplicationData.Current.LocalFolder;
            StorageFile textFile = await localFolder.GetFileAsync(filename);

            using (IRandomAccessStream textStream = await textFile.OpenReadAsync())
            {

                using (DataReader textReader = new DataReader(textStream))
                {
                    uint textLength = (uint)textStream.Size;
                    await textReader.LoadAsync(textLength);
                    contents = textReader.ReadString(textLength);
                }

            }

            return contents;
        }
    }
}
