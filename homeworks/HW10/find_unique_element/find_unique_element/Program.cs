using System;

namespace find_unique_element
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 15, 25, 35, 45, 55,
                 12, 22, 32, 43, 52,
                 12, 22, 32, 43, 52, 26,
                 15, 25, 35, 45, 55
            };

            int unique = array[0];

            for (var i = 0; i < array.length; i++ )
            {
                unique = array[i];
                if (unique == array[i])
                {
                    continue;
                }
            }
        }
    }
}
