using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementInRotatedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var inp = new int[] { 9, 11, 15, 21, 22, 26, 2, 5, 8, };
            var find = 26;
            var result = SearchRotation(inp, find);


        }

        static int SearchRotation(int[] inp, int find)
        {
            var start = 0;
            var end = inp.Length - 1;
            var mid = 0;
            while (start <= end)
            {
                //if (inp[start] < inp[mid])
                //    return start;
                mid = start + (end - start) / 2;

                if (inp[mid] == find)
                {
                    return mid;
                }

                if ((inp[mid] < find || find < inp[end]) && inp[mid] < inp[mid + 1])
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;

                }
            }
            return -1;

        }
    }
}
