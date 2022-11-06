using Array;
using Xunit;

namespace UnitTests;

public class ArrayFindTests
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 1 }, 3, true)]
    [InlineData(new[] { 1, 0, 1, 1 }, 1, true)]
    [InlineData(new[] { 1, 2, 3, 1, 2, 3 }, 2, false)]
    public void ContainsNearbyDuplicateTests(int[] array, int k, bool output)
    {
        var result = ArrayFind.ContainsNearbyDuplicate(array, k);
        Assert.Equal(result, output);
    }
    
    [Theory]
    [InlineData(new[] { 1, 2, 3, 1 }, 3, true)]
    [InlineData(new[] { 1, 0, 1, 1 }, 1, true)]
    [InlineData(new[] { 1, 2, 3, 1, 2, 3 }, 2, false)]
    public void ContainsNearbyDuplicateDictionaryTests(int[] array, int k, bool output)
    {
        var result = ArrayFind.ContainsNearbyDuplicateDictionary(array, k);
        Assert.Equal(result, output);
    }

}