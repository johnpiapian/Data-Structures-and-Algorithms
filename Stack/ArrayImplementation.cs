using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    class ArrayImplementation
    {
        private int[] stackArray;
        private int top;

        public ArrayImplementation()
        {
            stackArray = new int[10];
            top = -1;
        }

        public ArrayImplementation(int size)
        {
            stackArray = new int[size];
            top = -1;
        }

        public int Size()
        {
            // add one to top(zero-based index)
            return top + 1;
        }

        public bool isEmpty()
        {
            return (top <= -1);
        }

        public bool isFull()
        {
            return (top >= stackArray.Length - 1);
        }

        public void Push(int val)
        {
            if (!isFull())
            {
                top++;
                stackArray[top] = val;
            }
            else
            {
                Console.WriteLine("Action unsucessful: Stack is full!");
            }
        }

        public int Pop()
        {
            if (isEmpty())
            {
                throw new System.InvalidOperationException("Action unsucessful: Stack is empty!");
            }

            int poppedEl = stackArray[top];
            top--;

            return poppedEl;
        }

        // Return top most element without popping
        public int Peek()
        {
            if (isEmpty())
            {
                throw new System.InvalidOperationException("Action unsucessful: Stack is empty!");
            }

            return stackArray[top];
        }

        public void Display()
        {
            if (isEmpty())
            {
                Console.WriteLine("Action unsucessful: Stack is empty!");
            }
            else
            {
                Console.WriteLine("Stack: ");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stackArray[i]);
                }
                Console.WriteLine();
            }
        }


    }
}
