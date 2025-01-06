public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        //merging
        int[] c = nums1.Concat(nums2).ToArray();
        //Sorting
        Array.Sort(c);

        int len = c.Length;
        if(len % 2 == 0)
            return (c[len / 2] + c[len / 2 - 1]) / 2.0;
        else
            return c[len / 2];        
    }
}