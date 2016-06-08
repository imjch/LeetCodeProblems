Given two arrays, write a function to compute their intersection.

Example:
Given nums1 = [1, 2, 2, 1], nums2 = [2, 2], return [2].

Note:
Each element in the result must be unique.
The result can be in any order.

public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
         return nums1.Intersect(nums2).ToArray();
    }
}