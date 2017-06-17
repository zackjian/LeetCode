<Query Kind="Program" />

void Main()
{
	var solution = new Solution();
	var result = solution.LongestPalindrome("banana");
	
	Console.Write("Output: " + result);
}

public class Solution
{
	//// 最長迴文數
	public string LongestPalindrome(string s)
	{
		var sList = new List<string>();
		var maxStr = "";

		foreach (char c in s)
		{
			sList.Add(c.ToString());
		}
		sList.Reverse();

		var s1 = this.GetList(s);
		var s2 = this.GetList(string.Join("",sList));

		for (int i = 0; i < s1.Count; i++)
		{
			if (s2.Contains(s1[i]))
			{
				maxStr = s1[i].Length > maxStr.Length ? s1[i] : maxStr;
			}
		}

		return maxStr;
	}
	
	public List<string> GetList(string s)
	{
		var s1 = s;
		var result = new List<string>();

		//// 將一組字串拆分出多個字串
		for (int i = 0; i < s1.Length; i++)
		{
			for (int j = 1; j <= s1.Length - i; j++)
			{
				var val = s1.Substring(i, j);
				result.Add(val);
			}
		}

		return result;
	}
}










