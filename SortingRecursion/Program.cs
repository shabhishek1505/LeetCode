using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new int[] { 4, 9, 1, 7, 6, 26, 98, 56 };

            var output = SortRecursive(input);


        }

        public static int[] SortRecursive(int[] inp)
        {
            if (inp.Length == 1)
                return inp;

            var last = inp.Last();
            return Insert(SortRecursive(inp.Take(inp.Length - 1).ToArray()), inp[inp.Length - 1]);
        }

        public static int[] Insert(int[] inp, int ins)
        {
            if (inp.Length == 0)
                return new int[] { ins };


            if (ins > inp.Last())
            {
                Array.Resize(ref inp, inp.Length + 1);
                inp[inp.Length - 1] = ins;
                return inp;
            }

            var last = inp.Last();
            var arr = Insert(inp.Take(inp.Length - 1).ToArray(), ins);

            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = last;
            return arr;

        }

    }
}
