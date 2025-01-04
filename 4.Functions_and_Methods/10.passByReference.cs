using System;

namespace Functions_and_Methods
{
    class passByReference
    {
        public static void Run()
        {
            int number = 10;
            Console.WriteLine("Before: " + number);
            Increment(ref number);
            Console.WriteLine("After: " + number);
        }

        public static void Increment(ref int number)
        {
            number++;
        }
    }
}