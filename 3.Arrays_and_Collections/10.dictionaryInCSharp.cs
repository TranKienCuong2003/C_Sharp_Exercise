using System;

namespace Arrays_and_Collections
{
    class dictionaryInCSharp
    {
        public static void Run()
        {
            System.Collections.Generic.Dictionary<string, int> dict = new System.Collections.Generic.Dictionary<string, int>();

            dict.Add("one", 1);
            dict.Add("two", 2);
            dict.Add("three", 3);
            dict.Add("four", 4);
            dict.Add("five", 5);

            foreach (System.Collections.Generic.KeyValuePair<string, int> kvp in dict)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }
        }
    }
}