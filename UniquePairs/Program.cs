using System;
using System.Collections.Generic;

namespace UniquePairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inp = new int[] { 9, 29, 49, 50 };
            char[] keys = new char[] { 'c', 'b', 'c', 'd' };

            var no = KeyPress(inp, keys);
        }

        static char KeyPress(int[] releaseTimes, string keysPressed)
        {
            var keys = keysPressed.ToCharArray();
            Tuple<char, int> max = new Tuple<char, int>(keys[0], releaseTimes[0]);
            for (int i = 1; i < releaseTimes.Length; i++)
            {
                if (releaseTimes[i] - releaseTimes[i - 1] >= max.Item2)
                {
                    if (releaseTimes[i] - releaseTimes[i - 1] > max.Item2)
                    {
                        max = new Tuple<char, int>(keys[i], releaseTimes[i] - releaseTimes[i - 1]);
                    }
                    else if (max.Item1 < keys[i])
                    {
                        max = new Tuple<char, int>(keys[i], max.Item2);
                    }
                }
            }

            return max.Item1;
        }
    }
}
