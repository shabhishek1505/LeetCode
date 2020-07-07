using System;

namespace Knapsack
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] wt = new[] { 1, 6, 4 };
            int[] va = new int[] { 10, 40, 15  };
            int w = 6;
            int n = wt.Length;

            var prof = Knapsack(wt, va, w, n);

            Console.WriteLine(prof);

            Console.ReadLine();

        }

        public static int Knapsack(int[] wt, int[] va, int w, int n)
        {
            if (w == 0 || n == 0)
                return 0;

            if (wt[n - 1] <= w)
                return Math.Max((va[n - 1] + Knapsack(wt, va, w - wt[n - 1], n - 1)), Knapsack(wt, va, w, n - 1));
            else
                return Knapsack(wt, va, w, n - 1);

        }
    }
}
