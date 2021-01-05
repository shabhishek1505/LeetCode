using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "aaaaaaaaaaaaaaaaaaaaaabbbbbbbbaaaaaaa";
            var inputAraay = input.ToCharArray();
            string word = "ba";

            var res = Anagram(inputAraay, word);

        }

        static int Anagram(char[] input, string word)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            foreach (var ch in word)
            {
                if (map.ContainsKey(ch))
                    map[ch]++;
                else
                {
                    map.Add(ch, 1);
                }
            }

            int count = map.Count;

            int i = 0;
            int j = 0;
            int ans = 0;

            while (i + word.Length <= input.Length)
            {
                while (j - i < word.Length)
                {
                    if (map.ContainsKey(input[j]))
                    {
                        map[input[j]]--;
                        if (map[input[j]] == 0)
                            count--;
                    }
                    j++;
                }

                if (j - i == word.Length && count == 0)
                    ans++;

                if (map.ContainsKey(input[i]))
                {
                    if (map[input[i]] == 0)
                        count++;
                    map[input[i]]++;

                }

                i++;

            }

            return ans;

        }
    }
}
