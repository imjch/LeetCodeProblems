    public class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            if (nums.Length == 0)
            {
                return false;
            }
            var hash = new HashSet<int>();
            return !nums.All(item => hash.Add(item));
        }

    }