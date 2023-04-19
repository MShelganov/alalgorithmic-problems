using System;
using Alalgorithmic.Lib;
using NUnit.Framework;

namespace Alalgorithmic.Test
{
	[TestFixture]
	public class IsAValidMessageTest
	{
        [Test]
        public void test1()
        {
            Assert.That(Kata.IsAValidMessage("3hey5hello2hi"), Is.EqualTo(true));
        }

        [Test]
        public void test1_1()
        {
            Assert.That(Kata.IsAValidMessage("3he5yhello2hi"), Is.EqualTo(false));
        }

        [Test]
        public void test2()
        {
            Assert.That(Kata.IsAValidMessage("4code13hellocodewars"), Is.EqualTo(true));
        }

        [Test]
        public void test3()
        {
            Assert.That(Kata.IsAValidMessage("3hey5hello2hi5"), Is.EqualTo(false));
        }

        [Test]
        public void test4()
        {
            Assert.That(Kata.IsAValidMessage("code4hello5"), Is.EqualTo(false));
        }

        [Test]
        public void test5()
        {
            Assert.That(Kata.IsAValidMessage("1a2bb3ccc4dddd5eeeee"), Is.EqualTo(true));
        }

        [Test]
        public void test6()
        {
            Assert.That(Kata.IsAValidMessage(""), Is.EqualTo(true));
        }

        [Test]
        public void test7()
        {
            Assert.Multiple(() =>
            {
                Assert.That(Kata.IsAValidMessage("11"), Is.EqualTo(false));
                Assert.That(Kata.IsAValidMessage("hello5"), Is.EqualTo(false));
                Assert.That(Kata.IsAValidMessage("2hi2"), Is.EqualTo(false));
                Assert.That(Kata.IsAValidMessage("jhgjhgjhg"), Is.EqualTo(false));
            });
        }
    }
}

