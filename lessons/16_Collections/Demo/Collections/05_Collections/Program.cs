using System;
using System.Collections.Generic;

namespace _05_Collections
{
    class Program
    {
        public static void Main()
        {
            var openWithDictionary = new Dictionary<string, string>();

            openWithDictionary.Add("txt", "notepad.exe");
            openWithDictionary.Add("bmp", "paint.exe");
            openWithDictionary.Add("dib", "paint.exe");
            openWithDictionary.Add("rtf", "wordpad.exe");

            try
            {
                openWithDictionary.Add("txt", "winword.exe");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("An element with Key = \"txt\" already exists.");
            }

            Console.WriteLine("For key = \"rtf\", value = {0}.", openWithDictionary["rtf"]);

            openWithDictionary["rtf"] = "winword.exe";
            Console.WriteLine("For key = \"rtf\", value = {0}.", openWithDictionary["rtf"]);

            openWithDictionary["doc"] = "winword.exe";

            try
            {
                Console.WriteLine("For key = \"tif\", value = {0}.", openWithDictionary["tif"]);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Key = \"tif\" is not found.");
            }

            string value = "";
            if (openWithDictionary.TryGetValue("tif", out value))
            {
                Console.WriteLine("For key = \"tif\", value = {0}.", value);
            }
            else
            {
                Console.WriteLine("Key = \"tif\" is not found.");
            }

            if (!openWithDictionary.ContainsKey("ht"))
            {
                openWithDictionary.Add("ht", "hypertrm.exe");
                Console.WriteLine("Value added for key = \"ht\": {0}", openWithDictionary["ht"]);
            }

            Console.WriteLine();
            foreach (KeyValuePair<string, string> kvp in openWithDictionary)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
        }
    }
}
