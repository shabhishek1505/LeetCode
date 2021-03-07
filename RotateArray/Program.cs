using System;

namespace RotateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var inp = new int[] { 1, 2, 3, 4 };
            Rotate1(inp, 2);
        }

        public static void Rotate1(int[] nums, int k)
        {
           
            k = k % nums.Length;
            int count = 0;
            for (int start = 0; count < nums.Length; start++)
            {
                int pointer = start;
                int temp = nums[pointer];
                do
                {
                    int i = (pointer + k) % (nums.Length);
                    int temp1 = nums[i];
                    nums[i] = temp;
                    temp = temp1;
                    pointer = i;
                    count++;
                    
                } while (start != pointer);
            }
            
        }

        public static void Rotate(int[] nums, int k)
        {

            int i = nums.Length - k - 1;
            int temp = 0;

            temp = nums[i];
            while (i > 0)
            {
                int temp1 = nums[i + k];
                nums[i + k] = temp;
                temp = nums[nums.Length - i - 2];
                nums[nums.Length - i - 2] = temp1;
                i--;
            }
        }


    }
}
