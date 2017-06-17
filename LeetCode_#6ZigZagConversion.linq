<Query Kind="Program" />

void Main()
{
	var solution = new Solution();
	var result = solution.Convert("PAYPALISHIRING", 3);

	Console.Write(result);
}

public class Solution
{
	public string Convert(string s, int numRows)
	{
		StringBuilder sb = new StringBuilder();

		if (s.Length <= 1 || numRows > s.Length)
		{
			return s;
		}
		
		var sList = new List<string>();		
		foreach(char c in s)
		{
			sList.Add(c.ToString());
		}

		//// 第一行 跟 最後一行
		//// num + (n + n-  2)

		//// TODO: 效能待調教
		//// 中間行數
		//// num  + 2		
		for (int i = 1; i <= numRows; i++)
		{
			var result = "";
			var runCount = 0;
			//// 第一行 & 最後一行
			if (i == 1 || (i == numRows))
			{
				runCount = i;
				while (runCount <= sList.Count)
				{
					result += sList[runCount - 1];
					runCount += (2 * numRows) - 2;
				}
			}
			else
			{
				runCount = i;
				while (runCount <= sList.Count)
				{
					result += sList[runCount - 1];
					runCount += 2;
				}
			}

			sb.Append(result);
		}
		
		return sb.ToString();
	}
}