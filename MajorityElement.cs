Given an array of size n, find the majority element. The majority element is the element that appears more than ⌊ n/2 ⌋ times.

You may assume that the array is non-empty and the majority element always exist in the array.

public class Solution {
    public int MajorityElement(int[] nums) {
            var val = 0;
            var count = 0;
            foreach (var t in nums)
            {
                if (count==0)
                {
                    val = t;
                    count = 1;
                }
                else if (t==val)
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }
            return val;
    }
}