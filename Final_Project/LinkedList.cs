using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class LinkedList
    {
        private Node start;

        public LinkedList()
        {
            start = null;
        }

        public void DisplayList()
        {
            if (start == null)
            {
                Console.WriteLine("List is empty!\n");
            }
            else
            {
                Node p = start;

                Console.WriteLine("Firstname\t Lastname\t Student Id");
                Console.WriteLine("--------------------------------------------");
                while (p != null)
                {
                    Student _student = p.data;
                    // Console.WriteLine($"{_student.FName}      \t{_student.LName}\t\t{_student.SID}");
                    Console.WriteLine(_student.ToString());
                    p = p.link;
                }
                Console.WriteLine();
            }
        }

        public void DisplayPartial(int type, string text)
        {
            if (start == null)
            {
                Console.WriteLine("List is empty!\n");
            }
            else
            {
                Node p = start;

                Console.WriteLine("Firstname\t Lastname\t Student Id");
                Console.WriteLine("--------------------------------------------");
                while (p != null)
                {
                    switch (type)
                    {
                        case 1:
                            if (p.data.FName.Contains(text))
                            {
                                Console.WriteLine(p.data.ToString());
                            }
                            break;
                        case 2:
                            if (p.data.LName.Contains(text))
                            {
                                Console.WriteLine(p.data.ToString());
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid type!\n");
                            break;
                    }
                    p = p.link;
                }
                Console.WriteLine();
            }
        }

        public void Insert(Student data)
        {
            Node p;
            Node temp = new Node(data);

            if (start == null)
            {
                start = temp;
            }
            else
            {
                p = start;

                while (p.link != null)
                {
                    p = p.link;
                }

                p.link = temp;
            }
        }

        public void Remove(int _sid)
        {
            Node p = start;

            while (p != null)
            {
                if (p.data.SID.Equals(_sid))
                {
                    break;
                }

                p = p.link;
            }

            if (p == null)
            {
                Console.WriteLine("Student could not be found in the list.\n");
            }
            else
            {
                Console.WriteLine("Successfully removed!\n");
            }
        }

        public void Search(int _sid)
        {
            Node p = start;

            while (p != null)
            {
                if (p.data.SID.Equals(_sid))
                {
                    break;
                }

                p = p.link;
            }

            if (p == null)
            {
                Console.WriteLine("Student could not be found in the list.\n");
            }
            else
            {
                Console.WriteLine("Firstname\t Lastname\t Student Id");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine(p.data.ToString());
            }
        }

        public Node GetNode(int _sid)
        {
            Node p = start;

            while (p != null)
            {
                if (p.data.SID.Equals(_sid))
                {
                    break;
                }

                p = p.link;
            }

            if (p == null)
            {
                return null;
            }
            else
            {
                return p;
            }
        }

        // Sort in ascending order by an attribute
        public void Sort(int attribute)
        {
            if(attribute >= 1 && attribute <= 3) // Number of attributes (fname, lname, sid)
            {
                Node end, p, q; // p -> current, q -> next

                for (end = null; end != start.link; end = p)
                {
                    for (p = start; p.link != end; p = p.link)
                    {
                        q = p.link;
                        switch (attribute)
                        {
                            case 1:
                                if (String.Compare(p.data.FName, q.data.FName) > 0)
                                {
                                    Student temp = p.data;
                                    p.data = q.data;
                                    q.data = temp;
                                }
                                break;
                            case 2:
                                if (String.Compare(p.data.LName, q.data.LName) > 0)
                                {
                                    Student temp = p.data;
                                    p.data = q.data;
                                    q.data = temp;
                                }
                                break;
                            case 3:
                                if (p.data.SID > q.data.SID)
                                {
                                    Student temp = p.data;
                                    p.data = q.data;
                                    q.data = temp;
                                }
                                break;
                        }
                    }
                }
            }
            else
            {
                return;
            }
        }

        // Unused
        public void BubbleSort()
        {
            Node end, p, q; // p -> current, q -> next

            for (end = null; end != start.link; end = p)
            {
                for (p = start; p.link != end; p = p.link)
                {
                    q = p.link;
                    if (String.Compare(p.data.FName, q.data.FName) > 0)
                    {
                        Student temp = p.data;
                        p.data = q.data;
                        q.data = temp;
                    }
                }
            }
        }

    }
}
