using System;
using DesignPatterns.Iterator;
using DesignPatterns.Memento;
using NUnit.Framework;

namespace DesignPatterns.UnitTests
{
    [TestFixture]
    public class IteratorUnitTests
    {
        [Test]
        public void CreateIterator_WhenUsed_CurrentHasCurrentItem()
        {
            var history = new BrowseHistory();
            history.Push("a");
            history.Push("b");
            history.Push("c");

            var iterator = history.CreateIterator();
            //Usually you will use a while loop, but we are doing unit test here.
            //while(iterator.HasNext())
            //{
            //    var url = iterator.Current();

            //    iterator.Next();
            //}

            if(iterator.HasNext())
            {
                var url = iterator.Current();
                iterator.Next();

                Assert.That(url, Is.EqualTo("a"));
            }

            if (iterator.HasNext())
            {
                var url = iterator.Current();
                iterator.Next();

                Assert.That(url, Is.EqualTo("b"));
            }

            if (iterator.HasNext())
            {
                var url = iterator.Current();
                iterator.Next();

                Assert.That(url, Is.EqualTo("c"));
            }
        }
    }
}
