   
Suppose a sorted array is rotated at some pivot unknown to you beforehand.

(i.e., 0 1 2 4 5 6 7 might become 4 5 6 7 0 1 2).

Find the minimum element.

You may assume no duplicate exists in the array.

    public class Solution
    {
        public int FindMin(int[] nums)
        {
            int begin = 0;
            int end = nums.Length - 1;
            while (begin<end)
            {
                var mid = (begin + end) >> 1;
                if (nums[mid]<=nums[end])
                {
                    end = mid;
                }
                else
                {
                    begin = mid + 1;
                }
            }
            return nums[begin];
        }
    }