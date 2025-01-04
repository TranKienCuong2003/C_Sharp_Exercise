using System;

namespace Control_Structures
{
    class NestedLoops
    {
        public static void Run()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine("i = " + i + ", j = " + j);
                }
            }
        }
    }
}