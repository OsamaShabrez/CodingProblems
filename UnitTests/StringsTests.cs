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
}