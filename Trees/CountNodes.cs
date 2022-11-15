namespace Trees;

public class CountTreeNodes
{
    #region LeetCode-https://leetcode.com/problems/count-complete-tree-nodes/

    // Runtime 137 ms Beats 75.35% Memory 42 MB Beats 25.35%
    public static int CountNodes(TreeNode? root)
    {
        if (root == null)
            return 0;

        var count = 0;
        while (root != null)
        {
            var leftLeftDepth = LeftDepth(root.Left);
            var leftRightDepth = RightDepth(root.Left);
            var rightLeftDepth = LeftDepth(root.Right);
            var rightRightDepth = RightDepth(root.Right);


            if (leftLeftDepth != rightRightDepth)
                count++;
            else
                // perfect (full) binary tree
                return count + (int)Math.Pow(2, leftLeftDepth + 1) - 1;
            if (leftLeftDepth == leftRightDepth)
                // left subtree is perfect
                count += (int)Math.Pow(2, leftLeftDepth) - 1;
            else
                root = root.Left; // can only fire once; either left or right

            if (rightRightDepth == rightLeftDepth)
                // right subtree is perfect
                count += (int)Math.Pow(2, rightRightDepth) - 1;
            else
                root = root!.Right; // can only fire once; either left or right

            if (leftRightDepth != rightLeftDepth)
                // leftRightDepth and rightLeftDepth different but complete
                return count;
        }

        return count;
    }

    private static int LeftDepth(TreeNode? node)
    {
        if (node == null) return 0;
        var count = 1;
        while ((node = node.Left) != null)
            count++;

        return count;
    }

    private static int RightDepth(TreeNode? node)
    {
        if (node == null) return 0;
        var count = 1;
        while ((node = node.Right) != null)
            count++;

        return count;
    }

    #endregion
}