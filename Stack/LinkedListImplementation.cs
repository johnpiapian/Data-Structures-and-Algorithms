using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    class LinkedListImplementation
    {
        private LinkedList<int> stackArr;
        private LinkedListNode<int> top;

        public LinkedListImplementation()
        {
            stackArr = new LinkedList<int>();
            top = stackArr.First;
        }

        public int Size()
        {
            return stackArr.Count();
        }

        public bool isEmpty()
        {
            return (Size() <= 0);
        }

        public int Peek()
        {
            return top.Value;
        }

        public void Push(int val)
        {
            stackArr.AddFirst(val);
            top = stackArr.First;
        }

        public int Pop()
        {
            LinkedListNode<int> poppedNode = top;

            stackArr.Remove(poppedNode);

            top = stackArr.First;
            
            return poppedNode.Value;
        }


        public void Display()
        {
            Console.WriteLine("Stack: ");
            foreach (var node in stackArr)
            {
                Console.WriteLine(node);
            }
        }


    }
}
