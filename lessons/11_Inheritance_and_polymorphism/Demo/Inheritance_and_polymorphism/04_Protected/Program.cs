namespace _04_Protected
{
    class Program
    {
        static void Main()
        {
            var myDerivedClass = new MyDerivedClass();
            myDerivedClass.PublicFromDerived();
            myDerivedClass.PublicMethod();

            //myDerivedClass.PrivateMethod();
            //myDerivedClass.ProtectedMethod();
            
            myDerivedClass.RunProtectedFromBase();
        }
    }
}
