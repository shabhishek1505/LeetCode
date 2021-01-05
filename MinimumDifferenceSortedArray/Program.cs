using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumDifferenceSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new[] { 1, 3, 8, 10, 12 };
            var res = GetMinDiff(input, 12, 0, input.Length - 1);
        }

        static int GetMinDiff(int[] input, int search, int start, int end)
        {

            int mid = (start + end) / 2;

            if (input[mid] == search)
                return input[mid];
            if (start + 1 == end)
            {
                return Math.Abs(input[start] - search) > Math.Abs(input[end] - search) ? input[end] : input[start];
            }
            if (input[mid] < search)
            {
                return GetMinDiff(input, search, mid + 1, end);
            }

            if (input[mid] > search)
            {
                return GetMinDiff(input, search, start, mid - 1);
            }

            return -1;

        }
    }
}
