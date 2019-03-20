using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class BinaryTree
    {

        public class Node
        {
            public int Data;
            public Node Left = null;
            public Node Right = null;
            public void DisplayNode()
            {
                Console.WriteLine(Data + " ");
            }
        }
        public Node root;

        public BinaryTree()
        {
            root = null;
        }

        public void Insert(int data)
        {
            Node newNode = new Node();
            newNode.Data = data;
            if(root == null)
            {
                root = newNode;
            }
            else
            {
                Node current = root;

                Node parent;
                while (true)
                {
                    parent = current;
                    if (data < current.Data)
                    {
                        current = current.Left;

                        if (current == null)
                        {
                            parent.Left = newNode;
                            break;
                        }
                    }

                    else
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            parent.Right = newNode;
                            break;
                        }
                    }
                }
            }
            newNode.DisplayNode();
        }

        public void Search(int lookFor, Node root)
        {
            Node current = root;

            while (true)
            {
                if (current == null)
                {
                    Console.WriteLine("The tree is currently empty");
                    break;
                }

                else if (lookFor == root.Data)
                {
                    Console.WriteLine("Found: " + root.Data);
                    break;
                }

                else if (lookFor < current.Data)
                {
                    current = current.Left;
                    if (current == null)
                    {
                        Console.WriteLine("That number does not exist in the tree.");
                        break;
                    }
                    else if (lookFor == current.Data)
                    {
                        Console.WriteLine("Found: " + current.Data);
                        break;
                    }
                }
                else
                {
                    current = current.Right;
                    if (current == null)
                    {
                        Console.WriteLine("That number does not exist in the tree.");
                        break;
                    }
                    else if (lookFor == current.Data)
                    {
                        Console.WriteLine("Found: " + current.Data);
                        break;
                    }
                }
            }
        }
    }
}
