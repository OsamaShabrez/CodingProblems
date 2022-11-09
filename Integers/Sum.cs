namespace Integers;

public class Sum
{
    #region LeetCode-https://leetcode.com/problems/two-sum/

    // Runtime 152 ms Beats 96.47% Memory 44.7 MB Beats 6.76%
    public static int[] TwoSum(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>(nums.Length);
        for (var i = 0; i < nums.Length; i++)
            if (dict.ContainsKey(target - nums[i]))
                return new[] { i, dict[target - nums[i]] };
            else
            {
                if (!dict.ContainsKey(nums[i]))
                    dict.Add(nums[i], i);
            }
        throw new ArgumentException("No valid combination available");
    }

    // Runtime 170 ms Beats 91.49% Memory 43.8 MB Beats 23.72%
    public static int[] TwoSum2(int[] nums, int target)
    {
        if (nums.Length == 2)
            return new[] { 0, 1 };

        for (var i = 0; i < nums.Length - 1; i++)
        for (var j = i + 1; j < nums.Length; j++)
            if (nums[i] + nums[j] == target)
                return new[] { i, j };
        throw new ArgumentException("No valid combination available");
    }

    #endregion
}