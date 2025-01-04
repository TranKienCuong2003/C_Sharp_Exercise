using System;

namespace Functions_and_Methods
{
    class functionWithReturn
    {
        public static void Run()
        {
            int sum = Sum(1, 2);
            Console.WriteLine("Sum of two integers: " + sum);

            double sumDouble = Sum(1.5, 2.5);
            Console.WriteLine("Sum of two doubles: " + sumDouble);
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static double Sum(double a, double b)
        {
            return a + b;
        }
    }
}