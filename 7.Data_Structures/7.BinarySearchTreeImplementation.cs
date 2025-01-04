using System;

namespace DataStructures
{
    class BinarySearchTreeImplementation
    {
        public static void Run()
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Insert(50);
            bst.Insert(30);
            bst.Insert(20);
            bst.Insert(40);
            bst.Insert(70);
            bst.Insert(60);
            bst.Insert(80);

            Console.WriteLine("Inorder traversal of the BST:");
            bst.InOrderTraversal(bst.Root);
            Console.WriteLine();
        }
    }

    public class Node
    {
        public int Value;
        public Node Left;
        public Node Right;
        public Node(int value) { Value = value; Left = Right = null; }
    }

    public class BinarySearchTree
    {
        public Node Root;

        public BinarySearchTree() { Root = null; }

        public void Insert(int value)
        {
            Root = InsertRec(Root, value);
        }

        private Node InsertRec(Node root, int value)
        {
            if (root == null)
            {
                root = new Node(value);
                return root;
            }
            if (value < root.Value)
                root.Left = InsertRec(root.Left, value);
            else if (value > root.Value)
                root.Right = InsertRec(root.Right, value);

            return root;
        }

        public void InOrderTraversal(Node root)
        {
            if (root != null)
            {
                InOrderTraversal(root.Left);
                Console.Write(root.Value + " ");
                InOrderTraversal(root.Right);
            }
        }
    }
}
