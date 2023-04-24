using System;
using Alalgorithmic.Lib;
using NUnit.Framework;

namespace Alalgorithmic.Test
{
    [TestFixture]
    public class LeetCodeSolutionTest
    {
        [Test]
        public void IntToRomanTest()
        {
            Assert.Multiple(() =>
            {
                Assert.That(LeetCodeSolution.IntToRoman(3), Is.EqualTo("III"));
                Assert.That(LeetCodeSolution.IntToRoman(58), Is.EqualTo("LVIII"));
                Assert.That(LeetCodeSolution.IntToRoman(1994), Is.EqualTo("MCMXCIV"));
                Assert.That(LeetCodeSolution.IntToRoman(4), Is.EqualTo("IV"));
                Assert.That(LeetCodeSolution.IntToRoman(5), Is.EqualTo("V"));
            });
        }

        [Test]
        public void RomanToIntTest()
        {
            Assert.Multiple(() =>
            {
                Assert.That(LeetCodeSolution.RomanToInt("III"), Is.EqualTo(3));
                Assert.That(LeetCodeSolution.RomanToInt("LVIII"), Is.EqualTo(58));
                Assert.That(LeetCodeSolution.RomanToInt("MCMXCIV"), Is.EqualTo(1994));
                Assert.That(LeetCodeSolution.RomanToInt("IV"), Is.EqualTo(4));
                Assert.That(LeetCodeSolution.RomanToInt("V"), Is.EqualTo(5));
            });
        }
    }
}
