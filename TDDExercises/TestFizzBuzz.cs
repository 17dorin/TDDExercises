using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using MathStuff;

namespace TDDExercises
{
    public class TestFizzBuzz
    {
        [Fact]
        public void TestEven()
        {
            //Arrange
            FizzBuzz fb = new FizzBuzz();

            //Act
            string actual = fb.OddEvenOrPrime(4);
            string expected = "even";

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestOdd()
        {
            FizzBuzz fb = new FizzBuzz();

            string actual = fb.OddEvenOrPrime(15);
            string expected = "odd";

            Assert.Equal(actual, expected);
        }

        [Fact]
        public void TestRange()
        {
            FizzBuzz fb = new FizzBuzz();

            string actual = fb.OddEvenOrPrime(0);
            string expected = "error";

            Assert.Equal(actual, expected);

            actual = fb.OddEvenOrPrime(101);

            Assert.Equal(actual, expected);

        }
        [Theory]
        [InlineData(5, "prime")]
        [InlineData(4, "even")]
        [InlineData(9, "odd")]

        public void TestAll(int num, string expected)
        {
            FizzBuzz fb = new FizzBuzz();

            string actual = fb.OddEvenOrPrime(num);

            Assert.Equal(actual, expected);
        }

        [Fact]
        public void TestPrime()
        {
            FizzBuzz fb = new FizzBuzz();

            bool actual = fb.CheckPrime(3);
            bool expected = true;

            Assert.Equal(actual, expected);
        }
    }
}
