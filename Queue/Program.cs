using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayImplementation queue = new ArrayImplementation(5);

            int userInput = -1;

            do
            {
                userInput = DisplayMenu();
                Console.Clear();

                switch (userInput)
                {
                    case 1: // Push
                        queue.Insert(getNumber("Enter value: "));
                        break;
                    case 2: // Pop
                        try
                        {
                            queue.Delete();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Action unsucessful: Queue is empty!");
                        }
                        break;
                    case 3:// get size
                        output(queue.Size().ToString());
                        break;
                    case 4:// get top
                        try
                        {
                            output(queue.Peek().ToString());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Action unsucessful: Queue is empty!");
                        }
                        break;
                    case 5:// display all
                        queue.Display();
                        break;
                    default:
                        Console.WriteLine("Action unsucessful: Invalid code!");
                        break;
                }
            } while (userInput != 0);

        }

        static int DisplayMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Operations:- ");
            Console.WriteLine("1)  Insert to queue");
            Console.WriteLine("2)  Delete from queue");
            Console.WriteLine("3)  Get queue size");
            Console.WriteLine("4)  Get frontmost element");
            Console.WriteLine("5)  Display all elements");
            Console.WriteLine("0)  Exit");
            Console.WriteLine();

            string s;
            int result;

            do
            {
                Console.Write("Operation code: ");
                s = Console.ReadLine();
            } while (!Int32.TryParse(s, out result));

            return result;
        }

        static int getNumber(string message)
        {
            Console.Write(message);

            int result = 0;
            string c = Console.ReadLine();

            while (!Int32.TryParse(c, out result))
            {
                Console.Write("Check your input: ");
                c = Console.ReadLine();
            }

            return result;
        }

        static void output(string s)
        {
            Console.WriteLine(s);
        }
    }
}
