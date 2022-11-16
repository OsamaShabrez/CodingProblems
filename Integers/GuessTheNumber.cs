namespace Integers;
// https://leetcode.com/problems/guess-number-higher-or-lower/
// Runtime 25 ms Beats 90.67% Memory 26.2 MB Beats 20.47%
public class GuessTheNumber
{
    public static int HiddenNumber;

    private static int Guess(int n)
    {
        if (n == HiddenNumber)
            return 0;
        if (n < HiddenNumber)
            return 1;

        return -1;
    }

    public static int GuessNumber(int n) {
        var range = new int[2] {0, n};
        var g = n / 2;
        while(true) {
            var r = Guess(g);
            switch (r)
            {
                case -1:
                    range[1] = g;
                    break;
                case 1:
                    range[0] = ++g;
                    break;
                default:
                    return g;
            }

            g = range[0] + ((range[1] - range[0]) / 2);
        }
    }
}