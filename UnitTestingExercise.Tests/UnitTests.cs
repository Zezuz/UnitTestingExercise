using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(5, 10, 20, 35)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var m = new UnitTestMethods();
            //Act
            var actual = m.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 20, -10)]
        public void Subtract(int minuend, int subtrahend, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Subtract(minuend, subtrahend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10,10,100)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var newMulti = new UnitTestMethods();
            //Act
            var actual = newMulti.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(100, 10, 10)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsTheSumOver10()
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.IsSumOver10();
            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void Greeting()
        {
            //Arrange
            var newTest = new UnitTestMethods();
            //Act
            var actual = newTest.Greeting();
            //Assert
            Assert.Equal("Hello World", actual);
        }
    }
}
