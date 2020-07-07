using System;
using System.Collections.Generic;

namespace UnboundedKnapsackMemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] wt = new[] { 5, 1, 1 };
            int[] va = new int[] { 40, 15, 10 };
            int w = 6;
            int n = wt.Length;

            var prof = UnboundedKnapSack(wt, va, w, n);

            Console.WriteLine(prof);

            Console.ReadLine();
        }
        public static Dictionary<string, int> mem = new Dictionary<string, int>();

        public static int UnboundedKnapSack(int[] wt, int[] va, int w, int n)
        {
            if (n == 0)
                return 0;
            if (mem.ContainsKey(string.Concat(w, n)))
                return mem[string.Concat(w, n)];
            if (wt[n - 1] <= w)
            {
                var res = Math.Max(va[n - 1] + UnboundedKnapSack(wt, va, w - wt[n - 1], n),
                     UnboundedKnapSack(wt, va, w, n - 1));
                mem.Add(string.Concat(w, n), res);
                return res;
            }
            var ress = UnboundedKnapSack(wt, va, w, n - 1);
            mem.Add(string.Concat(w, n), ress);
            return ress;

        }
    }
}
