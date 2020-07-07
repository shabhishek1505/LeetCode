using System;

namespace KnapsackTopDown
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] wt = new[] { 1, 3, 4 };
            int[] va = new int[] { 10, 15, 40 };
            int w = 6;
            int n = wt.Length;

            var prof = Knapsack(wt, va, w, n);

            Console.WriteLine(prof);

            Console.ReadLine();
        }

        public static int Knapsack(int[] wt, int[] va, int w, int n)
        {
            int[,] t = new int[n + 1, w + 1];

            for (int i = 0; i < n + 1; i++)
            {
                for (int j = 0; j < w + 1; j++)
                {
                    if (i == 0 || j == 0)
                        t[i, j] = 0;

                    if (i > 0 && j > 0)
                    {
                        if (wt[i - 1] <= j)
                        {
                            t[i, j] = Math.Max(va[i - 1] + t[i - 1, j - wt[i - 1]], t[i - 1, j]);
                        }
                        else
                        {
                            t[i, j] = t[i - 1, j];
                        }
                    }
                }
            }

            return t[n, w];

        }
    }
}
