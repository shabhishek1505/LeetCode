using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KthSymbolGrammar
{
    class Program
    {
        static void Main(string[] args)
        {
            var output = GetKthGrammar(4, 0);
        }


        public static int GetKthGrammar(int n, int k)
        {
            if (n == 0)
                return 0;

            var temp = GetKthGrammar(n - 1, k / 2);
            if (k % 2 == 0)
                return temp;

            return temp == 0 ? 1 : 0;

        }

    }
}
