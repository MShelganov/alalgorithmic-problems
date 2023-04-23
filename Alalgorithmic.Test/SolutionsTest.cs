using System;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using Alalgorithmic.Lib;
using NUnit.Framework;

namespace Alalgorithmic.Test
{
	[TestFixture]
	public class SolutionsTest
	{
		[Test]
		public void TwoSumArrayTest1()
        {
            Assert.Multiple(() =>
            {
                Assert.That(Solution.TwoSum(new int[] { 2, 7, 11, 15 }, 9), Is.EqualTo(new int[] { 0, 1 }));
                Assert.That(Solution.TwoSum(new int[] { 3, 2, 4 }, 6), Is.EqualTo(new int[] { 1, 2 }));
                Assert.That(Solution.TwoSum(new int[] { 3, 3 }, 6), Is.EqualTo(new int[] { 0, 1 }));
                Assert.That(Solution.TwoSum(new int[] { 2, 7, 11, 15, 3 }, 6), Is.EqualTo(Array.Empty<int>()));
                Assert.That(Solution.TwoSum(new int[] { 3, 2, 3 }, 6), Is.EqualTo(new int[] { 0, 2 }));
            });
        }

        [Test]
        public void IsPalindromeTest()
        {
            Assert.Multiple(() =>
            {
                Assert.That(Solution.IsPalindrome(121), Is.True);
                Assert.That(Solution.IsPalindrome(-121), Is.False);
                Assert.That(Solution.IsPalindrome(123), Is.False);
                Assert.That(Solution.IsPalindrome(10), Is.False);
            });
        }

        /// <summary>
        /// Given an input string s and a pattern p, implement regular expression matching with support for '.' and '*' where:
        ///  - '.' Matches any single character.​​​​
        ///  - '*' Matches zero or more of the preceding element.
        ///  The matching should cover the entire input string (not partial).
        /// </summary>
        [Test]
        public void RegularExpressionMatching()
        {
            Assert.Multiple(() =>
            {
                Assert.That(Solution.IsMatch("ab", "a"), Is.False);
                Assert.That(Solution.IsMatch("aa", "a*"), Is.True);
                Assert.That(Solution.IsMatch("ab", ".*"), Is.True);
                Assert.That(Solution.IsMatch("abc", "a.."), Is.True);
                Assert.That(Solution.IsMatch("abc", ".b."), Is.True);
            });
        }
    }
}

