using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList linkedList = new SingleLinkedList();

           
            for (int i = 1; i < 5; i++)
            {
                linkedList.insertAtTheEnd(i);
            }

            linkedList.DisplayList();

            linkedList.insertAtIndex(1, 10);
            linkedList.insertAfter(1, 5123);

            //linkedList.reserveList();
            linkedList.insertCycle(1);
            Console.WriteLine(linkedList.hasCycle());
            linkedList.removeCycle();

            linkedList.DisplayList();

            Console.ReadKey();
        }

        static void Print(int val)
        {
            Console.WriteLine(val);
        }
    }
}
