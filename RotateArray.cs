Rotate an array of n elements to the right by k steps.

For example, with n = 7 and k = 3, the array [1,2,3,4,5,6,7] is rotated to [5,6,7,1,2,3,4].

Note:
Try to come up as many solutions as you can, there are at least 3 different ways to solve this problem.

[show hint]

Hint:
Could you do it in-place with O(1) extra space?
Related problem: Reverse Words in a String II






    public class Solution
    {
        public void Rotate(int[] nums, int k)
        {
            if (nums==null)
            {
                return;
            }
            if (nums.Length==1)
            {
                return;
            }
            k %= nums.Length;
            var leftPart = nums.Length - k;
            Rotate(nums, 0,leftPart-1);
            Rotate(nums, leftPart, nums.Length - 1);
            Rotate(nums, 0, nums.Length - 1);
        }

        public void Rotate(int[] nums,int begin,int end)
        {
            for (int i = begin,j=end; i < j; i++,j--)
            {
                int t = nums[i];
                nums[i] = nums[j];
                nums[j] = t;
            }
        }
    }