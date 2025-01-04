using System;

namespace SearchingAlgorithms
{
    class BinaryTreeSearch
    {
        public static void Run()
        {
            var root = new Node(10);
            root.Left = new Node(5);
            root.Right = new Node(15);
            root.Left.Left = new Node(2);
            root.Left.Right = new Node(7);
            root.Right.Left = new Node(12);

            int target = 7;

            if (Search(root, target))
            {
                Console.WriteLine("Element found in the binary tree.");
            }
            else
            {
                Console.WriteLine("Element not found in the binary tree.");
            }
        }

        static bool Search(Node node, int target)
        {
            if (node == null) return false;

            if (node.Value == target)
            {
                return true;
            }

            return Search(node.Left, target) || Search(node.Right, target);
        }

        class Node
        {
            public int Value;
            public Node Left;
            public Node Right;

            public Node(int value)
            {
                Value = value;
                Left = Right = null;
            }
        }
    }
}
