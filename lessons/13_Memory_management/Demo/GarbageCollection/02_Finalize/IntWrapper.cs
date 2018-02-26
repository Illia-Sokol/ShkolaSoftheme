using System;
using System.Threading;

namespace _02_Finalize
{
    public class IntWrapper
    {
        public int I;

        public IntWrapper(int input)
        {
            I = input;
            Console.WriteLine("I = {0}", I);
        }

        ~IntWrapper()
        {
            Console.WriteLine("deleted");
        }

        public void Run()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Run");
        }
    }
}