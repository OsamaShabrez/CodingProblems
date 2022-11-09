using DataStructures;
using Xunit;

namespace UnitTests;

public class DataStructuresTests
{
    [Theory]
    [InlineData(new[] {100,80,60,70,60,75,85}, new[] {1,1,1,2,1,4,6})]
    public void StockSpannerTests(int[] prices, int[] spans)
    {
        var spanner = new StockSpanner();
        for (var i = 0; i < prices.Length; i++)
        {
            var result = spanner.Next(prices[i]);
            Assert.Equal(result, spans[i]);
        }
    }
}