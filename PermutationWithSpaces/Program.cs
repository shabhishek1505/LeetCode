using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermutationWithSpaces
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintPermutation("A","BCDEF");
        }

        public static void PrintPermutation(string output,string input)
        {
            
            if (input.Length == 0)
            {
                Console.WriteLine(output+input);
                return;
            }

            var newInp = input.Substring(1);

            PrintPermutation(output+"_"+input.ToCharArray().First(),newInp);

            PrintPermutation(output + input.ToCharArray().First(), newInp);

        }
    }
}
