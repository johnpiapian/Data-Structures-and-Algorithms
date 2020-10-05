using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class Node
    {
        public int info;
        public Node link;

        public Node(int i)
        {
            this.info = i;
            this.link = null;
        }
    }
}
