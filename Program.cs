using System;

namespace Algorithms2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 65, 55, 45, 35, 25, 10 };
            int[] xx = BubbleSort(nums);
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
    }
}

