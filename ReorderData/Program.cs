using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReorderData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var logs = new string[] { "dig1 8 1 5 1", "let1 art can", "dig2 3 6", "let2 own kit dig", "let3 art zero" };
            var result = ReorderLogFiles(logs);
        }

        public static string[] ReorderLogFiles(string[] logs)
        {
            var ss = logs.OrderByDescending(x => x).ThenByDescending(x => x.Split().Length);

            return ss.ToArray();
        }
    }
}
