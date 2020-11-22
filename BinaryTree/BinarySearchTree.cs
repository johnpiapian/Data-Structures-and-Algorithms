using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    class BinarySearchTree
    {
        private Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        public void generateTree()
        {
            for (int i = 5; i < 15; i++)
            {
                if (i % 2 == 0)
                    Insert(i);

            }

            for (int i = 0; i < 15; i++)
            {
                if (i % 2 == 1)
                    Insert(i);

            }
        }

        public void Insert(int data)
        {
            if (Insert(ref root, data))
            {
                Console.WriteLine($"{data} was successfully inserted in the search tree.");
            }
            else
            {
                Console.WriteLine($"{data} is already in the search tree.");
            }
        }

        // Use ref to pass as reference to change the original variable
        public bool Insert(ref Node root, int data)
        {
            if(root == null)
            {
                root = new Node(data);
                return true;
            }

            if(data < root.data)
            {
                return Insert(ref root.LChild, data);
            }

            if(data > root.data)
            {
                return Insert(ref root.RChild, data);
            }

            return false;
        }

        public void Delete(int data)
        {
            Node tNode = null;

            if (Delete(ref tNode, ref root, data))
            {
                Console.WriteLine($"{data} was successfully deleted from the search tree.");
            }
            else
            {
                Console.WriteLine($"{data} was not found in the search tree.");
            }
        }

        private bool Delete(ref Node gpNode, ref Node pNode, int data)
        {
            if (pNode is null)
            {
                return false;
            }

            if (data < pNode.data)
            {
                return Delete(ref pNode, ref pNode.LChild, data);
            }

            if (data > pNode.data)
            {
                return Delete(ref pNode, ref pNode.RChild, data);
            }

            // if data is found
            if (pNode.LChild != null && pNode.RChild != null)
            {
                Node successor = pNode.RChild, parentOfSuccessor = pNode;

                while (successor.LChild != null)
                {
                    parentOfSuccessor = successor;
                    successor = successor.LChild;
                }

                pNode.data = successor.data;

               
                if (parentOfSuccessor == pNode)
                {
                    parentOfSuccessor.RChild = successor.RChild;
                }
                else
                {
                    parentOfSuccessor.LChild = successor.RChild;
                }
            }
            else
            {
                Node orphanChild = pNode.LChild ?? pNode.RChild;

                if (gpNode != null)
                {
                    if (pNode == gpNode.LChild)
                    {
                        gpNode.LChild = orphanChild;
                    }
                    else
                    {
                        gpNode.RChild = orphanChild;
                    }
                }
                else
                {
                    pNode = orphanChild;
                }
            }

            return true;

        }


        public void Display()
        {
            Display(root, 0);
            Console.WriteLine();
        }

        private void Display(Node p, int level)
        {
            int i;
            if(p == null)
            {
                return;
            }

            Display(p.RChild, level + 1);
            Console.WriteLine();

            for (i = 0; i < level; i++)
            {
                Console.Write("    ");
            }
            Console.Write(p.data);

            Display(p.LChild, level + 1);
        }

    }
}
