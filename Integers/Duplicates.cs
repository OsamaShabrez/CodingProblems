namespace Integers;

public static class Duplicates
{
    #region LeetCode-https://leetcode.com/problems/remove-duplicates-from-sorted-array

    public static int RemoveDuplicates(int[] nums)
    {
        if (nums.Length < 2) return nums.Length;

        var uniqueIdx = 1;
        foreach (var v in nums)
            if (nums[uniqueIdx - 1] != v)
                nums[uniqueIdx++] = v;
        return uniqueIdx;
    }

    public static int RemoveDuplicatesFirst(int[] nums)
    {
        var uniqueIdx = 0;
        var uniqueVal = int.MinValue;
        for (var i = 0; i < nums.Length; i++)
            if (nums[i] != uniqueVal)
                nums[uniqueIdx++] = uniqueVal = nums[i];

        return uniqueIdx;
    }

    #endregion
}