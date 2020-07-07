using System;

namespace MinNOofCoins
{
    class Program
    {
        static void Main(string[] args)
        {
            var coins = new int[] {  2,4,5 };
            var sum = 9;
            var n = coins.Length;

            var ss = MinimumNoOFCoins(coins, sum, n);
            Console.WriteLine(ss);
        }


        public static int MinimumNoOFCoins(int[] inp, int sum, int n)
        {
            int[,] t = new int[n + 1, sum + 1];

            for (int i = 0; i < n + 1; i++)
            {
                for (int j = 0; j < sum + 1; j++)
                {

                    if (i == 0)
                        t[i, j] = Int32.MaxValue-1;
                    if (j == 0)
                        t[i, j] = 0;

                    if (i > 0 && j > 0)
                    {
                        if (inp[i - 1] <= j)
                        {
                            //if (t[i - 1, j] > 0 && t[i, j - inp[i - 1]] > 0)
                            //{
                                t[i, j] = Math.Min(t[i - 1, j], 1 + t[i, j - inp[i - 1]]);
                            //}



                            //if (t[i - 1, j - inp[i - 1]] > 0 && t[i - 1, j] > 0)
                            //    t[i, j] = Math.Min(t[i - 1, j], 1 + t[i - 1, j - inp[i - 1]]);
                            //else if (t[i - 1, j - inp[i - 1]] > 0)
                            //{
                            //    t[i, j] = t[i - 1, j - inp[i - 1]];
                            //}
                            //else if (t[i - 1, j] > 0)
                            //{
                            //    t[i, j] = t[i - 1, j];
                            //}
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
