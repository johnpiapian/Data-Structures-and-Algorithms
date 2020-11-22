using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    class Node
    {
        public Node LChild;
        public Node RChild; 
        public int data;

        public Node(int _data)
        {
            data = _data;
            LChild = null;
            RChild = null;
        }

    }
}
