using System;
using NUnit.Framework;

namespace DataStructures.UnitTests
{
    [TestFixture]
    public class BinarySearchTreeTests
    {
        private Tree tree;

        [SetUp]
        public void Setup()
        {
            this.tree = new Tree();
        }
    }
}
