using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSumSubarrayK
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] input = new int[] { 1, 8, 9, 3, 2, 0, 6, 4, 6, 8 };

            int windowSize = 3;

            var res = MaxSum(input, 3);

        }

        static int MaxSum(int[] input, int k)
        {
            int j = 0;
            int sum=0;
            int maxSum=Int32.MinValue;
            for (int i = 0; i < input.Length - k; i++)
            {
                while (j<k)
                {
                    sum = sum + input[i + j];
                    j++;
                }
                maxSum = Math.Max(sum, maxSum);
                j--;
                sum -= input[i];
            }
            return maxSum;
        }

    }
}
