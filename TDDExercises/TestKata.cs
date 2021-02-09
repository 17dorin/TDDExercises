using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using MathStuff;

namespace TDDExercises
{
    public class TestKata
    {
        [Theory]
        [InlineData(0, "zero")]
        [InlineData(1, "one")]
        [InlineData(2, "two")]
        [InlineData(3, "three")]
        [InlineData(4, "four")]
        [InlineData(5, "five")]
        [InlineData(6, "six")]
        [InlineData(7, "seven")]
        [InlineData(8, "eight")]
        [InlineData(9, "nine")]
        public void TestConvert(int num, string expected)
        {
            Kata k = new Kata();

            string actual = k.Convert(num);

            Assert.Equal(actual, expected);
        }
    }
}
