using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList linkedList = new SingleLinkedList();

            int userInput = -1;

            do
            {
                userInput = DisplayMenu();

                Console.Clear();

                switch (userInput)
                {
                    case 1: // create list
                        for (int i = 0; i < 5; i++)
                        {
                            linkedList.insertAtTheEnd(i);
                        }
                        break;
                    case 2: // display list
                        linkedList.DisplayList();
                        break;
                    case 3: // add/remove at beginning of the list

                        break;
                    case 4: // add/remove at end of the list

                        break;
                    case 5: // add/remove nth position

                        break;
                    case 6: // reverse list
                        linkedList.reserveList();
                        break;
                    case 7: // bubble sort data
                        linkedList.bubbleSortExData();
                        break;
                    case 8: // bubble sort links
                        linkedList.bubleSortExLinks();
                        break;
                    case 9: // insert cycle

                        break;
                    case 10: // detect cycle

                        break;
                    case 11: // remove cycle

                        break;
                    default:
                        Console.WriteLine("\nInvalid number!\n");
                        break;
                }
            } while (userInput != 0);

            /*
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
            */
        }

        static int DisplayMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Operations:- ");
            Console.WriteLine("1)  Creating a new Single Linked List");
            Console.WriteLine("2)  Displaying the list");
            Console.WriteLine("3)  Adding / Removing an element at the beginning of the list");
            Console.WriteLine("4)  Adding / Removing an element at the end of the list");
            Console.WriteLine("5)  Adding / Removing an element at the nth position");
            Console.WriteLine("6)  Reverse the List");
            Console.WriteLine("7)  Bubble Sort by exchanging data");
            Console.WriteLine("8)  Bubble Sort by exchanging links");
            Console.WriteLine("9)  Insert Cycle");
            Console.WriteLine("10) Detect Cycle");
            Console.WriteLine("11) Remove Cycle");
            Console.WriteLine("0)  Exit");
            Console.WriteLine();

            string c;
            int result;

            do
            {
                c = Console.ReadLine();
            } while (!Int32.TryParse(c, out result));

            return result;
        }
    }
}
