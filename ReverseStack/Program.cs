using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStack
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new Stack<int>();
            input.Push(4);
            input.Push(9);
            input.Push(1);
            input.Push(7);
            input.Push(6);
            input.Push(26);
            input.Push(98);
            input.Push(56);
            input.Push(45);
            input.Push(21);

            var output = ReverseStacks(input);
        }

        public static Stack<int> ReverseStacks(Stack<int> input)
        {

            if (input.Count == 1)
                return input;

            var last = input.Pop();
            return PushData(ReverseStacks(input), last);

        }

        public static Stack<int> PushData(Stack<int> input, int last)
        {

            if (input.Count == 1)
            {
                var temp = input.Pop();
                input.Push(last);
                input.Push(temp);
                return input;
            }

            var temp1 = input.Pop();
            var sta=PushData(input, last);
            sta.Push(temp1);
            return sta;
        }

    }
}
