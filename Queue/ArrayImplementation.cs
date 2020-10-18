using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    class ArrayImplementation
    {
        private int[] queueArray;
        private int front;
        private int rear;

        public ArrayImplementation()
        {
            queueArray = new int[10];
            front = -1;
            rear = -1;
        }

        public ArrayImplementation(int size)
        {
            queueArray = new int[size];
            front = -1;
            rear = -1;
        }

        public bool isEmpty()
        {
            return (front == -1 || front == rear + 1);
        }

        public bool isFull()
        {
            return (rear == queueArray.Length - 1);
        }

        public int Size()
        {
            if (isEmpty())
            {
                return 0;
            }

            return rear - front + 1;
        }

        public void Insert(int val)
        {
            if (!isFull())
            {
                if (front == -1)
                    front = 0;
                rear++;
                queueArray[rear] = val;
            }
            else
            {
                Console.WriteLine("Queue Overflow");
            }
        }

        public int Delete()
        {
            if (isEmpty())
            {
                throw new System.InvalidOperationException("Action unsucessful: Queue is empty!");
            }

            int deletedEl = queueArray[front];
            front++;

            return deletedEl;
        }

        public int Peek()
        {
            if (isEmpty())
            {
                throw new System.InvalidOperationException("Action unsucessful: Queue is empty!");
            }

            return queueArray[front];
        }

        public void Display()
        {
            if (isEmpty())
            {
                Console.WriteLine("Action unsucessful: Queue is empty!");
            }
            else
            {
                Console.WriteLine("Queue: ");
                for (int i = front; i <= rear; i++)
                {
                    Console.Write(queueArray[i] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
