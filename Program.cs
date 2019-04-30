using System;

namespace Algorithms2
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] nums = { 99, 65, 55, 35, 11 };
			//string[] numstring  = { "65", "55", "45", "35", "25", "10" };
			//int[] xx = BubbleSort(nums);
			//int[] xx = SelectionSort(nums);
			int[] xx = InsertionSort(nums);
			//bool isDup = CheckForDuplicates(nums);
			Console.WriteLine(string.Join(",", xx));
		}
		public static int[] BubbleSort(int[] n)
		{
			Console.WriteLine("Bubble Sort");
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

			string[] existingNums = new string[0] { };
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

		public static int[] SelectionSort(int[] num)
		{
			Console.WriteLine("Selection Sort");
			int temp = 0;
			int comparisons = 0;
			int swaps = 0;
			int lowestNumberIndex = 0;
			for (int i = 0; i < num.Length; i++)
			{
				lowestNumberIndex = i;
				for (int j = i + 1; j < num.Length; j++)
				{
					if (num[j] < num[lowestNumberIndex])
					{
						lowestNumberIndex = j;
					}
					comparisons++;
				}
				if (lowestNumberIndex != i)
				{
					temp = num[i];
					num[i] = num[lowestNumberIndex];
					num[lowestNumberIndex] = temp;
					swaps++;
				}

			}
			Console.WriteLine("swaps==>" + swaps);
			Console.WriteLine("comparisons==>" + comparisons);
			return num;
		}

		public static int[] InsertionSort(int[] num)
		{
			Console.WriteLine("Insertion Sort");
			int position = 0;
			int temp = 0;
			int comparisons = 0;
			for (int i = 1; i < num.Length; i++)
			{
				position = i;
				temp = num[i];
				while (position > 0 && num[position - 1] > temp)
				{
					num[position] = num[position - 1];
					position--;
					num[position] = temp;
					comparisons++;
				}
			}
			//Console.WriteLine("swaps==>" + swaps);
			Console.WriteLine("comparisons==>" + comparisons);
			return num;
		}
	}


}
