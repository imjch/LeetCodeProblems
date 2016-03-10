    public class NumArray
    {
        private int[] nums;
        public NumArray(int[] nums)
        {
            for (var i = 1; i < nums.Length; i++)
            {
                nums[i] = nums[i] + nums[i - 1];
            }
            this.nums = nums;
        }

        public int SumRange(int i, int j)
        {
            if (i==0)
            {
                return nums[j];
            }
            return nums[j] - nums[i - 1];
        }
    }
