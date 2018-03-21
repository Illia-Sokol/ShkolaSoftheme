using System;
using System.Runtime.Serialization;

namespace ISerializable
{
    [Serializable]
    public class MyItemType : System.Runtime.Serialization.ISerializable
    {
        public MyItemType()
        {
            // Empty constructor required to compile.
        }

        // The value to serialize.
        private string myProperty_value;

        public string MyProperty
        {
            get { return myProperty_value; }
            set { myProperty_value = value; }
        }

        // Implement this method to serialize data. The method is called 
        // on serialization.
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            // Use the AddValue method to specify serialized values.
            info.AddValue("props", myProperty_value, typeof(string));

        }

        // The special constructor is used to deserialize values.
        public MyItemType(SerializationInfo info, StreamingContext context)
        {
            // Reset the property value using the GetValue method.
            myProperty_value = (string)info.GetValue("props", typeof(string));
        }
    }

    // This is a console application. 
}
