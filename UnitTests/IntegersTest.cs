using Integers;
using Xunit;

namespace UnitTests;

public class IntegersTest
{
    [Theory]
    [InlineData(9669, 9969)]
    [InlineData(9996, 9999)]
    [InlineData(9999, 9999)]
    public void Maximum69NumberTests(int num, int output)
    {
        var result = LargestNumber.MaximumNumberFrom69Cpu(num);
        Assert.Equal(result, output);

        result = LargestNumber.MaximumNumberFrom69Memory(num);
        Assert.Equal(result, output);

        result = LargestNumber.MaximumNumberFrom69(num);
        Assert.Equal(result, output);
    }
}