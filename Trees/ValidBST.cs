namespace Trees;

public class ValidBst
{
    public class TreeNode
    {
        public readonly int Val;
        public readonly TreeNode? Left;
        public readonly TreeNode? Right;

        public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
        {
            Val = val;
            Left = left;
            Right = right;
        }
    }

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
}