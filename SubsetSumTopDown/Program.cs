using System;
using System.Runtime.Serialization.Formatters;

namespace SubsetSumTopDown
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var inp = new int[] { 2, 3, 6, 10 };
            var sum = 11;
            var n = inp.Length;

            var ot = SubSetSum(inp, sum, n);
            Console.WriteLine(ot);

            Console.ReadLine();

        }

        public static bool SubSetSum(int[] inp, int sum, int n)
        {
            var t = new bool[n + 1, sum + 1];

            for (int i = 0; i < n + 1; i++)
            {
                for (int j = 0; j < sum + 1; j++)
                {
                    if (i == 0)
                        t[i, j] = false;
                    if (j == 0)
                        t[i, j] = true;

                    if (i > 0 && j > 0)
                    {
                        if (inp[i - 1] <= j)

                            t[i, j] = (t[i - 1, j - inp[i - 1]] || t[i - 1, j]);

                        else
                        {
                            t[i, j] = t[i - 1, j];
                        }
                    }

                }
            }


            return t[n, sum];
        }
    }
}
