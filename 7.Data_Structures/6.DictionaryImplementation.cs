using System;
using System.Collections.Generic;

namespace DataStructures
{
    class DictionaryImplementation
    {
        public static void Run()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();

            dict.Add(1, "One");
            dict.Add(2, "Two");
            dict.Add(3, "Three");

            Console.WriteLine("Dictionary elements:");
            foreach (var pair in dict)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }

            dict.Remove(2);
            Console.WriteLine("Dictionary after removing key 2:");
            foreach (var pair in dict)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}
