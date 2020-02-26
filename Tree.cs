using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    class Tree
    {
        public Node root { get; set; }
        public Tree()
        {
            root = null;
        }
        public void AddNode(int data)
        {

            Node newNode = new Node(data);
            if (root == null)
            {
                root = newNode;
                return;
            }
            else
            {
                InsertNode(root, new Node(data));
            }
        }
        public void InsertNode(Node root, Node newNode)
        {
            if (root == null)
                root = newNode;
            if (newNode.data < root.data)
            {
                if (root.left == null)
                    root.left = newNode;
                else
                {
                    InsertNode(root.left, newNode);
                }
            }
            else
            {
                if (root.right == null)
                    root.right = newNode;
                else
                {
                    InsertNode(root.right, newNode);
                }
            }

        }
    }
}
