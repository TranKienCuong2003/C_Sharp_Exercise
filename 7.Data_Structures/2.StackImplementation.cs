using System;
using System.Collections.Generic;

namespace DataStructures
{
    class StackImplementation
    {
        public static void Run()
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine("Stack after pushing elements:");
            foreach (var item in stack)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            stack.Pop();
            Console.WriteLine("Stack after popping an element:");
            foreach (var item in stack)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
