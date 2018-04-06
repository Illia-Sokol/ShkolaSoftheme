using System.Runtime.Serialization;

namespace DefaultWCFService
{
    [DataContract]
    public class DerivedCompositeType : CompositeType
    {
        int _intValue = 20;

        [DataMember]
        public int IntValue
        {
            get { return _intValue; }
            set { _intValue = value; }
        }
    }
}