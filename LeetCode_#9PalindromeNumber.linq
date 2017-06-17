<Query Kind="Program" />

void Main()
{
	var solution = new Solution();

	var result = solution.IsPalindrome(-2147447412);

	Console.Write("IsPalindrome: " + result.ToString());
}

public class Solution
{
	public bool IsPalindrome(int x)
	{
		if (x < 0 || x > Math.Pow(2, 32) - 1) return false;
		if (x < 10) return true;
		
		var x1 = x;
		var result = 0;
		while (x1 != 0)
		{
			result = (result * 10) + (x1 % 10);
			x1 = x1 / 10;
		}

		if (x == result)
		{
			return true;
		}
		else
		{
			return false;
		}
	}
}
