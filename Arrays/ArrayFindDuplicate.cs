namespace Array;

public static class ArrayFindDuplicate
{
    # region LeetCode-https://leetcode.com/problems/contains-duplicate-ii/

    // Runtime 1584 ms Beats 10.99% Memory 58.1 MB Beats 20.97%
    public static bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        for (var i = 0; i < nums.Length - 1; i++)
        for (var j = i + 1; j < nums.Length && Math.Abs(i - j) <= k; j++)
            if (nums[i] == nums[j])
                return true;

        return false;
    }

    // Runtime 453 ms Beats 45.1% Memory 55.1 MB Beats 27.28%
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

    #endregion
}