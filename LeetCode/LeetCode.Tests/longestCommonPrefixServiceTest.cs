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

            var stubData = new List<string>
            {
                "Flower",
                "Flow",
                "Flight"
            };

            var expected = "Fl";

            //// Act
            var actual = target.Get(stubData);

            //// Assert
            actual.Should().Be(expected);
        }

        /// <summary>
        /// Given	
        /// When	
        /// Then	
        /// </summary>
        [Fact]
        public void Test_Input_List_Have_Dog_Racecar_Car_Return_Empty()
        {
            //// Arrange
            var target = this.GetService();

            var stubData = new List<string>
            {
                "Dog",
                "Racecar",
                "Car"
            };

            var expected = string.Empty;

            //// Act
            var actual = target.Get(stubData);

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
