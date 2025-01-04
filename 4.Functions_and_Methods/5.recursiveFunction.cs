using System;

namespace Functions_and_Methods
{
    class recursiveFunction
    {
        public static void Run()
        {
            int n = 5;
            int result = Factorial(n);
            Console.WriteLine("Factorial of " + n + " is " + result);
        }

        public static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
    }
}