using System;
using System.Collections.Generic;

namespace _06_Collections
{
    class Program
    {
        public static void Main()
        {
            var openWithSortedList = new SortedList<string, string>();

            openWithSortedList.Add("txt", "notepad.exe");
            openWithSortedList.Add("bmp", "paint.exe");
            openWithSortedList.Add("dib", "paint.exe");
            openWithSortedList.Add("rtf", "wordpad.exe");

            foreach (var value in openWithSortedList.Values)
            {
                Console.WriteLine("Value = {0}", value);
            }
        }
    }
}
