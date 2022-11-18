namespace Integers;

public static class PrimeFactor
{
    // https://leetcode.com/problems/ugly-number/
    // Runtime 54 ms Beats 67.47% Memory 27.1 MB Beats 49.40%
    public static bool IsUgly(int n)
    {
        if (n < 1) return false;

        while (n % 5 == 0) n /= 5;
        while (n % 3 == 0) n /= 3;
        while (n % 2 == 0) n /= 2;

        return n == 1;
    }
}