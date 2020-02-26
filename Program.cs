using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            Search search = new Search();
            tree.AddNode(3);
            tree.AddNode(7);
            tree.AddNode(10);
            tree.AddNode(1);
            tree.AddNode(2);
            tree.AddNode(13);
            tree.AddNode(4);
            tree.AddNode(9);
            search.InOrder(tree.root);
            Console.WriteLine();
            search.PreOrder(tree.root);
            Console.WriteLine();
            search.PostOrder(tree.root);
            Console.ReadLine();
        }
    }
}
