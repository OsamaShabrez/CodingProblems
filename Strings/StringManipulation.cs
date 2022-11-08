using System.Text;

namespace Strings;

public static class StringManipulation
{
    #region LeetCode-https://leetcode.com/problems/make-the-string-great/

    // Runtime 85 ms Beats 92.4% Memory 38 MB Beats 43.36%
    public static string MakeTheStringGreat(string s) {
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