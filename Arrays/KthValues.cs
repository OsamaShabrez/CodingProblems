namespace Array;

public static class KthValues
{
    #region 1539 https://leetcode.com/problems/kth-missing-positive-number
    public static int FindKthPositive(int[] arr, int k)
    {
        int index = 0, i =1, num = 1;
        while (i <= k)
        {
            if (index < arr.Length && num == arr[index])
            {
                index++;
                num++;
            }
            else
            {
                i++;
                num++;
            }
        }

        return num - 1;
    }
    #endregion
    
    #region 875 https://leetcode.com/problems/koko-eating-bananas
    public static int MinEatingSpeed(int[] piles, int h)
    {
        if (piles.Length == h)
            return piles.Max();

        long maxK = 0;
        long sum = 0;
        foreach (var pile in piles)
        {
            maxK = Math.Max(pile, maxK);
            sum += pile;
        }
        var minK = Math.Max(sum / h, 1);

        do
        {
            var mid = (minK + maxK) / 2;
            if (SpeedTest(piles, h, mid))
                maxK = mid;
            else
                minK = mid + 1;
        } while (minK < maxK);

        return (int) minK;
    }

    private static bool SpeedTest(IEnumerable<int> piles, int h, double testK)
    {
        foreach (var pile in piles)
        {
            h -= (int) Math.Ceiling(pile / testK);
            if (h < 0)
                return false;
        }

        return true;
    }

    #endregion
}