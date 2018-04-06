using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace WcfRestServiceContracts
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        [WebGet(UriTemplate = "/EchoWithGet?value={value}",
                BodyStyle = WebMessageBodyStyle.Bare,
                ResponseFormat = WebMessageFormat.Xml)]
        string EchoWithGet(string value);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/EchoWithPost",
                   BodyStyle = WebMessageBodyStyle.Bare,
                   ResponseFormat = WebMessageFormat.Xml,
                   RequestFormat = WebMessageFormat.Xml)]
        string EchoWithPost(string value);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/EchoWithPostComplexType",
                   BodyStyle = WebMessageBodyStyle.Bare,
                   ResponseFormat = WebMessageFormat.Xml,
                   RequestFormat = WebMessageFormat.Xml)]
        string EchoWithPostComplexType(ComplexType value);
    }

    [DataContract]
    [KnownType(typeof(DerivedComplexType))]
    public class ComplexType
    {
        [DataMember]
        public string ComplexTypeStringValue { get; set; }
    }

    [DataContract]
    public class DerivedComplexType : ComplexType
    {
        [DataMember]
        public string DerivedComplexTypeStringValue { get; set; }
    }
}