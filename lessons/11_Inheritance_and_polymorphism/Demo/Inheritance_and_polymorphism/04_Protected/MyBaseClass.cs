using System;

namespace _04_Protected
{
    public class MyBaseClass
    {
        public void PublicMethod()
        {
            Console.WriteLine("PublicMethod from MyBaseClass");
        }

        private void PrivateMethod()
        {
            Console.WriteLine("PrivateMethod from MyBaseClass");
        }

        protected void ProtectedMethod()
        {
            Console.WriteLine("ProtectedMethod from MyBaseClass");
        }

        public override string ToString()
        {
            PrivateMethod();
            return base.ToString();
        }
    }
}