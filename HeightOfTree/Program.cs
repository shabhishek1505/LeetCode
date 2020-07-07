using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeightOfTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = new Node();
            var left = new Node();
            var right = new Node();

            var left1 = new Node();
            var right1 = new Node();

            left.Left = left1;
            left.Right = right1;


            var leftleft1 = new Node();
            var leftleft2 = new Node();

            leftleft1.Left = leftleft2;

            left1.Left = leftleft1;


            var left2 = new Node();
            var right2 = new Node();

            right.Left = left2;
            right2.Right = right2;

            left.Left = left1;
            left.Right = right1;

            root.Left = left;
            root.Right = right;



            var result = Height(root);

            Console.WriteLine(result);
            Console.ReadLine();

        }


        public static int Height(Node root)
        {
            if (root == null)
                return 0;

            //if (root.Left == null && root.Right == null)
            //    return 1;

            return 1 + Math.Max(Height(root.Left), Height(root.Right));

        }

    }

    class Node
    {
        public Node Left { get; set; }
        public Node Right { get; set; }
        public int Value { get; set; }
    }
}
