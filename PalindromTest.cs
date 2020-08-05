using System;
using Xunit;

namespace CodeTest.UnitTest
{
    public class PalindromTest
    {
        [Fact]
        public void PositiveTest()
        {
            string name = "abcba";
            bool isPalindrom = Palindrom.CheckPalindrome(name);
            Assert.True(isPalindrom);

        }

        [Fact]
        public void NegetiveTest()
        {
            string name = "chandru";
            bool isPalindrom = Palindrom.CheckPalindrome(name);
            Assert.False(isPalindrom);

        }
    }
}
