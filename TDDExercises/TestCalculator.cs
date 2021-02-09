using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using MathStuff;

namespace TDDExercises
{
    public class TestCalculator
    {
        //While using Xunit, [Fact] declares the following code is a test
        //Using a combination of the [Theory] tag with several [InlineData] tags, you can pass many different parameters to the same test
        [Theory]
        [InlineData(4,3)]
        [InlineData(4,6)]
        [InlineData(2, 2)]
        [InlineData(0, 101)]
        [InlineData(-20, 10)]
        public void TestAdd(int num1, int num2)
        {
            //All unit tests follow this pattern:

            //Arrange - set up needed obejcts or classes
            Calculator c = new Calculator();

            //Act - run the code you want to test
            int actual = c.Add(num1, num2);
            int expected = num1 + num2;
            
            //Assert - compare the expected result against actual result
            //The assert class outputs to the test explorer
            Assert.Equal(actual, expected);
        }
    }
}
