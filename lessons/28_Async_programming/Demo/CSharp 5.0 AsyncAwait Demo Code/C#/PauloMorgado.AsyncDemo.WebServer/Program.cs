namespace PauloMorgado.AsyncDemo.WebServer
{
    using PauloMorgado.AsyncDemo.WebServer.Properties;
    using System;
    using System.IO;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Web.Http.SelfHost;

    class Program
    {
        static void Main(string[] args)
        {
            var config = new HttpSelfHostConfiguration(Settings.Default.ImageUrl);

            var handler = new ImageHttpMessageHandler(Settings.Default.ImageFilePath);

            using (var server = new HttpSelfHostServer(config, handler))
            {
                Console.WriteLine("Starting Web Server at {0}...", config.BaseAddress);

                server.OpenAsync().Wait();

                Console.WriteLine("Web Server Started. Press Enter to quit.");
                Console.ReadLine();

                Console.WriteLine("Stopping Web Server...");

                server.CloseAsync().Wait();

                Console.WriteLine("Web Server Stopped.");
            }
        }
    }

    class ImageHttpMessageHandler : HttpMessageHandler
    {
        private string imageFilePath;

        public ImageHttpMessageHandler(string imageFilePath)
        {
            this.imageFilePath = imageFilePath;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            try
            {
                Console.WriteLine("Serving Request...");

                var file = File.OpenRead(this.imageFilePath);

                var response = new HttpResponseMessage(HttpStatusCode.OK);
                response.Content = new StreamContent(file);
                response.Content.Headers.ContentType = new MediaTypeHeaderValue("image/png");

                await Task.Delay(5000);

                return response;
            }
            finally
            {
                Console.WriteLine("Request Served");
            }
        }
    }
}
