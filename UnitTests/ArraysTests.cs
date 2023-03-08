using Array;
using Xunit;

namespace UnitTests;

public class ArraysTests
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 1 }, 3, true)]
    [InlineData(new[] { 1, 0, 1, 1 }, 1, true)]
    [InlineData(new[] { 1, 2, 3, 1, 2, 3 }, 2, false)]
    public void ContainsNearbyDuplicateTests(int[] array, int k, bool output)
    {
        var result = ArrayFindDuplicate.ContainsNearbyDuplicate(array, k);
        Assert.Equal(output, result);
    }
    
    [Theory]
    [InlineData(new[] { 1, 2, 3, 1 }, 3, true)]
    [InlineData(new[] { 1, 0, 1, 1 }, 1, true)]
    [InlineData(new[] { 1, 2, 3, 1, 2, 3 }, 2, false)]
    public void ContainsNearbyDuplicateDictionaryTests(int[] array, int k, bool output)
    {
        var result = ArrayFindDuplicate.ContainsNearbyDuplicateDictionary(array, k);
        Assert.Equal(output, result);
    }

    [Theory]
    [InlineData(new[] { 1, 3, 5, 2, 7, 5 }, 1, 5, 2)]
    [InlineData(new[] { 1, 1, 1, 1 }, 1, 1, 10)]
    public void CountSubArraysATests(int[] nums, int min, int max, int output)
    {
        var result = SubArrays.CountSubArrays(nums, min, max);
        Assert.Equal(output, result);
    }

    [Theory]
    [InlineData(new[] { 2, 3, 4, 7, 11 }, 5, 9)]
    [InlineData(new[] { 1, 2, 3, 4 }, 2, 6)]
    public void FindKthPositiveTests(int[] num, int k, int output)
    {
        var result = KthValues.FindKthPositive(num, k);
        Assert.Equal(output, result);
    }

    [Theory]
    [InlineData(new[] { 3, 6, 7, 11 }, 8, 4)]
    [InlineData(new[] { 30, 11, 23, 4, 20 }, 5, 30)]
    [InlineData(new[] { 30, 11, 23, 4, 20 }, 6, 23)]
    [InlineData(new[] {332484035,524908576,855865114,632922376,222257295,690155293,112677673,679580077,337406589,290818316,877337160,901728858,679284947,688210097,692137887,718203285,629455728,941802184}, 823855818, 14)]
    public void MinEatingSpeedTest(int[] piles, int h, int output)
    {
        var result = KthValues.MinEatingSpeed(piles, h);
        Assert.Equal(output, result);
    }
}