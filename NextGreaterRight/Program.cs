using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextGreaterRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = Convert.ToInt32(Console.ReadLine());
            var input = new int[length];
            for (int i = 0; i < length; i++)
            {
                input[i] = Convert.ToInt32(Console.ReadLine());
            }
            PrintNgr(input);
        }

        public static void PrintNgr(int[] input)
        {
            Stack<int> stackGreater = new Stack<int>();

            int[] output = new int[input.Length];

            for (int i = input.Length - 1; i >= 0; i--)
            {
                while (stackGreater.Count > 0)
                {
                    var stackEle = stackGreater.Pop();

                    if (stackEle > input[i])
                    {
                        stackGreater.Push(stackEle);
                        output[i] = stackEle;
                        break;
                    }
                }
                if (stackGreater.Count == 0)
                {
                    output[i] = -1;
                }
                stackGreater.Push(input[i]);

            }

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine($"{input[i]} {output[i]}");
            }
        }

    }
}
