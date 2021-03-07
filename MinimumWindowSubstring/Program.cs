using System;
using System.Collections.Generic;
using System.Linq;

namespace MinimumWindowSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            var input1 = "cabefgecdaecf";

            var input2 = "cae";
            var outp = GetMinSIze3(input1, input2);
        }


        static string GetMinSIze3(string s, string t)
        {
            var input1 = s.ToCharArray();
            var input2 = t.ToCharArray();

            var map = new Dictionary<char, int>();

            for (int k = 0; k < input2.Length; k++)
            {
                if (map.ContainsKey(input2[k]))
                {
                    map[input2[k]]++;
                }
                else
                {
                    map.Add(input2[k], 1);
                }
            }

            var count = map.Count;

            int i = 0;
            int j = 0;
            var minString = "";
            var min = Int32.MaxValue;

            while (i <= j && j < input1.Length)
            {
                if (map.ContainsKey(input1[j]))
                {
                        map[input1[j]]--;
                    if (map[input1[j]] == 0)
                        count--;
                }

                while (count == 0)
                {
                    if (min > j - i + 1)
                    {
                        min = j - i + 1;
                        minString = s.Substring(i, j - i + 1);
                    }

                    if (map.ContainsKey(input1[i]))
                    {
                        map[input1[i]]++;
                        if (map[input1[i]] == 1)
                            count++;
                    }
                    i++;
                }
                j++;
            }

            return minString;
        }







        static string GetMinSIze2(string input1String, string input2String)
        {
            char[] input1 = input1String.ToCharArray();
            char[] input2 = input2String.ToCharArray();
            var map = new Dictionary<char, int>();
            var min = Int32.MaxValue;
            var minString = "";
            var j = 0;
            int count = 0;
            for (int i = 0; i < input1.Length; i++)
            {
                if (i != 0 && input2.Contains(input1[i - 1]))
                {
                    map[input1[i - 1]]--;
                    if (map[input1[i - 1]] == 0)
                    {
                        map.Remove(input1[i - 1]);
                        count--;
                    }
                }

                if (count < input2.Length)
                {
                    while (j < input1.Length)
                    {
                        if (input2.Contains(input1[j]))
                        {
                            if (map.ContainsKey(input1[j]))
                            {
                                map[input1[j]]++;
                            }
                            else
                            {
                                map.Add(input1[j], 1);
                                count++;
                            }
                        }
                        j++;
                        if (count == input2.Length)
                            break;
                    }
                }
                if (count == input2.Length)
                {
                    if (min > j - i)
                    {
                        minString = input1String.Substring(i, j - i);
                        min = minString.Length;
                    }
                }
            }

            return minString;
        }




        static int GetMinSIze(char[] input1, char[] input2)
        {
            var map = new Dictionary<int, int>();
            var min = Int32.MaxValue;

            for (int i = 0; i < input1.Length; i++)
            {
                var lookupIndex = 0;
                if (input2[lookupIndex] == input1[i])
                {
                    lookupIndex++;
                    var j = i + 1;
                    while (j < input1.Length)
                    {
                        if (input2[lookupIndex] == input1[j])
                        {
                            if (lookupIndex == input2.Length - 1)
                            {
                                min = Math.Min(min, j - i + 1);
                                break;
                            }
                            lookupIndex++;
                        }
                        j++;
                    }
                }
            }
            return min;
        }
    }
}
