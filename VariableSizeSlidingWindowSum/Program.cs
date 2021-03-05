using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableSizeSlidingWindowSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 4, 1, 1,1, 2, 3, 5 };
            int sum = 5;

            var res = MaxWindow(input, sum);
        }

        static int MaxWindow(int[] arr, int sum)
        {
            int maxWindow = Int32.MinValue;
            int tempSum = 0;
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                while (tempSum < sum)
                {
                    if (j >= arr.Length)
                        break;
                    if (tempSum + arr[j] <= sum)
                        tempSum += arr[j];
                    else
                    {   
                        break;
                    }
                    if (tempSum == sum)
                    {
                        maxWindow = Math.Max(maxWindow, j - i + 1);
                    }
                    j++;
                }

                tempSum -= arr[i];
            }
            return maxWindow;
        }
    }
}
