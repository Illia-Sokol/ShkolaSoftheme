using System;
using _08_Indexers;

namespace _04_Indexers
{
    class Program
    {
        static void Main()
        {
            var sphere = new Sphere(0, 0, 0, 5);

            bool coordinatesIsInTheSphere = sphere[1, 1, 1];

            Console.WriteLine(coordinatesIsInTheSphere);

            Console.ReadKey();
        }
    }
}
