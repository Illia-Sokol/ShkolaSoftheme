using WcfRestServiceContracts;

namespace WcfRestServiceImplementation
{
    public class Service : IService
    {
        public string EchoWithGet(string value)
        {
            return "You said " + value;
        }

        public string EchoWithPost(string value)
        {
            return "You said " + value;
        }

        public string EchoWithPostComplexType(ComplexType value)
        {
            return "EchoWithPostComplexType" + value.ComplexTypeStringValue;
        }
    }
}