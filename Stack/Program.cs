using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayImplementation stack = new ArrayImplementation(5);
            LinkedListImplementation stack = new LinkedListImplementation();

            Start(stack);
        }

        static void Start(dynamic stack)
        {
            int userInput = -1;

            do
            {
                userInput = DisplayMenu();
                Console.Clear();

                switch (userInput)
                {
                    case 1: // Push
                        stack.Push(getNumber("Enter value: "));
                        break;
                    case 2: // Pop
                        try
                        {
                            stack.Pop();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Action unsucessful: Stack is empty!");
                        }
                        break;
                    case 3:// get size
                        output(stack.Size().ToString());
                        break;
                    case 4:// get top
                        try
                        {
                            output(stack.Peek().ToString());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Action unsucessful: Stack is empty!");
                        }
                        break;
                    case 5:// display all
                        stack.Display();
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
            Console.WriteLine("1)  Push to stack");
            Console.WriteLine("2)  Pop from stack");
            Console.WriteLine("3)  Get stack size");
            Console.WriteLine("4)  Get top element");
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
