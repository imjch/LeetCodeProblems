public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        while (m != 0 && n != 0)
            {
                var val = nums1[m - 1] > nums2[n - 1] ? nums1[--m] : nums2[--n];
                nums1[m + n] = val;
            }
            if (n != 0)
            {
                while (n != 0)
                {
                    nums1[n - 1] = nums2[n - 1];
                    n--;
                }

            }
    }
}
