using System;

namespace Algorithms2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 55, 65, 45, 35, 25, 10 };
            //string[] numstring  = { "65", "55", "45", "35", "25", "10" };
            int[] xx = BubbleSort(nums);
            //bool isDup = CheckForDuplicates(nums);
            Console.WriteLine(string.Join(",", xx));
        }
        public static int[] BubbleSort(int[] n)
        {
            bool sorted = false;
            int unsorted_until_index = n.Length - 1;
            int tmp = 0;

            while (!sorted)
            {
                sorted = true;
                for (int i = 0; i < unsorted_until_index; i++)
                {
                    if (n[i] > n[i + 1])
                    {
                        sorted = false;
                        tmp = n[i];
                        n[i] = n[i + 1];
                        n[i + 1] = tmp;
                        tmp = 0;
                    }

                }
                unsorted_until_index--;
            }
            return n;
        }

        public static bool CheckForDuplicates(int[] num)
        {
            int steps = 0;

            string[] existingNums = new string[] { };
            existingNums[num.Length] = "1";
            for (int i = 0; i < num.Length; i++)
            {
                steps++;
                // if(existingNums.)
                if (existingNums[num[i]] == null)
                {
                    existingNums[num[i]] = "1";
                }
                else
                {
                    return true;
                }
            }
            Console.WriteLine(steps);
            return false;
        }
    }
}
