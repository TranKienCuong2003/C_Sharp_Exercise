using System;

namespace Arrays_and_Collections
{
    class listInCSharp
    {
        public static void Run()
        {
            System.Collections.Generic.List<int> list = new System.Collections.Generic.List<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            foreach (int num in list)
            {
                Console.WriteLine(num);
            }
        }
    }
}