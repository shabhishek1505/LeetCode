using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSubstringWIthKUnique
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "aabaacacaccebebebe";
            int k = 3;

            var res = LargestSubstring(input.ToCharArray(), k);
        }

        static int LargestSubstring(char[] arr, int k)
        {
            int count = 0;
            int i = 0;
            int j = 0;
            int max = Int32.MinValue;
            var map = new Dictionary<char, int>();
            while (i + count < arr.Length)
            {

                while (map.Count <= k && j < arr.Length)
                {
                    count++;
                    if (map.ContainsKey(arr[j]))
                    {
                        map[arr[j]]++;
                    }
                    else
                    {
                        map.Add(arr[j], 1);
                    }
                    j++;
                }

                //count--;
                //j--;
                max = Math.Max(max, count-1);

                while (map.Count >= k)
                {
                    if (map[arr[i]] > 1)
                    {
                        map[arr[i]]--;
                    }
                    else
                    {
                        map.Remove(arr[i]);
                    }
                    count--;
                    i++;
                }
            }

            return max;
        }
    }
}
