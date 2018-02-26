using System;

namespace _04_GC
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("System info:");
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("OS: {0} .NET Framework: {1}", Environment.OSVersion, Environment.Version);
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nGarbage collector info:");
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Bytes in the HEAP: {0} MaxGeneration: {1}", GC.GetTotalMemory(false), GC.MaxGeneration + 1);

            var user = new UserInfo("Alex", 26);
            Console.WriteLine("\nCurrent generation of user object: {0}", GC.GetGeneration(user));

            for (int i = 0; i < 50000; i++)
            {
                var userInfo = new UserInfo("Dm", 27);
            }

            GC.Collect(0, GCCollectionMode.Forced);
            GC.WaitForPendingFinalizers();
            Console.WriteLine("Cleaning ...");

            Console.WriteLine("Current generation of user object: {0}", GC.GetGeneration(user));

            Console.ReadLine();
        }
    }
}
