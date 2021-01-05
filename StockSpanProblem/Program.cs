using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockSpanProblem
{
    class Program
    {
        // 100,34,60,34,90,23
        //1    1  2   1  4  1

        static void Main(string[] args)


        {
            int length = Convert.ToInt32(Console.ReadLine());
            var input = new int[length];
            for (int i = 0; i < length; i++)
            {
                input[i] = Convert.ToInt32(Console.ReadLine());
            }
            SSP(input);
        }

        static void SSP(int[] input)
        {

            var stack = new Stack<Tuple<int, int>>();
            var output = new int[input.Length];


            for (int i = 0; i < input.Length; i++)
            {
                if (stack.Count > 0)
                {
                    while (stack.Count>0)
                    {
                        var pop = stack.Pop();

                        if (pop.Item2 > input[i])
                        {
                            output[i] = i-pop.Item1;
                            stack.Push(pop);
                            break;
                        }
                    }
                    

                }
                else
                {
                    output[i] = 1;
                }
                stack.Push(new Tuple<int, int>(i, input[i]));
            }


            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine($"{input[i]} {output[i]}");
            }

        }




    }
}
