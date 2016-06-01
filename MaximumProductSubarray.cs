Find the contiguous subarray within an array (containing at least one number) which has the largest product.

For example, given the array [2,3,-2,4],
the contiguous subarray [2,3] has the largest product = 6.


public class Solution {
        public int MaxProduct(int[] nums)
        {
            var max=nums[0];
            var min = nums[0];
            var result = nums[0];
            for (var i = 1; i < nums.Length; i++)
            {
                var t = max;
                max = Math.Max(nums[i], Math.Max(nums[i]*max, nums[i]*min));
                min = Math.Min(nums[i], Math.Min(nums[i]*min, nums[i]*t));
                result = Math.Max(max, result);
            }
            return result;
        }

}