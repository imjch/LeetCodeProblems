    public class Solution
    {
        bool IsSwapped(int[] nums, int i, int j)
        {
            while (i<j)
            {
                if (nums[i]==nums[j])
                {
                    return true;
                }
                i++;
            }
           
            return false;
        }
        public void Swap(int[] nums,int i,int j)
        {
            int t = nums[i];
            nums[i] = nums[j];
            nums[j] = t;
        }
        List<IList<int>> list = new List<IList<int>>();
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            Array.Sort(nums);
            _PermuteUnique(nums,0,nums.Length);
            return list;
        }
        public void _PermuteUnique(int[] nums,int begin,int end)
        {
            if (begin>=end-1)
            {
                list.Add(nums.ToList());
                return;
            }
            for ( var i = begin; i < end; i++)
            {
                if (IsSwapped(nums,begin,i))
                {
                    continue;
                }
                Swap(nums,begin,i);
                _PermuteUnique(nums, begin+1, end);
                Swap(nums, begin, i);
            }
        }
    }
