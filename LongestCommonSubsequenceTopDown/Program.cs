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

        }
    }
}
