using PauloMorgado.AsyncDemo.WindowsForms.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PauloMorgado.AsyncDemo.WindowsForms
{
    public partial class AsyncDemoForm : Form
    {
        public AsyncDemoForm()
        {
            InitializeComponent();
        }

        private void HandleLoadButtonClick(object sender, EventArgs e)
        {
        }

        #region Sync WebClient
        //private void HandleLoadButtonClick(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.loadButton.Visible = false;
        //        this.progressBar.Visible = true;
        //        this.pictureBox.Image = null;

        //        var image = this.LoadImage();

        //        this.pictureBox.Image = image;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, string.Format("Unexpected error: {0}", ex.GetType().Name), MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        this.loadButton.Visible = true;
        //        this.progressBar.Visible = false;
        //    }
        //}

        //private Image LoadImage()
        //{
        //    var imageBytes = new WebClient().DownloadData(Settings.Default.ImageUrl);

        //    var image = Bitmap.FromStream(new MemoryStream(imageBytes));

        //    return image;
        //}
        #endregion

        #region Async WebClient
        //private async void HandleLoadButtonClick(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.loadButton.Visible = false;
        //        this.progressBar.Visible = true;
        //        this.pictureBox.Image = null;

        //        var image = await this.LoadImageAsync();

        //        this.pictureBox.Image = image;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, string.Format("Unexpected error: {0}", ex.GetType().Name), MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        this.loadButton.Visible = true;
        //        this.progressBar.Visible = false;
        //    }
        //}

        //private async Task<Image> LoadImageAsync()
        //{
        //    var imageBytes = await new WebClient().DownloadDataTaskAsync(Settings.Default.ImageUrl);

        //    var image = Bitmap.FromStream(new MemoryStream(imageBytes));

        //    return image;
        //}
        #endregion

        #region Async deadlock
        //private void HandleLoadButtonClick(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.loadButton.Visible = false;
        //        this.progressBar.Visible = true;
        //        this.pictureBox.Image = null;

        //        var image = this.LoadImageAsync().Result;

        //        this.pictureBox.Image = image;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, string.Format("Unexpected error: {0}", ex.GetType().Name), MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        this.loadButton.Visible = true;
        //        this.progressBar.Visible = false;
        //    }
        //}

        //private async Task<Image> LoadImageAsync()
        //{
        //    var imageBytes = await new WebClient().DownloadDataTaskAsync(Settings.Default.ImageUrl);

        //    var image = Bitmap.FromStream(new MemoryStream(imageBytes));

        //    return image;
        //}
        #endregion

        #region Async HttpClient with cancelation
        //private async void HandleLoadButtonClick(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.loadButton.Visible = false;
        //        this.progressBar.Visible = true;
        //        this.cancelButton.Visible = true;
        //        this.pictureBox.Image = null;

        //        var image = await this.LoadImageAsync();

        //        this.pictureBox.Image = image;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, string.Format("Unexpected error: {0}", ex.GetType().Name), MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        this.loadButton.Visible = true;
        //        this.progressBar.Visible = false;
        //        this.cancelButton.Visible = false;
        //    }
        //}

        //private async Task<Image> LoadImageAsync()
        //{
        //    Image image = null;

        //    try
        //    {
        //        this.cancelationTokenSource = new CancellationTokenSource();
        //        var imageResponse = await new HttpClient()
        //            .GetAsync(Settings.Default.ImageUrl, cancelationTokenSource.Token)
        //            .ConfigureAwait(false);

        //        if (imageResponse != null)
        //        {
        //            var imageStream = await imageResponse.Content.ReadAsStreamAsync();

        //            image = Bitmap.FromStream(imageStream);
        //        }
        //    }
        //    catch (TaskCanceledException ex)
        //    {
        //    }

        //    return image;
        //}
        #endregion

        private CancellationTokenSource cancelationTokenSource;

        private void HandleCancelButtonClick(object sender, EventArgs e)
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
