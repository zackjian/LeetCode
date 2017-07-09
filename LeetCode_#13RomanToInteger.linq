<Query Kind="Program" />

void Main()
{
	var solution = new Solution();

	var result = solution.RomanToInt("MCMXCVI");

	Console.Write("RomanToInt = " + result);
}

public class Solution
{
	public int RomanToInt(string s)
	{
		var result = 0;

		var arrayList = s.ToCharArray();

		for (int i = 0; i < arrayList.Length; i++)
		{
			var previousNum = (int)Enum.Parse(typeof(RomanNumbersEnum), arrayList[i].ToString());
			var nextNum = (i + 1) >= arrayList.Length ? 0 : (int)Enum.Parse(typeof(RomanNumbersEnum), arrayList[i + 1].ToString());

			if (nextNum > previousNum)
			{
				result += nextNum - previousNum;
				//// 因為合併計算故 ++
				i++;
			}
			else
			{
				result += previousNum;
			}
		}

		return result;
	}
}

public enum RomanNumbersEnum
{
	I = 1,

	V = 5,

	X = 10,

	L = 50,

	C = 100,

	D = 500,

	M = 1000
}

