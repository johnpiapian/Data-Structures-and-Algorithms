using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Controller
    {
        public Controller()
        {
            Start();
        }

        public void Start()
        {
            LinkedList students = new LinkedList();

            students.Insert(new Student("John", "PiaPian", 10001));
            students.Insert(new Student("Joe", "Rogan", 10002));
            students.Insert(new Student("John", "Smith", 10003));
            students.Insert(new Student("James", "Mcname", 10004));
            students.Insert(new Student("Peter", "Yan", 10005));

            int userInput = -1;

            do
            {
                Console.Clear();
                userInput = DisplayMenu();
                Console.Clear();

                switch (userInput)
                {
                    case 1: // Add
                        try
                        {
                            students.Insert(new Student(getString("Enter firstname: "), getString("Enter lastname: "), getNumber("Enter studentID: ")));

                            output("\nSuccessfully added.\n");
                            continuation();
                        }
                        catch (Exception)
                        {
                            output("Action unsucessful: unexpected error!");
                            continuation();
                        }
                        break;
                    case 2: // Remove
                        students.Remove(getNumber("Enter studentID: "));
                        continuation();
                        break;
                    case 3: // Search
                        students.Search(getNumber("Enter studentID: "));
                        continuation();
                        break;
                    case 4: // Display all
                        students.DisplayList();
                        continuation();
                        break;
                    case 5: // Display partial
                        students.DisplayPartial(getNumber("1) Firstname  \n2) Lastname \nType: "), getString("Enter matching string: "));
                        continuation();
                        break;
                    case 6: // Sort
                        LinkedList students_sorted = students;
                        students_sorted.Sort(getNumber("1) Firstname  \n2) Lastname \n3) StudentID \nType: "));

                        output("\nAscending -------------------");
                        students_sorted.DisplayList();
                        output("\nDescending -------------------");
                        students_sorted.ReverseList();
                        students_sorted.DisplayList();

                        continuation();
                        break;
                    default:
                        output("Action unsucessful: Invalid code!");
                        break;
                }
            } while (userInput != 0);
        }


        public int DisplayMenu()
        {
            Console.WriteLine("Options:- ");
            Console.WriteLine("1)  Add student");
            Console.WriteLine("2)  Remove student");
            Console.WriteLine("3)  Search student");
            Console.WriteLine("4)  Display all students");
            Console.WriteLine("5)  Display students by a filter");
            Console.WriteLine("6)  Sort by attribute");
            Console.WriteLine("0)  Exit");
            Console.WriteLine();

            return getNumber("Option code: ");
        }

        public int getNumber(string message)
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

        public string getString(string message)
        {
            Console.Write(message);

            string c = Console.ReadLine();

            while (c.Trim() == "")
            {
                Console.Write("Check your input: ");
                c = Console.ReadLine();
            }

            return c;
        }

        public void continuation()
        {
            output("\nPress any key to continue...");
            Console.ReadKey();
        }

        public void output(string s)
        {
            Console.WriteLine(s);
        }
    }
}
