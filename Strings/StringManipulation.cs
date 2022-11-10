using System.Text;

namespace Strings;

public static class StringManipulation
{
    #region LeetCode-https: //leetcode.com/problems/remove-all-adjacent-duplicates-in-string/

    // Runtime 83 ms Beats 99.4% Memory 46.1 MB Beats 16.75%
    public static string RemoveDuplicates(string s)
    {
        var stack = new Stack<char>(s.Length);
        foreach (var c in s)
            if (stack.Count == 0)
            {
                stack.Push(c);
            }
            else
            {
                if (stack.Peek() == c)
                    stack.Pop();
                else
                    stack.Push(c);
            }

        return new string(stack.Reverse().ToArray());
    }

    // Runtime 215 ms Beats 46.41% Memory 37.8 MB Beats 94.74%
    public static string RemoveDuplicatesMemory(string s)
    {
        var sb = new StringBuilder(s);
        for (var i = 0; i < sb.Length - 1; i++)
        {
            if (sb[i] != sb[i + 1]) continue;

            sb.Remove(i, 2);
            i -= i == 0 ? 1 : 2;
        }

        return sb.ToString();
    }

    #endregion

    #region LeetCode-https: //leetcode.com/problems/make-the-string-great/

    // Runtime 85 ms Beats 92.4% Memory 38 MB Beats 43.36%
    public static string MakeTheStringGreat(string s)
    {
        if (s.Length is 0 or 1) // empty or 1 char
            return s;

        var sb = new StringBuilder(s);
        for (var i = 0; i < sb.Length - 1; i++)
        {
            if (Math.Abs(sb[i] - sb[i + 1]) != 32) continue;

            sb.Remove(i, 2);
            i = -1;
        }

        return sb.ToString();
    }

    #endregion
}