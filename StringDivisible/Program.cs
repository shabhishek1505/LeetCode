using System;
using System.Linq;

namespace StringDivisible
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "bcdbcdbcdbcd";
            var t = "bcdbcd";

            if (s.Length % t.Length == 0)
            {
                var newT = "";
                var lenCount = s.Length / t.Length;

                for (int i = 0; i < lenCount; i++)
                {
                    newT=newT + t;
                }

                if (s == newT)
                {

                    for (int i = 2; i < t.Length / 2; i++)
                    {
                        if (t.Length % i == 0)
                        {
                            var sub=t.Substring(0, t.Length / i);

                            var newSub = "";
                            for (int j = 0; j < t.Length/sub.Length; j++)
                            {
                                newSub=newSub+sub;
                            }

                            if (newSub == t)
                            {
                                Console.WriteLine(sub.Length);
                            }
                        }
                    }

                }

            }
            else
            {
                Console.WriteLine(-1);
            }

        }




    }
}
