using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstNegativeNumberEveryWindow
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 12, -1, -7, 8, -15, 30, 16, 28 };
            PrintNegativeNumber(input, 3);
        }

        static void PrintNegativeNumber(int[] input, int k)
        {
            var i = 0;
            var j = 0;
            var negative = new List<int>();
            while (i + k <= input.Length)
            {
                if (j - i + 1 < k)
                {
                    if (input[j] < 0)
                        negative.Add(j);
                    j++;
                }
                else
                {
                    Console.WriteLine(negative.Any() ? input[negative.FirstOrDefault()] : 0);
                    if (i == negative.FirstOrDefault())
                    {
                        negative.RemoveAt(0);
                    }
                    i++;
                }
            }
        }
    }
}
