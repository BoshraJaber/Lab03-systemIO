using System;
using Xunit;
using Lab03_systemIO;

namespace TestingLab03
{
    public class UnitTest1
    {
        [Fact]
        public void TestChallenge1()
        {
            Assert.Equal(6, Program.FirstChallenge("1 2 3"));

        }
        [Fact]
        public void TestChallenge2()
        {
          Assert.Equal(2, Program.SecondChallenge(2, 4));

        }

        [Theory]
        [InlineData("1 2 3", 6)]
        [InlineData("1 2", 0)]
        [InlineData("1 v 3", 3)]
        [InlineData("1 2 3 4 5", 6)]
        public void TestChallenge1_2(string input, int expected)
        {
            Assert.Equal(expected, Program.FirstChallenge(input));
        }
    }
}
