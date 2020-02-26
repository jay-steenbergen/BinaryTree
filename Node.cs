using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    class Node
    {
        public Node right { get; set; }
        public Node left { get; set; }
        public int data { get; set; }
        public Node(int data)
        {
            this.data = data;
        }
    }
}
