using System;
using System.ServiceModel;
using System.ServiceModel.Web;
using httpServiceContract;
using httpServiceImplementation;

namespace httpService
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new WebServiceHost(typeof(Service), new Uri("http://localhost:8000/"));
            var binding = new WebHttpBinding();

            host.AddServiceEndpoint
        }
    }
}
