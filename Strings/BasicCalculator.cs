using System.Text.RegularExpressions;

namespace Strings;
// https://leetcode.com/problems/basic-calculator/description/
/**
 * Runtime 245 ms Beats 10.34% Memory 107.6 MB Beats 8.15%
 * Avoid regex pattern matching for tokenization
 */
public static class BasicCalculator
{
    public static int Calculate(string input)
    {
        var stack = new Stack<int>();
        // var tokens = input.Split(new[] {' ', '+','-','(',')'}, StringSplitOptions.TrimEntries);
        var matches = Regex.Matches(input, @"([+\- ()])|([0-9])+");
        if (matches.Count < 3)
            return int.Parse(input);

        var result = 0;
        var op = 1;
        for (var i = 0; i < matches.Count; i++)
        {
            if (string.IsNullOrWhiteSpace(matches[i].Value)) continue;;
            switch (matches[i].Value)
            {
                case "+":
                    op = 1;
                    break;
                case "-":
                    op = -1;
                    break;
                case "(":
                    stack.Push(result);
                    stack.Push(op);
                    result = 0;
                    op = 1;
                    break;
                case ")":
                    result *= stack.Pop();
                    result += stack.Pop();
                    break;
                default:
                    result += int.Parse(matches[i].Value) * op;
                    break;
            }
        }
        return result;
    }
}
