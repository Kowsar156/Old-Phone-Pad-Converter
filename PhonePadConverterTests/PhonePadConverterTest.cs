using Xunit;
using System;

namespace PhonePadConverter.Tests
{
    public class PhonePadConverterTest
    {
        [Theory]
        // Examples
        [InlineData("33#", "e")]
        [InlineData("227*#", "b")]
        [InlineData("4433555 555666#", "hello")]
        [InlineData("8 88777444666*664#", "turing")]

        // * first
        [InlineData("*9#", "w")]

        // multiple * first
        [InlineData("***8#", "t")]

        // only *
        [InlineData("*#", "")]

        // multiple * only
        [InlineData("*****#", "")]

        // blank input
        [InlineData("#", "")]

        // typing number
        [InlineData("2222#", "2")]

        // pressing more than the number of characters
        [InlineData("666666#", "n")]

        // typing both letter and number
        [InlineData("5567 777775555#", "kmp75")]

        // space
        [InlineData("550607#", "k m p")]

        // deleting space
        [InlineData("550*60*7#", "kmp")]

        // special character
        [InlineData("6330104433777#", "me & her")]

        public void TestOldPhonePad(string input, string expected)
        {
            string result = OldPhonePad.PhonePadConverter.OldPhonePad(input);
            Assert.Equal(expected, result);
        }
    }
}