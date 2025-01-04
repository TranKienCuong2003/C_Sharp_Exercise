using System;

namespace Control_Structures
{
    class NestedIfElse
    {
        public static void Run()
        {
            int a = 10;
            int b = 20;
            int c = 30;

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("a is the largest number");
                }
                else
                {
                    Console.WriteLine("c is the largest number");
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine("b is the largest number");
                }
                else
                {
                    Console.WriteLine("c is the largest number");
                }
            }
        }
    }
}