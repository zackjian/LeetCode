using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Services
{
    public class TwoSumService : ITwoSumService
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var result = string.Empty;

            var length = nums.Length;

            for (int i = 0; i < length; i++)
            {
                var num = nums[i];

                for (int j = i + 1; j < length; j++)
                {
                    if (num + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return null;
        }
    }
}
