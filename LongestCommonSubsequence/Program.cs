using System;
using System.Collections.Generic;

namespace LongestCommonSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string sub1 = "abhishekkfnskgjskjdfglkjsjdfhglkjsdkjfhgkjsdkjfgjksdfgk";
            string sub2 = "absserkasdfhjasljkdjfiaosfkahiurdaskhfjalskpoaklsndfkhajkgshjkdga";
            var sub1Length = sub1.Length;
            var sub2Length = sub2.Length;

            var startTime = DateTime.UtcNow;
            var ss = LongestCommonSubsequence(sub1.ToCharArray(), sub2.ToCharArray(), sub1Length, sub2Length);
            Console.WriteLine(ss + "  " + DateTime.UtcNow.Subtract(startTime).TotalMilliseconds);
            Console.ReadLine();
        }
        private static Dictionary<string, int> memo = new Dictionary<string, int>();

        public static int LongestCommonSubsequence(char[] sub1, char[] sub2, int sub1Length, int sub2Length)
        {
            if (sub2Length == 0 || sub1Length == 0)
                return 0;

            if (memo.ContainsKey(string.Concat(sub1Length, sub2Length)))
                return memo[string.Concat(sub1Length, sub2Length)];

            if (sub1[sub1Length - 1] == sub2[sub2Length - 1])
            {
                var res = 1 + LongestCommonSubsequence(sub1, sub2, sub1Length - 1, sub2Length - 1);
                memo.Add(string.Concat(sub1Length, sub2Length), res);
                return res;
            }
            var res1 = Math.Max(LongestCommonSubsequence(sub1, sub2, sub1Length - 1, sub2Length),
                LongestCommonSubsequence(sub1, sub2, sub1Length, sub2Length - 1));
            memo.Add(string.Concat(sub1Length, sub2Length), res1);
            return res1;
        }
    }
}
