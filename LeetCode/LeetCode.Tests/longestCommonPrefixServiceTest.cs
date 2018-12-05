using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Services;
using NSubstitute;
using Xunit;

namespace LeetCode.Tests
{
    public class longestCommonPrefixServiceTest
    {
        /// <summary>
        /// Given	
        /// When	
        /// Then	
        /// </summary>
        [Fact]
        public void Test_MethName()
        {
            //// Arrange
            var target = this.GetService();

            //// Act
            var actual = target.Get(Arg.Any<List<string>>());

            //// Assert
        }

        /// <summary>
        /// 取得Service
        /// </summary>
        /// <returns></returns>
        private LongestCommonPrefixService GetService()
        {
            return new LongestCommonPrefixService();
        }
    }
}
