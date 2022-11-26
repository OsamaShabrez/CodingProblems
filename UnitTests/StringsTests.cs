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
    }}