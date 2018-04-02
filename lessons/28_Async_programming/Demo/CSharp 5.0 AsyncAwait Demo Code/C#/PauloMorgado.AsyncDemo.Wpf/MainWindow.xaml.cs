using PauloMorgado.AsyncDemo.Wpf.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PauloMorgado.AsyncDemo.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //private void HandleLoadButtonClick(object sender, RoutedEventArgs e)
        //{
        //}

        #region Sync WebClient
        //private void HandleLoadButtonClick(object sender, RoutedEventArgs e)
        //{
        //    try
        //    {
        //        this.loadButton.Visibility = Visibility.Collapsed;
        //        this.progressBar.Visibility = Visibility.Visible;
        //        this.image.Source = null;
        //
        //        var image = this.LoadImage();
        //
        //        if (image != null)
        //        {
        //            this.image.Width = image.Width;
        //            this.image.Height = image.Height;
        //
        //            this.image.Source = image;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, string.Format("Unexpected error: {0}", ex.GetType().Name), MessageBoxButton.OK, MessageBoxImage.Error);
        //    }
        //    finally
        //    {
        //        this.loadButton.Visibility = Visibility.Visible;
        //        this.progressBar.Visibility = Visibility.Collapsed;
        //    }
        //}
        //
        //private BitmapFrame LoadImage()
        //{
        //    var webClient = new WebClient();
        //    var imageData = webClient.DownloadData(Properties.Settings.Default.ImageUrl);
        //
        //    if (imageData != null)
        //    {
        //        using (var memoryStream = new MemoryStream(imageData))
        //        {
        //            return BitmapFrame.Create(
        //                memoryStream,
        //                BitmapCreateOptions.None,
        //                BitmapCacheOption.OnLoad);
        //        }
        //    }
        //
        //    return null;
        //}
        #endregion

        #region Async WebClient
        private async void HandleLoadButtonClick(object sender, EventArgs e)
        {
            try
            {
                this.loadButton.Visibility = Visibility.Collapsed;
                this.progressBar.Visibility = Visibility.Visible;
                this.image.Source = null;

                var image = await this.LoadImageAsync();

                if (image != null)
                {
                    this.image.Width = image.Width;
                    this.image.Height = image.Height;

                    this.image.Source = image;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, string.Format("Unexpected error: {0}", ex.GetType().Name), MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                this.loadButton.Visibility = Visibility.Visible;
                this.progressBar.Visibility = Visibility.Collapsed;
            }
        }

        private async Task<BitmapFrame> LoadImageAsync()
        {
            var imageData = await new WebClient().DownloadDataTaskAsync(Settings.Default.ImageUrl);

            if (imageData != null)
            {
                using (var memoryStream = new MemoryStream(imageData))
                {
                    return BitmapFrame.Create(
                        memoryStream,
                        BitmapCreateOptions.None,
                        BitmapCacheOption.OnLoad);
                }
            }

            return null;
        }
        #endregion

        #region Async deadlock
        //private void HandleLoadButtonClick(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.loadButton.Visibility = Visibility.Collapsed;
        //        this.progressBar.Visibility = Visibility.Visible;
        //        this.image.Source = null;

        //        var image = this.LoadImageAsync().Result;

        //        if (image != null)
        //        {
        //            this.image.Width = image.Width;
        //            this.image.Height = image.Height;

        //            this.image.Source = image;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, string.Format("Unexpected error: {0}", ex.GetType().Name), MessageBoxButton.OK, MessageBoxImage.Error);
        //    }
        //    finally
        //    {
        //        this.loadButton.Visibility = Visibility.Visible;
        //        this.progressBar.Visibility = Visibility.Collapsed;
        //    }
        //}

        //private async Task<BitmapFrame> LoadImageAsync()
        //{
        //    var imageData = await new WebClient().DownloadDataTaskAsync(Settings.Default.ImageUrl);

        //    if (imageData != null)
        //    {
        //        using (var memoryStream = new MemoryStream(imageData))
        //        {
        //            return BitmapFrame.Create(
        //                memoryStream,
        //                BitmapCreateOptions.None,
        //                BitmapCacheOption.OnLoad);
        //        }
        //    }

        //    return null;
        //}
        #endregion

        #region Async HttpClient with cancelation
        //private async void HandleLoadButtonClick(object sender, RoutedEventArgs e)
        //{
        //    try
        //    {
        //        this.loadButton.Visibility = Visibility.Collapsed;
        //        this.cancelButton.Visibility = Visibility.Visible;
        //        this.progressBar.Visibility = Visibility.Visible;
        //        this.image.Source = null;

        //        var image = await this.LoadImageAsync();

        //        if (image != null)
        //        {
        //            this.image.Width = image.Width;
        //            this.image.Height = image.Height;

        //            this.image.Source = image;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, string.Format("Unexpected error: {0}", ex.GetType().Name), MessageBoxButton.OK, MessageBoxImage.Error);
        //    }
        //    finally
        //    {
        //        this.loadButton.Visibility = Visibility.Visible;
        //        this.cancelButton.Visibility = Visibility.Collapsed;
        //        this.progressBar.Visibility = Visibility.Collapsed;
        //    }
        //}

        //private async Task<BitmapFrame> LoadImageAsync()
        //{
        //    this.cancelationTokenSource = new CancellationTokenSource();

        //    try
        //    {
        //        var imageResponse = await new HttpClient()
        //            .GetAsync(Properties.Settings.Default.ImageUrl, cancelationTokenSource.Token)
        //            .ConfigureAwait(false);

        //        if (imageResponse != null)
        //        {
        //            var imageStream = await imageResponse.Content.ReadAsStreamAsync();

        //            return BitmapFrame.Create(
        //                imageStream,
        //                BitmapCreateOptions.None,
        //                BitmapCacheOption.OnLoad);
        //        }

        //    }
        //    catch (TaskCanceledException ex)
        //    {
        //    }

        //    return null;
        //}
        #endregion

        private CancellationTokenSource cancelationTokenSource;

        private void HandleCancelButtonClick(object sender, RoutedEventArgs e)
        {
            if (this.cancelationTokenSource != null)
            {
                this.cancelationTokenSource.Cancel();

                this.cancelationTokenSource.Dispose();

                this.cancelationTokenSource = null;
            }
        }
    }
}
