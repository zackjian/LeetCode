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
        public string Get(List<string> list)
        {
            var result = string.Empty;

            var minLength = list.Min(s => s.Length);

            var tempWord = string.Empty;

            for (int i = 0; i < minLength; i++)
            {
                result += tempWord;

                tempWord = string.Empty;

                foreach (var item in list)
                {
                    var charArray = item.ToCharArray();
                    var word = charArray[i].ToString();

                    if (string.IsNullOrEmpty(tempWord))
                    {
                        tempWord = word;
                        continue;
                    }

                    if (tempWord != word)
                    {
                        return result;
                    }                    
                }
            }

            return result;
        }
    }
}
