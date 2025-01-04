using System;

namespace SearchingAlgorithms
{
    class AVLTreeSearch
    {
        public static void Run()
        {
            var tree = new AVLTree();
            tree.Insert(30);
            tree.Insert(20);
            tree.Insert(40);
            tree.Insert(50);

            int target = 40;

            if (tree.Contains(target))
            {
                Console.WriteLine("Element found in the AVL tree.");
            }
            else
            {
                Console.WriteLine("Element not found in the AVL tree.");
            }
        }

        class AVLTree
        {
            private Node root;

            public bool Contains(int value) => Contains(root, value);

            private bool Contains(Node node, int value)
            {
                if (node == null)
                {
                    return false;
                }

                if (value == node.Value)
                {
                    return true;
                }
                else if (value < node.Value)
                {
                    return Contains(node.Left, value);
                }
                else
                {
                    return Contains(node.Right, value);
                }
            }

            public void Insert(int value)
            {
                root = Insert(root, value);
            }

            private Node Insert(Node node, int value)
            {
                if (node == null)
                {
                    return new Node(value);
                }

                if (value < node.Value)
                {
                    node.Left = Insert(node.Left, value);
                }
                else
                {
                    node.Right = Insert(node.Right, value);
                }

                return node;
            }

            class Node
            {
                public int Value;
                public Node Left, Right;

                public Node(int value)
                {
                    Value = value;
                    Left = Right = null;
                }
            }
        }
    }
}
