using System;

namespace ParamsArray
{
    class Util
    {
        public static int Sum(params int[] paramList)
        {
            Console.WriteLine("Using parameter list");
            if (paramList == null || paramList.Length == 0)
            {
                throw new ArgumentException("Util.Sum: null or empty parameter list");
            }

            var sumTotal = 0;
            foreach (var i in paramList)
            {
                sumTotal += i;
            }
            return sumTotal;
        }

        public static int Sum(int param1 = 0, int param2 = 0, int param3 = 0, int param4 = 0)
        {
            Console.WriteLine("Using optional parameters");
            var sumTotal = param1 + param2 + param3 + param4;
            return sumTotal;
        }
    }
}
