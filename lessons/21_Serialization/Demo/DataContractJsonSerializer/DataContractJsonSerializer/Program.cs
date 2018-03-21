using System;
using System.IO;

namespace DataContractJsonSerializer
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "John";
            p.Age = 42;
            
            //serialization 
            MemoryStream stream1 = new MemoryStream();
            var ser = new System.Runtime.Serialization.Json.DataContractJsonSerializer(typeof(Person));

            ser.WriteObject(stream1, p);

            stream1.Position = 0;
            StreamReader sr = new StreamReader(stream1);
            Console.Write("JSON form of Person object: ");
            Console.WriteLine(sr.ReadToEnd());


            //deserialization
            stream1.Position = 0;
            Person p2 = (Person)ser.ReadObject(stream1);

            Console.Write("Deserialized back, Person name: {0}, age: {1}", p2.Name, p2.Age);

            Console.ReadKey();
        }
    }
}
