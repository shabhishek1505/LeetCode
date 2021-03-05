using System;
using System.ComponentModel.Design.Serialization;

namespace BST
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree bt = new BinaryTree();

            bt.Insert(75);
            bt.Insert(57);
            bt.Insert(90);
            bt.Insert(32);
            bt.Insert(7);
            bt.Insert(44);
            bt.Insert(60);
            bt.Insert(86);
            bt.Insert(93);
            bt.Insert(99);

            Console.WriteLine("InOrder Traversal Left->root->Right");
            bt.InOrderTraversal();
            Console.WriteLine("PreOrder Traversal Root-Left-Right");
            bt.PreOderTraversal();
            Console.WriteLine("PostOrder Traversal Left-Right-Root");
            bt.PostOrderTraversal();

            Console.WriteLine("Find 99");
            bt.Find(101);
        }
    }

    class Node
    {
        public Node LeftNode { get; set; }
        public Node RightNode { get; set; }
        public int Value { get; set; }

        public Node(int value)
        {
            this.Value = value;
        }

        public void Insert(int value)
        {
            if (value < this.Value)
            {
                if (LeftNode == null)
                {
                    LeftNode = new Node(value);
                }
                else
                {
                    LeftNode.Insert(value);

                }
            }
            else
            {
                if (RightNode == null)
                {
                    RightNode = new Node(value);
                }
                else
                {
                    RightNode.Insert(value);
                }
            }
        }

        public void InOrderTraversal()
        {
            if (LeftNode != null)
            {
                LeftNode.InOrderTraversal();
            }
            Console.WriteLine(this.Value);
            if (RightNode != null)
            {
                RightNode.InOrderTraversal();
            }
        }

        public void PreOrderTraversal()
        {
            Console.WriteLine(this.Value);
            if (LeftNode != null)
            {
                LeftNode.PreOrderTraversal();
            }
            if (RightNode != null)
            {
                RightNode.PreOrderTraversal();
            }
        }

        public void PostOrderTraversal()
        {
            LeftNode?.PostOrderTraversal();
            RightNode?.PostOrderTraversal();
            Console.WriteLine(this.Value);
        }

        public void Find(int find)
        {
            if (this.Value == find)
            {
                Console.WriteLine($"Found {find}");
                return;
            }
            if (find < this.Value)
            {
                if (LeftNode == null)
                {
                    Console.WriteLine("Not Found");
                    return;
                }
                else
                {
                    LeftNode.Find(find);
                }
            }
            else
            {
                if (RightNode == null)
                {
                    Console.WriteLine("Not Found");
                    return;
                }
                else
                {
                    RightNode.Find(find);
                }
            }

        }
    }

    class BinaryTree
    {
        private Node root;

        public void Insert(int value)
        {
            if (root == null)
            {
                root = new Node(value);
            }
            else
            {
                root.Insert(value);
            }
        }

        public void InOrderTraversal()
        {
            if (root == null)
            {
                Console.WriteLine("Blank Tree");
            }
            else
            {
                root.InOrderTraversal();
            }
        }

        public void PreOderTraversal()
        {
            if (root == null)
            {
                Console.WriteLine("Blank Tree");
            }
            else
            {
                root.PreOrderTraversal();
            }
        }

        public void PostOrderTraversal()
        {
            if (root == null)
            {
                Console.WriteLine("Blank Tree");
            }
            else
            {
                root.PostOrderTraversal();
            }
        }

        public void Find(int find)
        {
            if (root == null)
            {
                Console.WriteLine("Tree is Empty.");
            }
            else
            {
                root.Find(find);
            }
        }
    }
}
