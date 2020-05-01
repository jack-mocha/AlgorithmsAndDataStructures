using System;
using DesignPatterns.Template;
using NUnit.Framework;

namespace DesignPatterns.UnitTests
{
    [TestFixture]
    public class TemplateUnitTests
    {
        [Test]
        public void TestMethod1()
        {
            var task = new TransferMoneyTask(new AuditTrail());
            task.Execute();
        }
    }
}
