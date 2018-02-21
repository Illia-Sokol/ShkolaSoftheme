using System;

namespace _06_Sealed
{
    public class MyDerivedClass //: MySealedClass
    {
        private readonly MySealedClass _originalSealed;
        
        public MyDerivedClass()
        {
            _originalSealed = new MySealedClass();
            Console.WriteLine("Hello from MyDerivedClass");
        }

        public void Run()
        {
            _originalSealed.Run();
        }
    }
}