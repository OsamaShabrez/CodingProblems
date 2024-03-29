﻿namespace Trees;

public class ValidBst
{
    #region LeetCode-https://leetcode.com/problems/validate-binary-search-tree/submissions/837929893/

    public static bool IsValidBst(TreeNode? root)
    {
        if (root == null)
            return true;

        if (root.Left != null && MaxVal(root.Left) >= root.Val)
            return false;

        if (root.Right != null && MinVal(root.Right) <= root.Val)
            return false;

        return IsValidBst(root.Left) && IsValidBst(root.Right);
    }

    private static int MaxVal(TreeNode? node)
    {
        if (node == null)
            return int.MinValue;

        var maxLeft = MaxVal(node.Left);
        var maxRight = MaxVal(node.Right);

        var result = maxLeft > maxRight ? maxLeft : maxRight;
        return result < node.Val ? node.Val : result;
    }

    private static int MinVal(TreeNode? node)
    {
        if (node == null)
            return int.MaxValue;

        var minLeft = MinVal(node.Left);
        var minRight = MinVal(node.Right);

        var result = minLeft < minRight ? minLeft : minRight;
        return result > node.Val ? node.Val : result;
    }

    #endregion
}