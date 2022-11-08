namespace LinkLists;

public static class LinkListAddition
{
    #region LeetCode-https: //leetcode.com/problems/add-two-numbers/

    // Runtime 162 ms Beats 58.61% Memory 39.2 MB Beats 78.39%
    public static ListNode AddTwoNumbers(ListNode? l1, ListNode? l2)
    {
        ListNode? l3 = null;
        ListNode? temp = null;
        var carryForward = 0;
        while (l1 != null || l2 != null)
        {
            var additionResult = (l1?.val ?? 0) + (l2?.val ?? 0) + carryForward;
            carryForward = additionResult / 10;
            var newNode = new ListNode(additionResult % 10, null);
            if (temp == null)
                l3 = temp = newNode;
            else
            {
                temp.Next = newNode;
                temp = temp.Next;
            }

            l1 = l1?.Next;
            l2 = l2?.Next;
        }

        if (carryForward > 0)
            temp!.Next = new ListNode(carryForward, null);

        return l3!;
    }

    #endregion
}