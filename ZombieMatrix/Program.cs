using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;

namespace ZombieMatrix
{
    class Program
    {
        static void Main(string[] args)
        {

            int[][] input = { new[] { 0, 1, 1, 0, 1 }, new[] { 0, 1, 0, 1, 0 }, new[] { 0, 0, 0, 0, 1 }, new[] { 0, 1, 0, 0, 0 } };

            var result = MinDays(input);
        }


        static int MinDays(int[][] input)
        {

            int target = input.Length * input[0].Length;

            Queue<int[]> queue = new Queue<int[]>();

            int cnt = 0, res = 0;

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input[0].Length; j++)
                {
                    if (input[i][j] == 1)
                    {
                        queue.Enqueue(new[] { i, j });

                        cnt++;
                    }
                }
            }

            if (queue.Count == 0)
                return -1;

            if (queue.Count == target)
                return 0;

            var directions = new int[][] { new[] { 0, 1 }, new[] { 0, -1 }, new[] { 1, 0 }, new[] { -1, 0 } };


            while (queue.Count > 0)
            {
                if (cnt == target)
                    return res;
                var size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    var node = queue.Dequeue();
                    foreach (var dir in directions)
                    {
                        int ni = node[0] + dir[0];
                        int nj = node[1] + dir[1];
                        if (ni >= 0 && ni < input.Length && nj >= 0 && nj < input[0].Length && input[ni][nj] == 0)
                        {
                            queue.Enqueue(new int[] { node[0] + dir[0], node[1] + dir[1] });
                            input[ni][nj] = 1;
                            cnt++;
                        }
                    }
                }
                res++;
            }

            return res;
        }


    }
}
