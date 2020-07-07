using System;
using System.Collections.Generic;
using System.Linq;

namespace KnapsackDP
{
    class Program
    {
        private static Dictionary<string, int> memo = new Dictionary<string, int>();
        static void Main(string[] args)
        {
            int[] wt = new[] { 5, 1, 1 };
            int[] va = new int[] { 40, 15, 10 };
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

            if (memo.ContainsKey(string.Concat(w, n)))
                return memo[string.Concat(w, n)];
            if (wt[n - 1] <= w)
            {
                var val = Math.Max((va[n - 1] + Knapsack(wt, va, w - wt[n - 1], n - 1)), Knapsack(wt, va, w, n - 1));
                memo.Add(string.Concat(w, n), val);
                return val;
            }
            else
            {
                var val = Knapsack(wt, va, w, n - 1);
                memo.Add(string.Concat(w, n), val);
                return val;
            }

        }
    }
}
