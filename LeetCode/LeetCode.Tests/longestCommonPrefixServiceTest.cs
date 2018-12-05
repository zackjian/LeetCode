using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
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
        public void Test_Input_List_Have_Flower_Flow_Flight_Return_Fl()
        {
            //// Arrange 
            var target = this.GetService();

            var expected = "Fl";

            //// Act
            var actual = target.Get(Arg.Any<List<string>>());

            //// Assert
            actual.Should().Be(expected);
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
