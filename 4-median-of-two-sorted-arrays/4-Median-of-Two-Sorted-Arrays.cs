public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int [] merged = new int [(nums1.Length+nums2.Length)] ;
        nums1.CopyTo(merged,0);
        nums2.CopyTo(merged, nums1.Length);

        Array.Sort(merged);

        if(merged.Length%2 ==0)
        {
            int length = merged.Length/2;
            return ((merged[length-1] + merged[length])/2.0);
        }
        else
        {
            return(merged[merged.Length/2]);
        }

    }
}