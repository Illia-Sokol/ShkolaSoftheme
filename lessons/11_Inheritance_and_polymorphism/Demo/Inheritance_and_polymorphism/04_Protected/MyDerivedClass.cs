using System;

namespace _04_Protected
{
    public class MyDerivedClass : MyBaseClass
    {
        public void PublicFromDerived()
        {
            Console.WriteLine("PublicFromDerived");
        }

        public void RunProtectedFromBase()
        {
            // add some functionality
            ProtectedMethod();
        }
    }
}