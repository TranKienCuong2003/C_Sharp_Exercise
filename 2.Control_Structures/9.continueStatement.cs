using System;

namespace Control_Structures
{
    class ContinueStatement
    {
        public static void Run()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}