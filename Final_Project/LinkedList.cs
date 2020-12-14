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
                while (p != null) // O(n) n -> size of the list
                {
                    Student _student = p.data;
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

                if(type >= 1 && type <= 2)
                {
                    Node p = start;
                    Console.WriteLine("Firstname\t Lastname\t Student Id");
                    Console.WriteLine("--------------------------------------------");
                    while (p != null) // O(n)
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
                        }
                        p = p.link;
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("\nInvalid type!\n");
                }
            }
        }

        public void Insert(Student data) // O(1) or O(n) normally, but this is always O(n)
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
            Node p = start, q = start; // p -> current, q -> previous

            while (p != null) // O(n) or O(1)
            {
                if (p.data.SID.Equals(_sid))
                {
                    break;
                }

                q = p;
                p = p.link;
            }

            if (p == null)
            {
                Console.WriteLine("\nStudent could not be found in the list.\n");
            }
            else
            {
                if (q.data.SID.Equals(p.data.SID)) // if it's the first node
                {
                    start = start.link;
                }
                else
                {
                    q.link = p.link;
                }

                Console.WriteLine("\nSuccessfully removed!\n");
            }
        }

        public void Search(int _sid)
        {
            Node p = start;

            while (p != null) // O(n)
            {
                if (p.data.SID.Equals(_sid))
                {
                    break;
                }

                p = p.link;
            }

            if (p == null)
            {
                Console.WriteLine("\nStudent could not be found in the list.\n");
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

            while (p != null) // O(n)
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

        // (Bubble)Sort in ascending order by an attribute
        public void Sort(int attribute) 
        {
            if(attribute >= 1 && attribute <= 3) // Number of attributes (fname, lname, sid)
            {
                Node end, p, q; // p -> current, q -> next

                for (end = null; end != start.link; end = p) // O(n^2)
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
        }

        public void ReverseList() // descending order
        {
            Node prev, p, next;

            prev = null;
            p = start;

            while (p != null) // O(n)
            {
                next = p.link;
                p.link = prev;
                prev = p;
                p = next;
            }

            start = prev;

        }

    }
}
