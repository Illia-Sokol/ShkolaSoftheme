using System;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            var tt = new CarConstructor();
            Car car = tt.Construct(new Engine(), new Color("red"), new Transmission());
            Console.Write("{0}", car.Color.CarColor);
            Console.ReadKey();
        }
    }
}
