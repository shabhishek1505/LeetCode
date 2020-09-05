using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectCapital
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DetectCapitalUse("ggg"));
        }

        public static bool DetectCapitalUse(string word)
        {
            var charArray = word.ToCharArray();
            var noCaps = 0;
            if (charArray.Length == 1)
                return true;
            bool dec = charArray[0].ToString().ToUpper() == charArray[0].ToString();

            foreach (var t in charArray)
            {
                if (t.ToString().ToUpper() == t.ToString())
                {
                    noCaps++;
                }
            }

            if (dec && (noCaps == charArray.Length || noCaps == 1))
            {
                return true;
            }
            else if(noCaps==0)
            {
                return true;
            }
            return false;
        }
    }
}
