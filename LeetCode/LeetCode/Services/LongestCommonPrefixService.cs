using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Services
{
    /// <summary>
    /// LongestCommonPrefixService
    /// </summary>
    public class LongestCommonPrefixService : ILongestCommonPrefixService
    {
        public string Get(string[] array)
        {
            var result = string.Empty;

            var minLength = array.Min(s => s.Length);
            
            for (int i = 0; i < minLength; i++)
            {
                var wordList = new List<string>();

                foreach (var item in array)
                {
                    var charArray = item.ToCharArray();

                    wordList.Add(charArray[i].ToString());
                }

                if (wordList.GroupBy(s => s).LongCount() > 1)
                {
                    return result;
                }

                result += wordList[0];
            }

            return result;
        }
    }
}
