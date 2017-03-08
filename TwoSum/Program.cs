using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] num1 = new int[] { 3, 2, 4 };
            var num = TwoSum(num1, 7);
            Console.WriteLine("Array Index = " + num[0] + "," + num[1]);
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            var result = new int[] { };
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return result;
        }
    }
}
