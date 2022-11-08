using LinkLists;
using Xunit;

namespace UnitTests;

public class LinkListsTests
{
    public static IEnumerable<object> AddTwoNumbersData =>
        new List<object>
        {
            new object[]
            {
                new[] { 2, 4, 3 },
                new[] { 5, 6, 4 },
                new[] { 7, 0, 8 }
            },
            new object[]
            {
                new[] { 0 },
                new[] { 0 },
                new[] { 0 }
            },
            new object[]
            {
                new[] { 9,9,9,9,9,9,9 },
                new[] { 9,9,9,9 },
                new[] { 8,9,9,9,0,0,0,1 }
            }
        };

    private static ListNode? PrepareAddTwoNumbersTest(int[] array)
    {
        ListNode? ln = null;
        ListNode? temp = null;
        foreach (var v in array)
            if (temp == null)
            {
                ln = new ListNode(v);
                temp = ln;
            }
            else
            {
                temp.Next = new ListNode(v);
                temp = temp.Next;
            }

        return ln;
    }

    [Theory]
    [MemberData(nameof(AddTwoNumbersData))]
    public void AddTwoNumbersTest(int[] a1, int[] a2, int[] a3)
    {
        var l1 = PrepareAddTwoNumbersTest(a1);
        var l2 = PrepareAddTwoNumbersTest(a2);
        var l3 = PrepareAddTwoNumbersTest(a3);

        var result = LinkListAddition.AddTwoNumbers(l1, l2);

        while (l3 != null || result != null)
        {
            Assert.Equal(result?.val, l3?.val);
            l3 = l3?.Next;
            result = result?.Next;
        }
    }
}