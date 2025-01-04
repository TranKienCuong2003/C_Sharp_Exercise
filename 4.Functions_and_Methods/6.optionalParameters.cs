using System;

namespace Functions_and_Methods
{
    class optionalParameters
    {
        public static void Run()
        {
            int result1 = Add(10, 20);
            int result2 = Add(10, 20, 30);
            Console.WriteLine("Result 1: " + result1);
            Console.WriteLine("Result 2: " + result2);
        }

        public static int Add(int a, int b, int c = 0)
        {
            return a + b + c;
        }
    }
}