using System.Text;

namespace Integers;

public class LargestNumber
{
    #region LeetCode-https: //leetcode.com/problems/maximum-69-number/submissions/838995477/

    // Runtime 21 ms Beats 95.24% Memory 26.6 MB Beats 13.69%
    public static int MaximumNumberFrom69Cpu(int num)
    {
        var str = new StringBuilder(num.ToString());
        for (var i = 0; i < str.Length; i++)
            if (str[i] == '6')
            {
                str[i] = '9';
                break;
            }

        return int.Parse(str.ToString());
    }

    // Runtime 38 ms Beats 60.12% Memory 25.2 MB Beats 84.52%
    public static int MaximumNumberFrom69Memory(int num)
    {
        var str = new StringBuilder(num.ToString());
        for (var i = 0; i < str.Length; i++)
            if (str[i] == '6')
            {
                str[i] = '9';
                return int.Parse(str.ToString());
            }

        return num;
    }

    // Runtime 37 ms Beats 64.88% Memory 25.4 MB Beats 48.81%
    public static int MaximumNumberFrom69(int num)
    {
        var str = num.ToString();
        for (var i = 0; i < str.Length; i++) // 9669 = 3 => 10^3
            if (str[i] == '6')
                return (int)(num + 3 * Math.Pow(10, str.Length - i - 1));

        return num;
    }

    #endregion
}