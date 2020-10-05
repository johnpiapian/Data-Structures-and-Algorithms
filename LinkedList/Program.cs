﻿using System;

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
                        switch (getNumber("1) Add \n2) Remove \n3) Back \n"))
                        {
                            case 1:

                                break;
                            case 2:
                                Console.WriteLine("Remove node at nth position.");
                                break;
                            case 3:
                                break;
                            default:
                                Console.WriteLine("Invalid number!");
                                break;
                        }
                        break;
                    case 4: // add/remove at end of the list

                        break;
                    case 5: // add/remove nth position
                        //int number = getNumber("Enter the position of the node you would like to remove: ");
                        //Console.WriteLine("Your number is " + number);

                        switch (getNumber("1) Add \n2) Remove \n3) Back \n"))
                        {
                            case 1:
                                Console.WriteLine("Add node at nth position.");
                                break;
                            case 2:
                                Console.WriteLine("Remove node at nth position.");
                                break;
                            case 3:
                                break;
                            default:
                                Console.WriteLine("Invalid number!");
                                break;
                        }

                        break;
                    case 6: // reverse list
                        try
                        {
                            linkedList.reserveList();
                            Console.WriteLine("Successfully reversed list.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Unexpected error encountered:" + ex.Message);
                        }

                        break;
                    case 7: // bubble sort data
                        try
                        {
                            linkedList.bubbleSortExData();
                            Console.WriteLine("Successfully sorted list by exchanging data.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Unexpected error encountered:" + ex.Message);
                        }
                        break;
                    case 8: // bubble sort links
                        try
                        {
                            linkedList.bubleSortExLinks();
                            Console.WriteLine("Successfully sorted list by exchange links.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Unexpected error encountered:" + ex.Message);
                        }
                        break;
                    case 9: // insert cycle
                        try
                        {
                            // ask for valuue
                            linkedList.insertCycle(1);
                            Console.WriteLine("Successfully inserted cycle.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Unexpected error encountered:" + ex.Message);
                        }
                        break;
                    case 10: // detect cycle
                        try
                        {
                            if (linkedList.hasCycle())
                                Console.WriteLine("Cycle dected.");
                            else
                                Console.WriteLine("No cycle found.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Unexpected error encountered:" + ex.Message);
                        }
                        break;
                    case 11: // remove cycle
                        try
                        {
                            linkedList.removeCycle();
                            Console.WriteLine("\nSuccessfully removed cycle.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Unexpected error encountered:" + ex.Message);
                        }
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

        static int getNumber(string message)
        {
            Console.Write(message);

            int result = 0;
            string c = Console.ReadLine();

            while(!Int32.TryParse(c, out result))
            {
                Console.Write("Check your input: ");
                c = Console.ReadLine();
            }

            return result;
        }
    }
}
