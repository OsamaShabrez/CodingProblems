namespace LinkLists;

public static class LinkListFindMiddleNode
{
    public class ListNode
    {
        private int _val;
        public readonly ListNode? Next;

        public ListNode(int val = 0, ListNode? next = null)
        {
            _val = val;
            Next = next;
        }
    }

    #region LeetCode-https://leetcode.com/problems/middle-of-the-linked-list/

    // Runtime 89 ms Beats 89.99% Memory 38.2 MB Beats 6.77%
    public static ListNode? MiddleNode(ListNode? head)
    {
        return head?.Next == null ? head : FindMiddleNode(head.Next, head.Next.Next);
    }

    private static ListNode? FindMiddleNode(ListNode? idx, ListNode? dIdx)
    {
        return dIdx?.Next == null ? idx : FindMiddleNode(idx!.Next, dIdx.Next.Next);
    }

    #endregion
}