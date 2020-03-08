using System;
using NUnit.Framework;
namespace SortingAlgorithms.UnitTests
{
    [TestFixture]
    public class SelectionSortTests
    {
        private SelectionSort _selectionSort;

        [SetUp]
        public void Setup()
        {
            _selectionSort = new SelectionSort();
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
            _selectionSort.SortAsc(array);

            Assert.That(array, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(null, null)]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { 9, 8, 4, 1 }, new int[] { 9, 8, 4, 1 })]
        [TestCase(new int[] { 1, 3, 3, 4 }, new int[] { 4, 3, 3, 1 })]
        [TestCase(new int[] { 1, 7, 3, 4, 9 }, new int[] { 9, 7, 4, 3, 1 })]
        public void SortDesc_WhenCalled_SortArrayDesc(int[] array, int[] expectedResult)
        {
            _selectionSort.SortDesc(array);

            Assert.That(array, Is.EqualTo(expectedResult));
        }
    }
}
