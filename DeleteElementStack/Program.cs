using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteElementStack
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

            var output = DeleteElement(input, 26);
        }

        public static Stack<int> DeleteElement(Stack<int> inp, int ele)
        {
            if (inp.Peek() == ele)
            {
                inp.Pop();
                return inp;
            }

            var last = inp.Pop();
            var newStack = DeleteElement(inp, ele);
            newStack.Push(last);
            return newStack;
        }
    }
}
