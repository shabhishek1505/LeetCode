using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoOfTimesSortedArrayRotated
{
    class Program
    {
        static void Main(string[] args)
        {
            var minD = DateTime.MinValue;
            var diff = (int)DateTime.UtcNow.Subtract(minD).TotalMinutes;
            var rem = diff % 7;

            var utcNow = DateTime.UtcNow;
            if ((int)utcNow.Subtract(new DateTime(utcNow.Year, 1, 1)).TotalSeconds % 420 <= 30)
            {

            }

            var inp = new int[] { 9, 11, 15, 21, 22, 26, 2, 5, 8, };
            var result = SearchRotation(inp);
        }

        static int SearchRotation(int[] inp)
        {
            var start = 0;
            var end = inp.Length - 1;
            var mid = 0;
            while (start <= end)
            {
                if (inp[start] < inp[mid])
                    return start;
                mid = start + (end - start) / 2;

                if (inp[mid] < inp[mid - 1])
                {
                    return mid;
                }

                if (inp[start] < inp[end])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return -1;

        }


    }
}
