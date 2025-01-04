using System;

namespace Control_Structures
{
    class TernaryOperator
    {
        public static void Run()
        {
            int a = 5;
            int b = 10;
            int max = a > b ? a : b;
            Console.WriteLine("Max = " + max);
        }
    }
}