using System;
using DesignPatterns.Memento;
using NUnit.Framework;
namespace DesignPatterns.UnitTests
{
    [TestFixture]
    public class MementoUnitTests
    {
        [Test]
        public void Restore_WhenCalled_ReturnPreviousState()
        {
            var editor = new Editor2();
            var history = new History();

            editor.SetContent("a");

            history.Push(editor.CreateState());
            editor.SetContent("b");
            
            history.Push(editor.CreateState());
            editor.SetContent("c");
            editor.Restore(history.Pop());
            var result = editor.GetContent();

            Assert.That(result, Is.EqualTo("b"));
        }

        [Test]
        public void Restore_WhenNoPreviousState_ReturnNull()
        {
            var editor = new Editor2();
            var history = new History();

            editor.Restore(history.Pop());
            var result = editor.GetContent();

            Assert.That(result, Is.EqualTo(null));
        }
    }
}
