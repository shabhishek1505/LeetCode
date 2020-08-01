using System;

namespace LongestCommonSubsequenceTopDown
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

        public static int LongestCommonSubsequence(char[] sub1, char[] sub2, int sub1Length, int sub2Length)
        {
            var t = new int[sub1Length + 1, sub2Length + 1];

            for (int i = 0; i < sub1Length + 1; i++)
            {
                for (int j = 0; j < sub2Length + 1; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        t[i, j] = 0;
                    }

                    else if (sub1[i - 1] == sub2[j - 1])
                    {
                        t[i, j] = 1 + t[i - 1, j - 1];
                    }

                    else
                    {
                        t[i, j] = Math.Max(t[i - 1, j], t[i, j - 1]);
                    }

                }
            }

            return t[sub1Length, sub2Length];

        }
    }
}
