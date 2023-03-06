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
}