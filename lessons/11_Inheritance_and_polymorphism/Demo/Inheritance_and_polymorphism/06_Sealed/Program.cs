using System;

namespace _06_Sealed
{
    class Program
    {
        static void Main(string[] args)
        {
            var myDerivedClass = new MyDerivedClass();
            var mySealedClass = new MySealedClass();

            mySealedClass.Run();
            myDerivedClass.Run();

            Console.ReadKey();
        }
    }
}
