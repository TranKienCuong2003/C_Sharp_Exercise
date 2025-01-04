using System;

namespace Control_Structures
{
    class SwitchCase
    {
        public static void Run()
        {
            int a = 5;
            switch (a)
            {
                case 1:
                    Console.WriteLine("a is 1");
                    break;
                case 2:
                    Console.WriteLine("a is 2");
                    break;
                case 3:
                    Console.WriteLine("a is 3");
                    break;
                default:
                    Console.WriteLine("a is not 1, 2, or 3");
                    break;
            }
        }
    }
}