namespace Array;

public static class SubArrays
{
    #region https://leetcode.com/problems/count-subarrays-with-fixed-bounds/

    public static long CountSubArrays(int[] nums, int minK, int maxK)
    {
        var minIndex = -1;
        var maxIndex = -1;
        var current = 0;
        long result = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] > maxK || nums[i] < minK)
            {
                minIndex = maxIndex = -1;
                current = i + 1;
            }

            if (nums[i] == minK)
                minIndex = i;

            if (nums[i] == maxK)
                maxIndex = i;

            result += Math.Max(0, Math.Min(maxIndex, minIndex) - current + 1);
        }

        return result;
    }

    #endregion
}