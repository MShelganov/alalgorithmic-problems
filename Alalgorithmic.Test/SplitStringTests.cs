using Alalgorithmic.Lib;
using NUnit.Framework;

namespace Alalgorithmic.Test;

[TestFixture]
public class SplitStringTests
{
    /// <summary>
    /// Complete the solution so that it splits the string into pairs of two characters.
    /// If the string contains an odd number of characters then it should replace
    /// the missing second character of the final pair with an underscore ('_').
    /// Examples:
    ///     * 'abc' =>  ['ab', 'c_']
    ///     * 'abcdef' => ['ab', 'cd', 'ef']
    /// </summary>
    [Test]
    public void BasicTests()
    {
        Assert.Multiple(() =>
        {
            Assert.That(SplitString.Solution("abc"), Is.EqualTo(new string[] { "ab", "c_" }));
            Assert.That(SplitString.Solution("abcdef"), Is.EqualTo(new string[] { "ab", "cd", "ef" }));
        });
    }
}
