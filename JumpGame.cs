public class Solution {
        public bool CanJump(int[] nums)
        {
            var remain_len = nums.Length - 1;
            for (var i = remain_len-1; i >= 0; i--)
            {
                if (i+nums[i]>=remain_len)
                {
                    remain_len = i;
                }
            }
            return remain_len == 0;
        }
}
