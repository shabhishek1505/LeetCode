using System;
using System.IO;

namespace EgyptionFraction
{
    class Program
    {
        //Every positive fraction can be represented as sum of unique unit fractions.
        //A fraction is unit fraction if numerator is 1 and denominator is a positive integer,
        //for example 1/3 is a unit fraction.Such a representation is called Egyptian Fraction as it was used by ancient Egyptians
        static void Main(string[] args)
        {
            PrintEgyptionFraction(6, 14);
        }



        static void PrintEgyptionFraction(int nu, int de)
        {

            if (nu == 0 || de == 0)
            {
                return;
            }

            if (de % nu == 0)
            {
                Console.Write("1/" + de / nu);
                return;
            }

            if (nu % de == 0)
            {
                Console.Write(nu / de);
                return;
            }

            if (nu > de)
            {
                Console.Write(nu / de + " + ");
                PrintEgyptionFraction(nu % de, de);
                return;
            }

            int n = de / nu + 1;

            Console.Write("1/" + n + " + ");

            PrintEgyptionFraction(nu * n - de, de * n);

        }
    }
}
