using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Node
    {
        public Student data;
        public Node link;

        public Node(Student _data)
        {
            this.data = _data;
            this.link = null;
        }
    }
}
