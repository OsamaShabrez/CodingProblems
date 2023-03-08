namespace Array;

public static class Median
{
    #region 4. https://leetcode.com/problems/median-of-two-sorted-arrays/

    public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        var len = nums1.Length + nums2.Length;
        var newArray = new int[len];
        var i = 0;
        var j = 0;

        for (var z = 0; z < len; z++)
        {
            if (i >= nums1.Length)
            {
                newArray[z] = nums2[j++];
                continue;
            }


            if (j >= nums2.Length)
            {
                newArray[z] = nums1[i++];
                continue;
            }

            if (nums1[i] < nums2[j])
                newArray[z] = nums1[i++];
            else
                newArray[z] = nums2[j++];
        }

        if (len % 2 == 0)
            return (newArray[len / 2 - 1] + newArray[len / 2]) / 2d;

        return newArray[len / 2];
    }

    #endregion
}