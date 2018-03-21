using System.Runtime.Serialization;

namespace DataContractJsonSerializer
{
    [DataContract]
    internal class Person
    {
        [DataMember]
        internal string Name;

        [DataMember]
        internal int Age;
    }
}