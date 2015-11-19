public class Solution {
    public int MaxSubArray(int[] nums) {
                    var list = new List<int> {nums[0]};
            var subList = new List<int>(3);
            for (var i = 1; i < nums.Length; i++)
            {
                subList.Add(nums[i]);
                
                subList.Add(nums[i]+list[i-1]);
                list.Add(subList.Max());
                subList.Clear();
            }
            return list.Max();
    }
}
