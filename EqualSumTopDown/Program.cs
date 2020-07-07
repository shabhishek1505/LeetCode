using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace EqualSumTopDown
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var inp = new int[] { 3, 5, 3, 4, 10 };
            int sum = 0;
            inp.ToList().ForEach(x =>
            {
                sum += x;
            });

            if (sum % 2 == 0)
            {

                var n = inp.Length;

                var ot = EqualSum(inp, sum / 2, n);
                Console.WriteLine(ot);
            }
            else
            {
                Console.WriteLine(false);
            }

            Console.ReadLine();
        }

        public static bool EqualSum(int[] inp, int sum, int n)
        {
            bool[,] t = new bool[n + 1, sum + 1];

            for (int i = 0; i < n + 1; i++)
            {
                for (int j = 0; j < sum + 1; j++)
                {

                    if (i == 0)
                        t[i, j] = false;
                    if (j == 0)
                        t[i, j] = true;

                    if (i > 0 && j > 0)
                    {
                        if (inp[i - 1] <= j)
                            t[i, j] = t[i - 1, j - inp[i - 1]] || t[i - 1, j];
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
