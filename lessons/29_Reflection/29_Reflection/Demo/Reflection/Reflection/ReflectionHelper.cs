using System;
using System.Reflection;

namespace Reflection
{
    class ReflectionHelper
    {
        public static void MethodReflectInfo<T>(T obj) where T : class
        {
            Type t = typeof(T);
            MethodInfo[] methods = t.GetMethods();
            Console.WriteLine("*** Methods: {0} ***\n", obj.ToString());

            foreach (MethodInfo m in methods)
            {
                Console.Write(" --> " + m.ReturnType.Name + " \t" + m.Name + "(");
                ParameterInfo[] p = m.GetParameters();
                for (int i = 0; i < p.Length; i++)
                {
                    Console.Write(p[i].ParameterType.Name + " " + p[i].Name);
                    if (i + 1 < p.Length) Console.Write(", ");
                }
                Console.Write(")\n");
            }
        }
    }
}
