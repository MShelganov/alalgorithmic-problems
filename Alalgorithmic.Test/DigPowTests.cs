using System;
using Alalgorithmic.Lib;
using NUnit.Framework;

namespace Alalgorithmic.Test
{

    [TestFixture]
    public class DigPowTests
    {
        [Test]
        public void Test1()
        {
            Assert.That(SumDigPower.DigPow(89, 1), Is.EqualTo(1));
        }

        [Test]
        public void Test2()
        {
            Assert.That(SumDigPower.DigPow(92, 1), Is.EqualTo(-1));
        }

        [Test]
        public void Test3()
        {
            Assert.That(SumDigPower.DigPow(46288, 3), Is.EqualTo(51));
        }

        [Test]
        public void Test4()
        {
            Assert.Multiple(() =>
            {
                CollectionAssert.AreEqual(SumDigPower.SumDigPow(1, 10), new long[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
                CollectionAssert.AreEqual(SumDigPower.SumDigPow(1, 100), new long[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 89 });
                CollectionAssert.AreEqual(SumDigPower.SumDigPow(100, 100), Array.Empty<long>());
                CollectionAssert.AreEqual(SumDigPower.SumDigPow(10, 100), new long[] { 89 });
                CollectionAssert.AreEqual(SumDigPower.SumDigPow(90, 100), Array.Empty<long>());
                CollectionAssert.AreEqual(SumDigPower.SumDigPow(90, 150), new long[] { 135 });
                CollectionAssert.AreEqual(SumDigPower.SumDigPow(50, 150), new long[] { 89, 135 });
                CollectionAssert.AreEqual(SumDigPower.SumDigPow(10, 150), new long[] { 89, 135 });
            });
        }
    }
}
