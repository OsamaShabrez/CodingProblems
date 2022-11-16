using Integers;
using Xunit;

namespace UnitTests;

public class IntegersTests
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

    [Theory]
    [InlineData(new[] {1, 2}, 1.5)]
    [InlineData(new[] {1, 2, 3}, 2)]
    [InlineData(new[] {6}, 6)]
    [InlineData(new[] {6, 10}, 8.0)]
    [InlineData(new[] {6, 10, 2}, 6.0)]
    [InlineData(new[] {6, 10, 2, 6}, 6.0)]
    [InlineData(new[] {6, 10, 2, 6, 5}, 6.0)]
    [InlineData(new[] {6, 10, 2, 6, 5, 0}, 5.5)]
    [InlineData(new[] {6, 10, 2, 6, 5, 0, 6}, 6.0)]
    [InlineData(new[] {6, 10, 2, 6, 5, 0, 6, 3}, 5.5)]
    [InlineData(new[] {6, 10, 2, 6, 5, 0, 6, 3, 1}, 5.0)]
    [InlineData(new[] {6, 10, 2, 6, 5, 0, 6, 3, 1, 0}, 4.0)]
    [InlineData(new[] {6, 10, 2, 6, 5, 0, 6, 3, 1, 0, 0}, 3.0)]
    public void MedianFinderTest(int[] input, double output)
    {
        var medianFinder = new MedianFinder();
        foreach (var num in input)
        {
            medianFinder.AddNum(num);
        }

        var result = medianFinder.FindMedian();
        Assert.Equal(result, output);
    }

    [Theory]
    [InlineData(10)]
    public void GuessTheNumberTest(int limit)
    {
        GuessTheNumber.HiddenNumber = new Random().Next(0, limit);
        var result = GuessTheNumber.GuessNumber(limit);
        Assert.Equal(result, GuessTheNumber.HiddenNumber);
    }
}