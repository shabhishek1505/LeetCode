using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace MinimubSubsetDP
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

            minDif = MinimumSubSet(inp, (int)Inpsum, n);
            Console.WriteLine(Math.Abs(sum - minDif * 2));

            Console.ReadLine();
        }

        public static int minDif = 0;

        public static int MinimumSubSet(int[] inp, int sum, int n)
        {
            if (n == 0)
                return 0;

            if (inp[n - 1] <= sum)
            {
                var take = Math.Max(inp[n - 1] + MinimumSubSet(inp, sum - inp[n - 1], n - 1), MinimumSubSet(inp, sum, n - 1));
                return take;
            }
            return MinimumSubSet(inp, sum, n - 1);
        }
    }
}
