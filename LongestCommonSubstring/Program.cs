using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace LongestCommonSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string sub1 = "abhishek";
            string sub2 = "hellowabhishekhellow";
            var sub1Length = sub1.Length;
            var sub2Length = sub2.Length;

            var startTime = DateTime.UtcNow;
            var ss = LongestCommonSubStrings(sub1.ToCharArray(), sub2.ToCharArray(), sub1Length, sub2Length);
            Console.WriteLine(ss + "  " + DateTime.UtcNow.Subtract(startTime).TotalMilliseconds);
            Console.ReadLine();
        }

        public static int LongestCommonSubStrings(char[] string1, char[] string2, int sub1Length, int sub2Length)
        {
            var t = new int[sub1Length + 1, sub2Length + 1];
            var highest = 0;
            for (int i = 0; i <= sub1Length; i++)
            {
                for (int j = 0; j <= sub2Length; j++)
                {
                    if (i == 0 || j == 0)
                        t[i, j] = 0;
                    else
                    {
                        if (string1[i - 1] == string2[j - 1])
                        {
                            t[i, j] = 1 + t[i - 1, j - 1];
                            if (t[i, j] > highest)
                                highest = t[i, j];
                        }
                        else
                        {
                            t[i, j] = 0;
                        }
                    }
                }
            }
            return highest;
        }
    }
}
