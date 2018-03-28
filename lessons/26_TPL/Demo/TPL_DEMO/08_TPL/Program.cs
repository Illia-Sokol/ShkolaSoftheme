using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace _08_TPL
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

            Stopwatch sw = new Stopwatch();

            _data = new int[200000000];

            sw.Start();

            Parallel.For(0, _data.Length, (i) => _data[i] = i);

            sw.Stop();
            Console.WriteLine("|| parallel initialization: {0} seconds", sw.Elapsed.TotalSeconds);
            sw.Reset();

            sw.Start();
            for (int i = 0; i < _data.Length; i++)
            {
                _data[i] = i;
            }
            sw.Stop();
            Console.WriteLine("sequential initialization: {0} seconds", sw.Elapsed.TotalSeconds);
            sw.Reset();
            Console.WriteLine();

            sw.Start();
            Parallel.For(0, _data.Length, MyTransform);
            sw.Stop();
            Console.WriteLine("|| parallel work: {0} seconds", sw.Elapsed.TotalSeconds);
            sw.Reset();

            sw.Start();
            for (int i = 0; i < _data.Length; i++)
            {
                MyTransform(i);
            }
            sw.Stop();
            Console.WriteLine("sequential work: {0} seconds", sw.Elapsed.TotalSeconds);

            Console.WriteLine("Main thread finished");
            Console.ReadLine();
        }
    }
}
