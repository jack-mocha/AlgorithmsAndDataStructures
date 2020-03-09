using System;
using NUnit.Framework;
namespace SortingAlgorithms.UnitTests
{
    [TestFixture]
    public class QuickSortTests
    {
        private QuickSort _quickSort;

        [SetUp]
        public void Setup()
        {
            _quickSort = new QuickSort();
        }

        [Test]
        [TestCase(null, null)]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { 9, 8, 4, 1 }, new int[] { 1, 4, 8, 9 })]
        [TestCase(new int[] { 9, 4, 4, 1 }, new int[] { 1, 4, 4, 9 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4 })]
        public void SortAsc_WhenCalled_SortArrayAsc(int[] array, int[] expectedResult)
        {
            _quickSort.SortAsc(array);

            Assert.That(array, Is.EqualTo(expectedResult));
        }
    }
}
