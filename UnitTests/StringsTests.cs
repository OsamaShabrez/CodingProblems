using Strings;
using Xunit;

namespace UnitTests;

public class StringsTests
{
    [Theory]
    [InlineData("abbaca", "ca")]
    [InlineData("azxxzy", "ay")]
    [InlineData("s", "s")]
    public void RemoveDuplicatesTest(string str, string output)
    {
        var result = StringManipulation.RemoveDuplicatesMemory(str);
        Assert.Equal(output, result);

        result = StringManipulation.RemoveDuplicates(str);
        Assert.Equal(output, result);
    }

    [Theory]
    [InlineData("leEeetcode", "leetcode")]
    [InlineData("abBAcC", "")]
    [InlineData("s", "s")]
    public void MakeTheStringGreatTest(string str, string output)
    {
        var result = StringManipulation.MakeTheStringGreat(str);
        Assert.Equal(output, result);
    }

    [Theory]
    [InlineData("(1+(4+5 +2)-3)+(6+8)", 23)]
    [InlineData("2-1 + 2 ", 3)]
    [InlineData("1 + 1", 2)]
    public void BasicCalculatorTest(string input, int output)
    {
        var result = BasicCalculator.Calculate(input);
        Assert.Equal(output, result);
    }
    
    [Theory]
    [InlineData("pwwkew", 3)]
    [InlineData("abcabcbb", 3)]
    [InlineData("bbbbb", 1)]
    [InlineData("aab", 2)]
    [InlineData("dvdf", 3)]
    [InlineData("abba", 2)]
    public void LengthOfLongestSubstringTest(string input, int output)
    {
        var result = StringManipulation.LengthOfLongestSubstring(input);
        Assert.Equal(output, result);
    }

    [Theory]
    [InlineData("aa", "a", false)]
    [InlineData("aa", "a*", true)]
    [InlineData("aa", ".*", true)]
    [InlineData("aab", "c*a*b*", true)]
    [InlineData("aaa", "ab*ac*a", true)]
    [InlineData("aaa", "a*a", true)]
    [InlineData("aaaa", "a*aa", true)]
    public void RegularExpressionMatchingTest(string input, string pattern, bool output)
    {
        var result = RegularExpressionMatching.IsPatternMatching(input, pattern);
        Assert.Equal(output, result);
    }
}