using System;
using NUnit.Framework;

namespace StringManipulation.UnitTests
{
    [TestFixture]
    public class StringUtilsTests
    {
        private StringUtils _stringUtils;

        [SetUp]
        public void Setup()
        {
            _stringUtils = new StringUtils();
        }

        [Test]
        [TestCase(null, "")]
        [TestCase("", "")]
        [TestCase("   ", "")]
        [TestCase("Hello", "olleH")]
        public void ReverseString_WhenCalled_ReturnsReversedString(string input, string expectedResult)
        {
            var result = _stringUtils.ReverseString(input);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(null, "")]
        [TestCase("", "")]
        [TestCase("   ", "")]
        [TestCase("Hello", "olleH")]
        public void ReverseString2_WhenCalled_ReturnsReversedString(string input, string expectedResult)
        {
            var result = _stringUtils.ReverseString2(input);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(null, "")]
        [TestCase("", "")]
        [TestCase("   ", "")]
        [TestCase("Hello", "olleH")]
        public void ReverseString3_WhenCalled_ReturnsReversedString(string input, string expectedResult)
        {
            var result = _stringUtils.ReverseString3(input);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(null, 0)]
        [TestCase("", 0)]
        [TestCase("   ", 0)]
        [TestCase("HaeiouHAEIOUh", 10)]
        public void CountVowels_WhenCalled_ReturnsNumberOfVowels(string input, int expectedResult)
        {
            var result = _stringUtils.CountVowels(input);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(null, "")]
        [TestCase("", "")]
        [TestCase("   ", "")]
        [TestCase("Trees are beautiful", "beautiful are Trees")]
        [TestCase("   Trees are beautiful", "beautiful are Trees")]
        [TestCase("Trees are beautiful   ", "beautiful are Trees")]
        [TestCase("Trees   are beautiful", "beautiful are   Trees")]
        [TestCase("Trees", "Trees")]
        public void ReverseWords_WhenCalled_ReturnReversedWords(string input, string expectedResult)
        {
            var result = _stringUtils.ReverseWords(input);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(null, "")]
        [TestCase("", "")]
        [TestCase("   ", "")]
        [TestCase("Trees are beautiful", "beautiful are Trees")]
        [TestCase("   Trees are beautiful", "beautiful are Trees")]
        [TestCase("Trees are beautiful   ", "beautiful are Trees")]
        [TestCase("Trees   are beautiful", "beautiful are   Trees")]
        [TestCase("Trees", "Trees")]
        public void ReverseWords2_WhenCalled_ReturnReversedWords(string input, string expectedResult)
        {
            var result = _stringUtils.ReverseWords2(input);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
