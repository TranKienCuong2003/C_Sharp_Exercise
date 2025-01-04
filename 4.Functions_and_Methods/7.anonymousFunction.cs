using System;

namespace Functions_and_Methods
{
    class anonymousFunction
    {
        public static void Run()
        {
            // Anonymous function
            Func<int, int, int> add = delegate (int a, int b)
            {
                return a + b;
            };

            int result = add(10, 20);
            Console.WriteLine("Result: " + result);
        }
    }
}