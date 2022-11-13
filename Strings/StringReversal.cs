using System.Text;

namespace Strings;

public class StringReversal
{
    #region LeetCode-https://leetcode.com/problems/reverse-words-in-a-string/description/

    // Runtime 92 ms Beats 84.49% Memory 39.1 MB Beats 8.75%
    public static string ReverseWords(string s)
    {
        var stack = new Stack<string>();
        var pairs = s.Split(' ');
        foreach (var p in pairs)
            if (!string.IsNullOrWhiteSpace(p))
                stack.Push(p);

        var sb = new StringBuilder(s.Length);
        while (stack.Count > 0) sb.Append(stack.Pop() + " ");
        sb.Remove(sb.Length - 1, 1);

        return sb.ToString();
    }

    #endregion
}