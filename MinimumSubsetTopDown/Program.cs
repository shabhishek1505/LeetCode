using System;
using System.Linq;

namespace MinimumSubsetTopDown
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var inp = new int[] { 1, 2, 30, 40 };
            decimal sum = 0;
            inp.ToList().ForEach(x =>
            {
                sum += x;
            });

            var Inpsum = (int)Math.Floor(sum / 2);

            var n = inp.Length;

            MinimumSubSet(inp, (int)Inpsum, n);
            Console.WriteLine(Math.Abs(sum - minDif * 2));

            Console.ReadLine();
        }

        public static int minDif = 0;

        public static int MinimumSubSet(int[] inp, int sum, int n)
        {
            var t = new int[n + 1, sum + 1];
            for (int i = 0; i < n + 1; i++)
            {
                for (int j = 0; j < sum + 1; j++)
                {

                    if (i == 0)
                        t[i, j] = 0;
                    if (j == 0 && i != 0)
                        t[i, j] = t[i - 1, j] + inp[n - 1];

                    if (j > 0 && i > 0)
                    {
                        if (inp[n - 1] <= j)
                        {
                            var max = Math.Max(t[i - 1, j - inp[n - 1]], t[i - 1, j]);
                            t[i, j] = max;
                            if (max > minDif)
                                minDif = max;
                        }
                        else
                        {
                            t[i, j] = t[i - 1, j];
                        }

                    }
                }
            }

            return minDif;
        }
    }
}
