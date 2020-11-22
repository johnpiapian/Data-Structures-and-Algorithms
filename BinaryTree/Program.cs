using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();

            int userInput = -1;

            do
            {
                Console.Clear();
                userInput = DisplayMenu();
                Console.Clear();

                switch (userInput)
                {
                    case 1:
                        //bst.generateTree();
                        bst.Insert(getNumber("Enter number to be inserted: "));

                        continuation();
                        break;
                    case 2:
                        bst.Delete(getNumber("Enter number to be deleted: "));

                        continuation();
                        break;
                    case 3:
                        bst.Display();

                        continuation();
                        break;
                    default:
                        Console.WriteLine("Action unsucessful: Invalid code!");
                        break;
                }
            } while (userInput != 0);
        }

        static int DisplayMenu()
        {
            Console.WriteLine("Options:- ");
            Console.WriteLine("1)  Add Node");
            Console.WriteLine("2)  Delete Node");
            Console.WriteLine("3)  Display");
            Console.WriteLine("0)  Exit");
            Console.WriteLine();

            return getNumber("Option code: ");
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

        static void continuation()
        {
            Console.Write("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
