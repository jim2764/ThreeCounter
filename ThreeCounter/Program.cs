using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeCounter
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// { 0, 3, 3, 0, 0, 3, 3, 3 }
			int[] array1 = { 0, 3, 3, 0, 0, 3, 3, 3 };
			Console.WriteLine(CounterThree(array1));

			// { 0, 3, 3, 0, 0, 3, 0, 3, 0, 3}
			int[] array2 = { 0, 3, 3, 0, 0, 3, 0, 3, 0, 3 };
			Console.WriteLine(CounterThree(array2));

			// {0, 3, 0, 0}
			int[] array3 = { 0, 3, 0, 0 };
			Console.WriteLine(CounterThree(array3));
		}

		static int CounterThree(int[] nums)
		{
			int max = 0;                       // 目前計數最大3的個數
			int counter = 0;                   // 計數3有幾個

			for (int i = 0; i < nums.Length; i++)
			{
				// i index停留不動
				if (nums[i] == 3)
				{
					int j = i;
					counter = 0;
					// 利用 j 繼續走計數有幾個3
					while (j < nums.Length && nums[j] == 3)
					{
						counter++;
						j++;
					}
					i = j;   // 將本來停留下來的 i 跳到 j的位置
					if (max < counter)
						max = counter;
				}
			}
			return max * 3;
		}
	}
}
