using System;
using System.Reflection;

namespace _02_ProcessesAppDomains
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain domain = AppDomain.CurrentDomain;
            Console.WriteLine("Name: {0}", domain.FriendlyName);
            Console.WriteLine("Base Directory: {0}", domain.BaseDirectory);
            Console.WriteLine();

            Assembly[] assemblies = domain.GetAssemblies();
            foreach (Assembly asm in assemblies)
                Console.WriteLine(asm.GetName().Name);

            Console.Read();
        }  
    }
}
