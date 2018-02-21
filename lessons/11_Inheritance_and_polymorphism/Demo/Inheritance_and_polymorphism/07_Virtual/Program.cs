namespace _07_Virtual
{
    class Program
    {
        static void Main(string[] args)
        {
            //var myBaseClass = new MyBaseClass();
            //myBaseClass.DoSomeAction();

            var myDerivedClass = new MyDerivedClass();
            myDerivedClass.DoSomeAction();

            ((MyBaseClass)myDerivedClass).DoSomeAction();

            myDerivedClass.DoSomeAction();
        }
    }
}
