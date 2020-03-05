using System;
using NUnit.Framework;

namespace SearchingAlgorithms.UnitTests
{
    [TestFixture]
    public class SearchAlgorithmsTests
    {
        private Search _search;

        [SetUp]
        public void Setup()
        {
            _search = new Search();
        }

        [Test]
        [TestCase(null, 4, -1)]
        [TestCase(new int[] { }, 4, -1)]
        [TestCase(new int[] { 1,2,3,4 }, 4, 3)]
        [TestCase(new int[] { 1,2,3,4 }, 5, -1)]
        public void LinearSearch_WhenCalled_ReturnsTargetIndexInTheArray(int[] array, int target, int expectedResult)
        {
            var result = _search.LinearSearch(array, target);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(null, 5, -1)]
        [TestCase(new int[] { }, 5, -1)]
        [TestCase(new int[] { 1, 5, 10, 15, 20, 25 }, 5, 1)]
        [TestCase(new int[] { 1, 5, 10, 15, 20, 25 }, 4, -1)]
        [TestCase(new int[] { 1, 5, 10, 15, 20, 25 }, 6, -1)]
        public void BinarySearchRecursive_WhenCalled_ReturnsTargetIndexInTheArray(int[] array, int target, int expectedResult)
        {
            var result = _search.BinarySearchRecursive(array, target);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(null, 5, -1)]
        [TestCase(new int[] { }, 5, -1)]
        [TestCase(new int[] { 1, 5, 10, 15, 20, 25 }, 5, 1)]
        [TestCase(new int[] { 1, 5, 10, 15, 20, 25 }, 4, -1)]
        [TestCase(new int[] { 1, 5, 10, 15, 20, 25 }, 6, -1)]
        public void BinarySearchIterative_WhenCalled_ReturnsTargetIndexInTheArray(int[] array, int target, int expectedResult)
        {
            var result = _search.BinarySearchIterative(array, target);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
