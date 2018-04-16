using System;
using System.Diagnostics;

namespace ProcessesAppDomains
{
    class Program
    {
        static void Main(string[] args)
        {
            Process proc = Process.GetProcessesByName("devenv")[0];

            Console.WriteLine("ID: {0}", proc.Id);

            ProcessModuleCollection modules = proc.Modules;

            foreach (ProcessModule module in modules)
            {
                Console.WriteLine("Name: {0}  MemorySize: {1}",
                            module.ModuleName, module.ModuleMemorySize);
            }
        }
    }
}
