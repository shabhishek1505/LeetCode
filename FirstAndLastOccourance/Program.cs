using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAndLastOccourance
{
    class Program
    {
        static void Main(string[] args)
        {
            var inp = new int[] { 2, 6, 5, 10, 10, 10, 10, 10,10 };
            var find = 10;
            var first = LeftSearch(inp, find, 0, inp.Length - 1);
            var last=RightSearch(inp, find, 0, inp.Length - 1);
        }


        static int LeftSearch(int[] inp, int find, int start, int end)
        {
            int leftIndex = -1;
            while (start <= end)
            {
                var mid = start + (end - start) / 2;


                if (inp[mid] < find)
                {
                    start = mid + 1;
                }
                else
                {
                    if (inp[mid] == find)
                    {
                        leftIndex = mid;
                    }

                    end = mid - 1;
                }

            }

            return leftIndex;
        }

        static int RightSearch(int[] inp, int find, int start, int end)
        {
            int leftIndex = -1;
            while (start <= end)
            {
                var mid = start + (end - start) / 2;


                if (inp[mid] <= find)
                {
                    if (inp[mid] == find)
                    {
                        leftIndex = mid;
                    }
                    start = mid + 1;
                }
                else
                {
                   

                    end = mid - 1;
                }

            }

            return leftIndex;
        }
    }
}
