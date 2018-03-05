using System;
using System.Collections.Generic;

namespace _02_Collections
{
    class Program
    {
        public static void Main()
        {
            string[] words = { "the", "fox", "jumped", "over", "the", "dog" };
            var sentence = new LinkedList<string>(words);
            
            Display(sentence, "The linked list values:");

            Console.WriteLine("sentence.Contains(\"jumped\") = {0}", sentence.Contains("jumped"));

            sentence.AddFirst("today");
            Display(sentence, "Test 1: Add 'today' to beginning of the list:");

            LinkedListNode<string> mark1 = sentence.First;
            sentence.RemoveFirst();
            
            sentence.AddLast(mark1);
            Display(sentence, "Test 2: Move first node to be last node:");
        }

        private static void Display(LinkedList<string> words, string test)
        {
            Console.WriteLine(test);
            foreach (var word in words)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
