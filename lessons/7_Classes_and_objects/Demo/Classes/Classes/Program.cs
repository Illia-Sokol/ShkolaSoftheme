using System;

namespace Classes
{
    class Program
    {
        zz void DoWork()
        {
            var origin = new Point();
            var bottomRight = new Point(1366, 768);
            var distance = origin.DistanceTo(bottomRight);
            Console.WriteLine("Distance is: {0}", distance);
            Console.WriteLine("Number of Point objects: {0}", Point.ObjectCount());
        }

        static void Main(string[] args)
        {
            try
            {
                DoWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
