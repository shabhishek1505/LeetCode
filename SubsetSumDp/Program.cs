using System;
using System.Reflection.Metadata.Ecma335;

namespace SubsetSumDp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var inp = new int[] { 2, 3, 5, 10 };
            var sum = 11;
            var n = inp.Length;

            var ot = SubsetSum(inp, sum, n);

            Console.WriteLine(ot);

            Console.ReadLine();

        }

        public static int SubsetSum(int[] inp, int sum, int n)
        {
            if (n == 0)
                return 0;

            if (inp[n - 1] <= sum)
            {
                if (inp[n - 1] + SubsetSum(inp, sum - inp[n - 1], n - 1) == sum)
                    return sum;
                if (SubsetSum(inp, sum, n - 1) == sum)
                {
                    return sum;
                }
            }

            return SubsetSum(inp, sum, n - 1);
        }
    }
}
