using System;

namespace Functions_and_Methods
{
    class lambdaExpression
    {
        public static void Run()
        {
            Func<int, int, int> add = (a, b) => a + b;

            int result = add(10, 20);
            Console.WriteLine("Result: " + result);
        }
    }
}