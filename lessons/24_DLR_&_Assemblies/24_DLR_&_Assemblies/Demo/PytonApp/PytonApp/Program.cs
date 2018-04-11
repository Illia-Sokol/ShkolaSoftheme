using System;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace PytonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ScriptEngine engine = Python.CreateEngine();
            ScriptScope scope = engine.CreateScope();
            
            engine.Execute("print 'hello, world'");

            //engine.ExecuteFile("../../hello.py");

            engine.ExecuteFile("../../factorial.py", scope);

            dynamic function = scope.GetVariable("factorial");
            dynamic result = function(11);

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
