public class Solution {
        public IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<int>> list=new List<IList<int>>();
            Permute2(0,nums,list);
            return list;
        }
        private void Swap(int i, int j, int[] nums)
        {
            var t = nums[j];
            nums[j] = nums[i];
            nums[i] = t;
        }
        private void Permute2(int n , int[] nums,IList<IList<int>> list)
        {
            if (n==nums.Length)
            {
                list.Add(new List<int>(nums));
                return;
            }
            for (int i = n; i < nums.Length; i++)
            {
                Swap(i, n, nums);
                Permute2(n+1,nums,list);
                Swap(i, n, nums);
            }
        }
}
