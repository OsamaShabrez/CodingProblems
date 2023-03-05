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
}