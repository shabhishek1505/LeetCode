using System;
using System.Text.Json.Serialization;

namespace NoOfSubsetTopDown
{
    class Program
    {
        static void Main(string[] args)
        {
            var inp = new int[] { 1, 2, 3, 5, 6, 10 };
            var sum = 11;
            var n = inp.Length;

            var count=NoOfSubset(inp, sum, n);
            Console.WriteLine(count);

            Console.ReadLine();
        }

        public static int NoOfSubset(int[] inp, int sum, int n)
        {
            var t = new int[n + 1, sum + 1];

            for (int i = 0; i < n + 1; i++)
            {
                for (int j = 0; j < sum + 1; j++)
                {
                    if (i == 0)
                        t[i, j] = 0;
                    if (j == 0)
                        t[i, j] = 1;
                    if (i > 0 && j > 0)
                    {
                        if (inp[i - 1] <= j)
                        {
                            t[i, j] = t[i - 1, j - inp[i - 1]]  + t[i - 1, j];

                        }
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
