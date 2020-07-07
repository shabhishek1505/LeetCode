using System;
using System.Threading.Tasks.Sources;

namespace IsLand
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static int NumIslands(char[][] grid)
        {
            int count = 0;
            for (int i = 0; i < grid.Length; i++)
            {

                for (int j = 0; j < grid[0].Length; j++)
                {
                    if ((int)char.GetNumericValue(grid[i][j]) == 1)
                    {
                        if (i == 0)
                        {
                            count++;
                            continue;
                        }

                        if (i != 0 && grid[i - 1][j] != 1)
                        {
                            count++;
                            continue;
                        }

                        if (j != 0 && grid[i][j - 1] != 1)
                        {
                            count++;
                            continue;
                        }
                    }

                }
            }

            return count;
        }
    }
}
