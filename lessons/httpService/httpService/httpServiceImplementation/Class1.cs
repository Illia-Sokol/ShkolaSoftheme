
using httpServiceContract;

namespace httpServiceImplementation
{
    public class Service : IService
    {
        public string EchoGet(string value)
        {
            return "You said " + value;
        }

        public string EchoPost(string value)
        {
            return "You said " + value;
        }
    }
}
