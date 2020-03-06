using System;
using NUnit.Framework;

namespace SortingAlgorithms.UnitTests
{
    [TestFixture]
    public class BubbleSortTests
    {
        private BubbleSort _bubbleSort;

        [SetUp]
        public void Setup()
        {
            _bubbleSort = new BubbleSort();
        }

        [Test]
        [TestCase(null, null)]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] {9, 8, 4, 1}, new int[] {1, 4, 8, 9})]
        [TestCase(new int[] {9, 4, 4, 1}, new int[] {1, 4, 4, 9})]
        [TestCase(new int[] {1, 2, 3, 4}, new int[] {1, 2, 3, 4})]
        public void SortAsc_WhenCalled_SortArrayAsc(int[] array, int[] expectedResult)
        {
            _bubbleSort.SortAsc(array);

            Assert.That(array, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(null, null)]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { 9, 8, 4, 1 }, new int[] { 9, 8, 4, 1 })]
        [TestCase(new int[] { 1, 3, 3, 4 }, new int[] { 4, 3, 3, 1 })]
        public void SortDesc_WhenCalled_SortArrayAsc(int[] array, int[] expectedResult)
        {
            _bubbleSort.SortDesc(array);

            Assert.That(array, Is.EqualTo(expectedResult));
        }
    }
}
