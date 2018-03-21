using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;

namespace ISerializable
{
    public static class Test
    {
        static void Main()
        {
            // This is the name of the file holding the data. You can use any file extension you like.
            string fileName = "dataStuff.myData";

            // Use a BinaryFormatter or SoapFormatter.
            //IFormatter formatter = new BinaryFormatter();
            IFormatter formatter = new SoapFormatter();

            Test.SerializeItem(fileName, formatter); // Serialize an instance of the class.
            Test.DeserializeItem(fileName, formatter); // Deserialize the instance.
            Console.WriteLine("Done");
            Console.ReadLine();
        }

        public static void SerializeItem(string fileName, IFormatter formatter)
        {
            // Create an instance of the type and serialize it.
            MyItemType t = new MyItemType();
            t.MyProperty = "Hello World";

            FileStream s = new FileStream(fileName, FileMode.Create);
            formatter.Serialize(s, t);
            s.Close();
        }


        public static void DeserializeItem(string fileName, IFormatter formatter)
        {
            FileStream s = new FileStream(fileName, FileMode.Open);
            MyItemType t = (MyItemType)formatter.Deserialize(s);
            Console.WriteLine(t.MyProperty);
        }
    }
}