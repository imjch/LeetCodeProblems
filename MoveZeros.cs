public class Solution {
    public void MoveZeroes(int[] nums) {
         int i = -1, j = 0;
            while (j < nums.Length)
            {
                
                if (nums[j]!=0)
                {
                    ++i;
                    int t= nums[i];
                    nums[i] = nums[j];
                    nums[j] = t;
                }
 
                    ++j;

            }
    }
}
