using System;
using NUnit.Framework;

namespace WorkingWithVisualStudio.Tests
{
    [TestFixture]
    public class Test1
    {

        [Test]
        public void t1()
        {
            int a = 1;
            Assert.That((a == 1), Is.True);
        }

    }
}
