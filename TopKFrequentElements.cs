Given a non-empty array of integers, return the k most frequent elements.

For example,
Given [1,1,1,2,2,3] and k = 2, return [1,2].

Note: 
You may assume k is always valid, 1 ≤ k ≤ number of unique elements.
Your algorithm's time complexity must be better than O(n log n), where n is the array's size.
 public class Solution
    {
        public IList<int> TopKFrequent(int[] nums, int k)
        {
            var dict = new Dictionary<int, int>();
            foreach (var item in nums)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict.Add(item, 1);
                }
            }
            var l= dict.ToList();
            l.Sort((x, y) => y.Value - x.Value);
            return l.Take(k).Select(x=>x.Key).ToList();
        }
    }