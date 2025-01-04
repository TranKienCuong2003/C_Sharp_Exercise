using System;

namespace Functions_and_Methods
{
    class functionReturningArray
    {
        public static void Run()
        {
            int[] numbers = GetNumbers();
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public static int[] GetNumbers()
        {
            int[] numbers = { 10, 20, 30, 40, 50 };
            return numbers;
        }
    }
}