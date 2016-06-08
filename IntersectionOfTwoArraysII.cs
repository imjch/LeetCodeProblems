Given two arrays, write a function to compute their intersection.

Example:
Given nums1 = [1, 2, 2, 1], nums2 = [2, 2], return [2, 2].

Note:
Each element in the result should appear as many times as it shows in both arrays.
The result can be in any order.
Follow up:
What if the given array is already sorted? How would you optimize your algorithm?
What if nums1's size is small compared to nums2's size? Which algorithm is better?
What if elements of nums2 are stored on disk, and the memory is limited such that you cannot load all elements into the memory at once?

Origin:
    public class Solution
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            if (nums1==null||nums2==null)
            {
                return new int[]{};
            }
            var dict = new Dictionary<int, int>();
            var list = new List<int>();
            foreach (var item in nums1)
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
            foreach (var item in nums2)
            {
                if (dict.ContainsKey(item))
                {
                    list.Add(item);
                    dict[item]--;
                    if (dict[item] == 0)
                    {
                        dict.Remove(item);
                    }
                }
            }
            return list.ToArray();
        }
    }