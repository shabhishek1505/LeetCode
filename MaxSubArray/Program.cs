using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSubArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new int[] { 1, 3, -1, 5, 3, 8, 0, 9, 12, 5, 3, 2, 7 };
            PrintMax(input, 3);
        }

        static void PrintMax(int[] array, int k)
        {
            int i = 0;
            int j = 0;
            Queue<int> q = new Queue<int>();
            while (i + k <= array.Length)
            {

                while (j - i < k)
                {
                    if (q.Count == 0)
                    {
                        q.Enqueue(array[j]);
                    }
                    else if (q.Count > 0 && q.Peek() > array[j])
                    {
                        q.Enqueue(array[j]);
                    }
                    else if(q.Count > 0 && q.Peek() < array[j])
                    {
                        q.Clear();
                        q.Enqueue(array[j]);
                    }

                    j++;
                }

                Console.WriteLine(q.Peek());
                if (q.Peek() == array[i])
                    q.Dequeue();

                i++;

            }


        }
    }
}
