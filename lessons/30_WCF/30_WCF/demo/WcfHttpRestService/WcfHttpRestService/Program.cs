using System;
using System.ServiceModel;
using System.ServiceModel.Web;
using WcfRestServiceContracts;
using WcfRestServiceImplementation;

namespace WcfHttpRestService
{
    class Program
    {
        /// <summary>
        /// To check service running: http://localhost:8000/EchoWithGet?value=Hello
        /// </summary>
        static void Main()
        {
            var host = new WebServiceHost(typeof(Service), new Uri("http://localhost:8000/"));
            host.AddServiceEndpoint(typeof(IService), new WebHttpBinding(), "");

            host.Open();

            Console.WriteLine("Service is running");
            Console.WriteLine("Press enter to quit...");
            Console.ReadLine();

            host.Close();
        }
    }
}
