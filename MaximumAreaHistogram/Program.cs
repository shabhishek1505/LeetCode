using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterTrappingProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            //inp 6 2 5 4 5 1 6

            var inp = new int[] { 2, 1, 5, 3, 4, 1 };

            var result = WaterTrapping(inp);

        }

        static int WaterTrapping(int[] input)
        {
            var ngl = NGL(input);
            var ngr = NGR(input);


            for (int i = 0; i < ++ ; i++)
            {
                
            }



            return 0;

        }

        static int[] NGL(int[] inp)
        {
            var sta = new Stack<Tuple<int, int>>();
            var output = new int[inp.Length];
            for (int i = 0; i < inp.Length; i++)
            {


                while (sta.Count > 0)
                {
                    var top = sta.Pop();
                    if (top.Item2 > inp[i])
                    {
                        output[i] = top.Item1;
                        sta.Push(top);
                        break;
                    }
                }
                if (sta.Count == 0)
                {
                    output[i] = -1;
                }
                sta.Push(new Tuple<int, int>(i, inp[i]));
            }
            return output;
        }


        static int[] NGR(int[] inp)
        {
            var sta = new Stack<Tuple<int, int>>();
            var output = new int[inp.Length];
            for (int i = inp.Length - 1; i >= 0; i--)
            {


                while (sta.Count > 0)
                {
                    var top = sta.Pop();
                    if (top.Item2 > inp[i])
                    {
                        output[i] = top.Item1;
                        sta.Push(top);
                        break;
                    }
                }
                if (sta.Count == 0)
                {
                    output[i] = -1;
                }
                sta.Push(new Tuple<int, int>(i, inp[i]));
            }
            return output;
        }

    }
}
