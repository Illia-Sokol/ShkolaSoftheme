using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using WcfRestServiceContracts;
using WCFServiceClient.ServiceReference;

namespace WCFServiceClient
{
    /// <summary>
    /// Before starting test WCF client, services should be runned 
    /// </summary>
    class Program
    {
        static void Main()
        {
            //var defaultWcfServiceClient = new DefaultWcfServiceClient();
            //var getDataResult = defaultWcfServiceClient.GetData(88);
            //Console.WriteLine("DefaultWcfServiceClient GetDataResult:{0}", getDataResult);
            //Console.WriteLine("DefaultWcfServiceClient GetDataResult:{0}", getDataResult);

            using (var channelFactory = new ChannelFactory<IService>(new WebHttpBinding(), "http://localhost:8000"))
            {
                channelFactory.Endpoint.Behaviors.Add(new WebHttpBehavior());
                var channel = channelFactory.CreateChannel();
            
                var getResult = channel.EchoWithGet("Hello from service client using GET");
                var postResult = channel.EchoWithPost("Hello from service client using POST");

                var postResult1 = channel.EchoWithPostComplexType(new DerivedComplexType
                                                                  {
                                                                      ComplexTypeStringValue = 1.ToString(),
                                                                      DerivedComplexTypeStringValue = 2.ToString()
                                                                  });

                Console.WriteLine(getResult);
                Console.WriteLine(postResult);
                Console.WriteLine(postResult1);
            }
        }
    }
}
