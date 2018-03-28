using System;
using System.Threading.Tasks;

namespace _07_TPL
{
    class Program
    {
        private static int[] _data;

        static void MyTransform(int i)
        {
            _data[i] = _data[i] / 10;

            if (_data[i] < 10000) _data[i] = 0;
            if (_data[i] >= 10000) _data[i] = 100;
            if (_data[i] > 20000) _data[i] = 200;
            if (_data[i] > 30000) _data[i] = 300;
        }

        static void Main()
        {
            Console.WriteLine("Main thread started");

            _data = new int[200000000];

            for (int i = 0; i < _data.Length; i++)
            {
                _data[i] = i;
            }
            
            Parallel.For(0, _data.Length, MyTransform);

            Console.WriteLine("Main thread finished");
            Console.ReadLine();
        }
    }
}
