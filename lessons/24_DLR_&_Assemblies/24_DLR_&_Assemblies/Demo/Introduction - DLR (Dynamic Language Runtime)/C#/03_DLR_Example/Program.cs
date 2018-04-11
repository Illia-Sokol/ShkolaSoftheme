using System;

namespace _03_DLR_Example
{
    class Program
    {
        private static dynamic _dynamicField;

        public dynamic DynamicProperty { get; set; }

        public static dynamic DynamicMethod(dynamic varriable)
        {
            dynamic dynamicVariable = "Hello";
            int i = 10;
            if (varriable is string)
            {
                return dynamicVariable;
            }
            
            return i;
        }

        static void Main()
        {
            dynamic int1 = 1;
            dynamic ex1 = new Exception("Oops!");
            dynamic result = int1 + ex1;

            Console.WriteLine(result);
        }
    }
}
