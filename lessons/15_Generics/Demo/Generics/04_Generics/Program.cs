using System;

namespace _04_Generics
{
    class Program
    {
        static void Main()
        {
            IContainer<Shape> wrappedShape = GetContainer();

            Console.WriteLine(wrappedShape.GetItem().Name);

            Console.ReadKey();
        }

        public static IContainer<Shape> GetContainer()
        {
            return new Container<Circle>(new Circle { Name = "This is a Circle" });
        }
    }
}
