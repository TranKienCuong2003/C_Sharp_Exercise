using System;

namespace Control_Structures
{
    class BreakStatement
    {
        public static void Run()
        {
            for (int i = 0; i < 5; i++)
            {
                if (i == 3)
                {
                    break;
                }
                Console.WriteLine("i = " + i);
            }
        }
    }
}