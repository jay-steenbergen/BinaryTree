using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    class Search
    {
        public void InOrder(Node root)//left, root, right
        {
            if (root == null)
                return;
            Stack<Node> stack = new Stack<Node>();
            Node current = root;
            while (current != null || stack.Count > 0)
            {
                while (current != null)
                {
                    stack.Push(current);
                    current = current.left;
                }
                current = stack.Pop();
                Console.Write(current.data + ", ");

                current = current.right;

            }
        }
        public void PreOrder(Node root)//root, left, right
        {
            if (root == null)
                return;

            Stack<Node> stack = new Stack<Node>();
            Node current = root;
            stack.Push(current);

            while (stack.Count > 0)
            {
                current = stack.Pop();
                Console.Write(current.data + " ");

                if (current.right != null)
                {
                    stack.Push(current.right);
                }
                if (current.left != null)
                {
                    stack.Push(current.left);
                }
            }
        }
        public void PostOrder(Node root) //left, rigth, root
        {
            if (root == null)
                return;
            Stack<Node> stack1 = new Stack<Node>();
            Stack<Node> stack2 = new Stack<Node>();
            Node current = root;
            stack1.Push(current);

            while (stack1.Count > 0)
            {
                current = stack1.Pop();
                stack2.Push(current);

                if (current.left != null)
                    stack1.Push(current.left);
                if (current.right != null)
                    stack1.Push(current.right);
            }

            while (stack2.Count > 0)
            {
                current = stack2.Pop();
                Console.Write(current.data + " ");
            }
        }
    }
}

