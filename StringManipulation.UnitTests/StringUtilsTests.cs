using System;
using NUnit.Framework;

namespace StringManipulation.UnitTests
{
    [TestFixture]
    public class StringUtilsTests
    {
        [Test]
        public void ReverseString3_NullString_ReturnsEmptyString()
        {
            var stringUtils = new StringUtils();
            string input = null;

            var result = stringUtils.ReverseString3(input);
            
            Assert.That(result, Is.EqualTo(String.Empty));
        }

        [Test]
        public void ReverseString3_EmptyString_ReturnsEmptyString()
        {
            var stringUtils = new StringUtils();
            string input = String.Empty;

            var result = stringUtils.ReverseString3(input);

            Assert.That(result, Is.EqualTo(String.Empty));
        }

        [Test]
        public void ReverseString3_Hello_ReturnsolleH()
        {
            var stringUtils = new StringUtils();
            string input = "Hello";

            var result = stringUtils.ReverseString3(input);

            Assert.That(result, Is.EqualTo("olleH"));
        }

        [Test]
        public void CountVowels_NullString_ReturnsZero()
        {
            var stringUtils = new StringUtils();
            string input = null;

            var result = stringUtils.CountVowels(input);

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void CountVowels_EmptyString_ReturnsZero()
        {
            var stringUtils = new StringUtils();
            string input = String.Empty;

            var result = stringUtils.CountVowels(input);

            Assert.That(result, Is.EqualTo(0));
        }


        [Test]
        public void CountVowels_WhiteSpaceString_ReturnsZero()
        {
            var stringUtils = new StringUtils();
            string input = "     ";

            var result = stringUtils.CountVowels(input);

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void CountVowels_HaeiouHAEIOUh_ReturnsTen()
        {
            var stringUtils = new StringUtils();
            string input = "HaeiouHAEIOUh";

            var result = stringUtils.CountVowels(input);

            Assert.That(result, Is.EqualTo(10));
        }
    }
}
