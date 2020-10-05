using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class SingleLinkedList
    {
        private Node start;

        public SingleLinkedList()
        {
            start = null;
        }

        public void DisplayList()
        {
            if (start == null)
            {
                Console.WriteLine("List is empty!");
            }
            else
            {
                Node p = start;
                Console.Write("List is: ");
                while (p != null)
                {
                    Console.Write(p.info + " ");
                    p = p.link;
                }
                Console.WriteLine();
            }
        }

        // Count the number of elements(node) in the list
        public int CountNodes()
        {
            Node p = start;
            int count = 0;
            while (p != null)
            {
                count++;
                p = p.link;
            }
            Console.WriteLine("The number of nodes in the list: " + count);
            return count;
        }

        // (yet to implement) Get the index(position) of an element(node) by its value
        // Check if the value exists in the list
        public bool Search(int val)
        {
            Node p = start;
            int position = 1;

            while (p != null)
            {
                if (p.info == val)
                {
                    break;
                }

                position++;
                p = p.link;
            }

            if (p == null)
            {
                Console.WriteLine(val + " not found in the list.");
                return false;
            }
            else
            {
                Console.WriteLine(val + " is at position " + position);
                return true;
            }
        }

        // Get element(node) at specific index(position)
        public Node getNode(int index) // Based 1(not 0)
        {
            Node p = start;
            for (int i = 1; i < index && p != null; i++)
            {
                p = p.link;
            }
            return p; // returns null if node doesn't exist
        }

        public Node getLastNode()
        {
            Node p = start;
            while (p.link != null)
            {
                p = p.link;
            }

            return p; // last node
        }

        public Node getSecondLastNode()
        {
            Node p = start;
            while (p.link.link != null)
            {
                p = p.link;
            }

            return p; // second last node
        }

        public void insertAtTheBeginning(int data)
        {
            Node temp = new Node(data);
            temp.link = start;
            start = temp;
        }

        public void insertAtTheEnd(int data)
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

        // Insert after the given index
        public void insertAfter(int index, int data)
        {
            // If list is empty
            if (index <= 0)
            {
                this.insertAtTheBeginning(data);
                return;
            }

            Node currentNode = this.getNode(index);

            if (currentNode != null)
            {
                Node temp = new Node(data);

                if (currentNode.link != null)
                {
                    Node nextNode = currentNode.link;
                    currentNode.link = temp;
                    temp.link = nextNode;
                }
                else
                {
                    currentNode.link = temp;
                }
            }
            else
            {
                Console.WriteLine("Invalid index!");
            }
        }

        // Insert at index
        public void insertAtIndex(int index, int data)
        {
            this.insertAfter(index - 1, data);
        }

        public void deleteFirstNode()
        {
            if (start != null)
            {
                start = start.link;
            }
            else
            {
                start = null;
                Console.WriteLine("List is empty!");
            }
        }

        public void deleteLastNode()
        {
            if (start == null || start.link == null)
            {
                start = null;
            }
            else
            {
                this.getSecondLastNode().link = null;
            }
        }

        public void deleteAtIndex(int index)
        {

            if (start == null)
            {
                Console.WriteLine("List is empty!");
                return;
            }

            if (index <= 1)
            {
                this.deleteFirstNode();
                return;
            }

            Node prevNode = this.getNode(index - 1);

            // Check validity of the node
            if (prevNode.link != null)
            {
                if (prevNode.link.link != null)
                {
                    prevNode.link = prevNode.link.link;
                } else
                {
                    prevNode.link = null;
                }
            } else
            {
                Console.WriteLine("Invalid index!");
            }
        }

        public void reserveList()
        {
            Node prev, p, next;

            prev = null;
            p = start;

            // [start] -> [A] -> [B]

            while (p != null)
            {
                next = p.link;
                p.link = prev;
                prev = p;
                p = next;
            }

            start = prev;

        }

        public void bubbleSortExData()
        {
            Node end, p, q;

            for (end = null; end != start.link; end = p)
            {
                for (p = start; p.link != end; p = p.link)
                {
                    q = p.link;
                    if (p.info > q.info)
                    {
                        int temp = p.info;
                        p.info = q.info;
                        q.info = temp;
                    }
                }
            }
        }

        public void bubleSortExLinks()
        {
            Node end, r, p, q, temp;

            for (end = null; end != start.link; end = p)
            {
                for (r = p = start; p.link != end; r = p, p = p.link)
                {
                    q = p.link;
                    if (p.info > q.info)
                    {
                        p.link = q.link;
                        q.link = p;
                        if (p != start)
                        {
                            r.link = q;
                        } else
                        {
                            start = q;
                        }

                        temp = p;
                        p = q;
                        q = temp;
                    }
                }
            }
        }

        public bool hasCycle()
        {
            if (findCycle() == null)
                return false;
            else
                return true;
        }

        public Node findCycle()
        {
            if (start == null || start.link == null)
                return null;

            Node slowR = start, fastR = start;

            while (fastR != null && fastR.link != null)
            {
                slowR = slowR.link;
                fastR = fastR.link.link;
                if (slowR == fastR)
                    return slowR;
            }
            return null;
        }

        public void removeCycle()
        {
            Node c = findCycle();
            if (c == null)
                return;
            Console.WriteLine("Node at which the cycle was detected is " + c.info);

            Node p = c, q = c;
            int lenCycle = 0;

            do
            {
                lenCycle++;
                q = q.link;
            } while (p != q);
            Console.WriteLine("Length of cycle is: " + lenCycle);

            int lenRemList = 0;
            p = start;
            while (p != q)
            {
                lenRemList++;
                p = p.link;
                q = q.link;
            }

            Console.WriteLine("Number of nodes not included in the cycle are : " + lenRemList);

            int lengthList = lenCycle + lenRemList;
            Console.WriteLine("Length of the list is : " + lengthList);

            p = start;
            for (int i = 1; i <= lengthList - 1; i++)
            {
                p = p.link;
            }
            p.link = null;
        }

        public void insertCycle(int x)
        {
            if(start == null)
            {
                return;
            }

            Node p = start, px = null, prev = null;

            while(p != null)
            {
                if (p.info == x)
                    px = p;
                prev = p;
                p = p.link;
            }

            if (px != null)
                prev.link = px;
            else
                Console.WriteLine(x + " not present in list!");

        }



    }
}
