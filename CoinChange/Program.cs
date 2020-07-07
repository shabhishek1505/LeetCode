using System;

namespace CoinChange
{
    class Program
    {
        static void Main(string[] args)
        {
            var coins = new int[] { 1, 2, 3 };
            var sum = 5;
            var n = coins.Length;

            var ss = CoinChange(coins, sum, n);
            Console.WriteLine(count);
        }

        private static int count;

        public static int CoinChange(int[] inp, int sum, int n)
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
                            t[i, j] = t[i, j - inp[i - 1]] + t[i - 1, j];

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
