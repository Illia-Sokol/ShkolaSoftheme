using System;

namespace find_unique_element
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {
                15, 25, 35, 45, 55,
                12, 22, 32, 43, 52,
                12, 22, 32, 43, 52, 26,
                15, 25, 35, 45, 55
            };

            var val = notDuplicate(arr);
            Console.WriteLine("Value is {0}", val);
        }

        static int notDuplicate(int[] arr)
        {
            int unpaired = arr[0];
            for (var i = 1; i < arr.Length; i++)
            {
                unpaired ^= arr[i];
            }
            return unpaired;
        }
    }
}
