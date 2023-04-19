using System;
using Alalgorithmic.Lib;
using NUnit.Framework;

namespace Alalgorithmic.Test
{
	[TestFixture]
	public class MaxSequenceTest
	{
        [Test]
        public void Test0() => Assert.That(Kata.MaxSequence(Array.Empty<int>()), Is.EqualTo(0));

        [Test]
        public void Test1() => Assert.That(Kata.MaxSequence(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }), Is.EqualTo(6));
    }
}

