<Query Kind="Program" />

void Main()
{
	var nums1 = new int[] { 2, 1 };
	var nums2 = new int[] { 4, 3 };
	
	var solution = new Solution();	
	var result = solution.FindMedianSortedArrays(nums1,nums2);
	
	Console.Write("The median is " + result);
}

public class Solution
{
	public double FindMedianSortedArrays(int[] nums1, int[] nums2)
	{
		var nums1Copy = new int[nums1.Length];
		nums1.CopyTo(nums1Copy, 0);

		var nums2Copy = new int[nums2.Length];
		nums2.CopyTo(nums2Copy, 0);

		//// 數組排列
		var nums1OrderBy = nums1Copy.OrderBy(s => s).ToArray();
		var nums2OrderBy = nums2Copy.OrderBy(s => s).ToArray();

		//// 奇數 / 偶數 判斷		
		var nums1Median = this.GetMedianValue(nums1OrderBy);
		var nums2Median = this.GetMedianValue(nums2OrderBy);
		
		return (nums1Median + nums2Median) / 2;
	}

	private double GetMedianValue(int[] nums)
	{
		double result = 0;
		if (nums.Length % 2 == 0)
		{
			result = (nums[nums.Length / 2] + nums[nums.Length / 2 - 1]) / 2.0;
		}
		else
		{
			result = nums[nums.Length / 2 + 1];
		}

		return result;
	}
}
