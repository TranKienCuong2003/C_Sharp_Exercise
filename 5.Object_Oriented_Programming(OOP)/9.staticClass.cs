using System;

namespace Object_Oriented_Programming
{
    class StaticClass
    {
        public static void Run()
        {
            Console.WriteLine(MathOperations.Add(5, 3));
            Console.WriteLine(MathOperations.Subtract(5, 3));
        }
    }

    static class MathOperations
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}
