using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using LeetCode.Services;
using Xunit;

namespace LeetCode.Tests
{
    public class TwoSumServiceTest
    {
        /// <summary>
        /// Given	
        /// When	
        /// Then	
        /// </summary>
        [Fact]
        public void Test_Two_Number_Sum_Equal_Target_Return_Number_Index()
        {
            //// Arrange
            var target = this.GetService();

            var stubNums = new int[]
            {
                2,7,11,15
            };

            var stubTarget = 9;

            var expected = new int[] { 0, 1 };

            //// Act
            var actual = target.TwoSum(stubNums, stubTarget);

            //// Assert
            actual.Should().BeEquivalentTo(expected);
        }

        /// <summary>
        /// 取得Service
        /// </summary>
        /// <returns></returns>
        private TwoSumService GetService()
        {
            return new TwoSumService();
        }
    }
}
