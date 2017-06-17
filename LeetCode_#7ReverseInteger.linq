<Query Kind="Program" />

void Main()
{
	int val = 1534236469;
	var solution = new Solution();
	
	Console.Write(solution.Reverse(val));
}

public class Solution
{
	public int Reverse(int x)
	{
		checked
		{
			try
			{

				var x1 = x;
				var result = 0;
				while (x1 != 0)
				{
					var num = x1 % 10;
					result = result * 10 + num;

					x1 = x1 / 10;
				}

				return result;
			}
			catch (Exception)
			{
				return 0;
			}
		}
	}
}
