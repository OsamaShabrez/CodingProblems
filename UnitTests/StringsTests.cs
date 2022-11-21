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
        Assert.Equal(result, output);

        result = StringManipulation.RemoveDuplicates(str);
        Assert.Equal(result, output);
    }

    [Theory]
    [InlineData("leEeetcode", "leetcode")]
    [InlineData("abBAcC", "")]
    [InlineData("s", "s")]
    public void MakeTheStringGreatTest(string str, string output)
    {
        var result = StringManipulation.MakeTheStringGreat(str);
        Assert.Equal(result, output);
    }

    [Theory]
    [InlineData("(1+(4+5 +2)-3)+(6+8)", 23)]
    [InlineData("2-1 + 2 ", 3)]
    [InlineData("1 + 1", 2)]
    public void BasicCalculatorTest(string input, int output)
    {
        var result = BasicCalculator.Calculate(input);
        Assert.Equal(result, output);
    }
}