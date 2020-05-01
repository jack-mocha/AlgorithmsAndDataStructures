using System;
using DesignPatterns.Strategy;
using NUnit.Framework;

namespace DesignPatterns.UnitTests
{
    [TestFixture]
    public class StrategyUnitTests
    {
        [Test]
        public void TestMethod1()
        {
            var imageStorage = new ImageStorage(new JpegCompressor(), new BlackAndWhiteFilter());

            imageStorage.Store("a");
        }
    }
}
