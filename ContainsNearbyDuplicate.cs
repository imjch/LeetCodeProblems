public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            var hash = new Dictionary<int,int>();
            var index = 0;
            foreach (var num in nums)
            {
                if (hash.ContainsKey(num))
                {
                    if (index - hash[num] <= k)
                    {
                        return true;
                    }
                    else
                    {
                        hash.Remove(num);
                        hash.Add(num, index++);
                    }
                }
                else
                {
                    hash.Add(num, index++);
                }

            }
            return false;
        }
}