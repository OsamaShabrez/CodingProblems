namespace Array;

public static class ArrayFind
{
    public static bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        for (var i = 0; i < nums.Length - 1; i++)
        for (var j = i + 1; j < nums.Length && Math.Abs(i - j) <= k; j++)
            if (nums[i] == nums[j])
                return true;

        return false;
    }

    public static bool ContainsNearbyDuplicateDictionary(int[] nums, int k)
    {
        var map = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            if (map.ContainsKey(nums[i]) && Math.Abs(map[nums[i]] - i) <= k)
                return true;
            map[nums[i]] = i;
        }

        return false;
    }
}