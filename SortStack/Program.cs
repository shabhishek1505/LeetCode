using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortStack
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


            var output = SortStack(input);
        }


        public static Stack<int> SortStack(Stack<int> inp)
        {
            if (inp.Count == 1)
                return inp;
            var last = inp.Pop();

            return InsertELement(SortStack(inp), last);

        }


        public static Stack<int> InsertELement(Stack<int> inp, int ins)
        {
            if (inp.Count == 0)
            {
                var newSt= new Stack<int>();
                newSt.Push(ins);
                return newSt;
            }

            if (inp.Peek() < ins)
            {
                inp.Push(ins);
                return inp;
            }

            var last = inp.Pop();

            var sta = InsertELement(inp, ins);
            sta.Push(last);
            return sta;

        }


    }
}
