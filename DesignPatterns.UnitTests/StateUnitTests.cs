using System;
using DesignPatterns.Memento;
using DesignPatterns.State;
using NUnit.Framework;

namespace DesignPatterns.UnitTests
{
    [TestFixture]
    public class StateUnitTests
    {
        [Test]
        public void TestMethod1()
        {
            var canvas = new Canvas();

            canvas.SetToolType(new SelectionTool());
            canvas.MouseDown();
            canvas.MouseUp();

            canvas.SetToolType(new BrushTool());
            canvas.MouseDown();
            canvas.MouseUp();
        }
    }
}
