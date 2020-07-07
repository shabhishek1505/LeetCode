using System;
using System.Collections.Generic;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {


            int[][] input = new int[3][];

            input[0]=new int[3]{2,1,1};
            input[1] = new int[3] { 0, 1, 1 };
            input[2] = new int[3] { 1, 0, 1 };




            RottenOranges(input);


        }

        public static int RottenOranges(int[][] grid)
        {
            var newGrid = new int[gr](grid);

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid.Length; j++)
                {

                    if (grid[i, j] == 1)
                    {

                    }

                }
            }


            return 0;
        }
    }
}
