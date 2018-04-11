using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace _02_Reflection
{
    class Program
    {
        static void Main()
        {
            Assembly assembly = null;
            try
            {
                assembly = Assembly.LoadFrom(@"..\..\..\TestLibrary\bin\Debug\TestLibrary.dll");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (assembly != null)
            {
                CreateBinding(assembly);
            }

            Console.ReadLine();
        }

        static void CreateBinding(Assembly a)
        {
            try
            {
                Type testClassType = a.GetExportedTypes().First(x => x.Name.Equals("TestClass"));

                object instance = Activator.CreateInstance(testClassType);
                Console.WriteLine("TestClass instance created! {0}", instance);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
