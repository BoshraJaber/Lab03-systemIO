using System;
using Xunit;
using Lab03_systemIO;

namespace TestingLab03
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(6, Program.FirstChallenge("1 2 3"));

        }

        [Theory]
        [InlineData("1 2 3", 6)]
        [InlineData("1 2", 0)]
        [InlineData("1 v 3", 3)]
        [InlineData("1 2 3 4 5", 6)]
        public void Test2(string input, int expected)
        {
            Assert.Equal(expected, Program.FirstChallenge(input));
        }
    }
}
