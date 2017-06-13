<Query Kind="Program" />

void Main()
{
	var solution = new Solution();
	var result = solution.LengthOfLongestSubstring("pwwkew");
	
	Console.Write(result);
}

public class Solution
{
	public int LengthOfLongestSubstring(string s)
	{		
		var maxLengthList = new List<int>();
		for (int i = 0; i < s.Length; i++)
		{
			var list = new List<string>();
			foreach (char c in s.Substring(i, s.Length - i))
			{
				if (list.Contains(c.ToString()))
				{
					break;
				}				
				list.Add(c.ToString());
			}
			maxLengthList.Add(list.Count);
		}
		
		return maxLengthList.Max();
	}
}