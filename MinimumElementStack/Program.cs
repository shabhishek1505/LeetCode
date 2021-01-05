using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MinimumElementStack
{
    class Program
    {
        private static Stack<int> eleStack = new Stack<int>();
        private static int min = Int32.MaxValue;
        static void Main(string[] args)
        {

            var ssss = DateTime.Parse("10/07/2020 08:20:47", CultureInfo.InvariantCulture);


            var datess = DateTime.Now.ToString(new CultureInfo("en-US"));

            var datess2 = DateTime.Now.ToString(new CultureInfo("es"));

            var datess3 = DateTime.Now.ToString(new CultureInfo("en"));
            var datess4 = DateTime.Now.ToString(new CultureInfo("am"));
            var datess5 = DateTime.Now.AddHours(12).ToString(new CultureInfo("cs").DateTimeFormat.FullDateTimePattern.Replace("ss", "tt"));
            var datess6 = DateTime.Now.AddHours(12).ToString(new CultureInfo("de").DateTimeFormat.FullDateTimePattern.Replace("ss", "tt"));
            var datess7 = DateTime.Now.ToString(new CultureInfo("fr"));
            var datess8 = DateTime.Now.ToString(new CultureInfo("hr"));
            var datess9 = DateTime.Now.ToString(new CultureInfo("sk"));
            var datess10 = DateTime.Now.ToString(new CultureInfo("tr"));

            var shortTime = new CultureInfo("en").DateTimeFormat.ShortTimePattern;
            var shortDate = new CultureInfo("en").DateTimeFormat.ShortDatePattern;

            var hh = DateTime.Now.ToString(shortDate + shortTime);


              
            while (true)
            {
                var input = Convert.ToInt32(Console.ReadLine());
                if (input < min)
                {
                    if (eleStack.Count > 0)
                    {
                        var temp = input;
                        input = input * 2 - min;
                        min = temp;
                    }

                }
                eleStack.Push(input);

                Console.WriteLine("Do you want to exit");
                if (Convert.ToBoolean(Console.ReadLine()))
                    break;
            }
        }

        static int Min()
        {
            return min;
        }

        static int Pop()
        {
            var top = eleStack.Pop();
            if (top < min)
                return 2 * min - top;
            return top;

        }
    }
}
