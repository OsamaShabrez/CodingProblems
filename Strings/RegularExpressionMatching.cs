using System.Text.RegularExpressions;

namespace Strings;

public static class RegularExpressionMatching
{
    #region https://leetcode.com/problems/regular-expression-matching/

    // Runtime 155 ms Beats 46.26% Memory 40.1 MB Beats 14.46%
    public static bool IsPatternMatching(string s, string p)
    {
        return Regex.IsMatch(s, $"^{p}$");
    }

    // not complete
    public static bool IsPatternMatchingStack(string s, string p)
    {
        if (p.Equals(".*"))
            return true;

        var stringStack = new Stack<char>();
        var patternStack = new Stack<char>();
        foreach (var c in s)
        {
            stringStack.Push(c);
        }

        foreach (var c in p)
        {
            patternStack.Push(c);
        }

        char current;
        while (stringStack.TryPeek(out current))
        {
            
        }
        return true;
    }

    // requires look ahead logic
    public static bool IsPatternMatchingIterative(string s, string p)
    {
        if (p.Equals(".*"))
            return true;

        int sIdx = 0, pIdx = 0;
        do
        {
            if (s[sIdx] == p[pIdx] || p[pIdx] == '.')
            {
                sIdx++;
                pIdx++;
                continue;
            }

            // greedy matching
            if (p[pIdx] == '*')
            {
                if (p[pIdx - 1] == '.')
                {
                    sIdx++;
                }

                if (p[pIdx - 1] == s[sIdx])
                {
                    sIdx++;
                }
                
                pIdx++;
                continue;
            }

            if (pIdx < p.Length && p[pIdx + 1] == '*')
            {
                pIdx++;
                continue;
            }

            return false;
        } while (sIdx < s.Length && pIdx < p.Length);

        if (sIdx == s.Length && (pIdx == p.Length || (pIdx == p.Length - 1 && p[^1] == '*')))
            return true;

        return false;
    }
    #endregion
}