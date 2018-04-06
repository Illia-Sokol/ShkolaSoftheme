using System.ServiceModel;
using System.ServiceModel.Web;
using System.Runtime.Serialization;

namespace httpServiceContract
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        [WebGet(UriTemplate = "/EchoGet?value={value}",
                BodyStyle = WebMessageBodyStyle.Bare,
                ResponseFormat = WebMessageFormat.Xml)]
        string EchoGet(string value);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/EchoPost",
                   BodyStyle = WebMessageBodyStyle.Bare,
                   ResponseFormat = WebMessageFormat.Xml,
                   RequestFormat = WebMessageFormat.Xml)]
        string EchoPost(string value);

    }
}
