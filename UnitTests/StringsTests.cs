using Strings;
using Xunit;

namespace UnitTests;

public class StringsTests
{
    [Theory]
    [InlineData("leEeetcode", "leetcode")]
    [InlineData("abBAcC", "")]
    [InlineData("s", "s")]
    public void MakeTheStringGreat(string str, string output)
    {
        var result = StringManipulation.MakeTheStringGreat(str);
        Assert.Equal(result, output);
    }
}