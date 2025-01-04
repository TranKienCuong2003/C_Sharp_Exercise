using System;

namespace Control_Structures
{
    class DoWhileLoop
    {
        public static void Run()
        {
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 5);
        }
    }
}