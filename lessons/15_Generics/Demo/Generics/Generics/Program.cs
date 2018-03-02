using System;

namespace Generics
{
    class Program
    {
        static void Main()
        {
            var intValue = new GenericValueWrapper<int>(33);

            intValue.PrintObjectType();
            Console.WriteLine("object value: {0}", intValue);

            var stringValue = new GenericValueWrapper<string>("Hello world");

            stringValue.PrintObjectType();
            Console.WriteLine("object value: {0}", stringValue);

            var carValue = new GenericValueWrapper<Car>(new Car { Model = "BMW" });
            carValue.PrintObjectType();
            Console.WriteLine("object value: {0}", carValue);

            Console.ReadKey();
        }
    }
}
