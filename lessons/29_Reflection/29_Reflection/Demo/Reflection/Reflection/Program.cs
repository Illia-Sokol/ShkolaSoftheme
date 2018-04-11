using System;
using TestLibrary;

namespace Reflection
{
   class Program
    {
        static void Main()
        {
            TestClass instance = new TestClass(12.0, 3.5);
            ReflectionHelper.MethodReflectInfo(instance);

            Console.ReadLine();
        }
    }
}
