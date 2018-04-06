using System.ServiceModel;

namespace DefaultWCFService
{
    [ServiceContract]
    public interface IDefaultWcfService
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);
    }
}
