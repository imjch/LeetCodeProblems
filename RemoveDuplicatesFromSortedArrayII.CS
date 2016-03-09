    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            var list = new List<int>(nums.Length);
            var i = 0;

            var count = 1;
            while (i < nums.Length)
            {
                if (i > 0 && nums[i] == nums[i - 1] && count < 2)
                {
                    count++;
                    while (i < nums.Length - 1 && nums[i] == nums[i + 1])
                    {
                        i++;
                    }
                }
                else
                {
                    count = 1;
                    
                }
                list.Add(nums[i]);
                i++;
            }
           
            Array.Copy(list.ToArray(), 0, nums, 0, list.Count);
            return list.Count;
        }
