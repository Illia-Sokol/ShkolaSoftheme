using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var concurrency = 1000;
            var singltonObjectsArray = new Singleton[concurrency];

            Parallel.For(0, concurrency, i =>
            {
                singltonObjectsArray[i] = Singleton.Construct();
            });

            foreach (var singleton in singltonObjectsArray)
            {
                Console.WriteLine(singleton.Value);
            }

            Console.ReadLine();
        }

        //static void Main(string[] args)
        //{
        //    MyClass inst1 = MyClass.GetInctance();
        //    inst1.Value = 11;

        //    Console.WriteLine(inst1.Value);

        //    MyClass inst2 = MyClass.GetInctance();
        //    inst2.Value = 22;

        //    var result = new Lazy<bool>(()=> SomeHardWorkMethod() );

        //    if (inst1.Value == 11 || result.Value)
        //    {
        //        Console.WriteLine("Hello world");
        //    }

        //    Console.WriteLine(inst1.Value);
        //    Console.WriteLine(inst2.Value);

        //    Console.ReadLine();
        //}

         public static bool SomeHardWorkMethod()
         {
             Thread.Sleep(2000);
             return true;
         }
    }

    public class MyClass
    {
        private static readonly Lazy<MyClass> Instance = new Lazy<MyClass>(() => new MyClass(), false);

        private MyClass()
        {
        }

        public static MyClass GetInctance()
        {
            return Instance.Value;
        }

        public int Value { get; set; }
    }
}
