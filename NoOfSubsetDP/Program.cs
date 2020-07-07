using System;

namespace NoOfSubsetDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var inp = new int[] {1, 2, 3,5, 6, 10 };
            var sum = 11;
            var n = inp.Length;

             NoOfSubset(inp, sum, n);
            Console.WriteLine(count);

            Console.ReadLine();
        }

        public static int count = 0;
        public static int NoOfSubset(int[] inp, int sum, int n)
        {
            if (n == 0)
                return 0;

            if (inp[n - 1] <= sum)
            {
                if (sum == inp[n - 1] + NoOfSubset(inp, sum - inp[n - 1], n - 1))
                    count++;
                else
                {
                    return NoOfSubset(inp, sum, n - 1);
                }
            }
            return NoOfSubset(inp, sum, n - 1);
        }
    }
}
