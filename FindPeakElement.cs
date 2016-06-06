A peak element is an element that is greater than its neighbors.

Given an input array where num[i] ≠ num[i+1], find a peak element and return its index.

The array may contain multiple peaks, in that case return the index to any one of the peaks is fine.

You may imagine that num[-1] = num[n] = -∞.

For example, in array [1, 2, 3, 1], 3 is a peak element and your function should return the index number 2.



    public class Solution
    {
        
        public int FindPeakElement(int[] nums)
        {
            if (nums.Length==1)
            {
                return 0;
            }
            int index = -1;
            FindPeakElement(nums, 0, nums.Length-1,ref index);
            return index;
        }

        public void FindPeakElement(int[] nums,int begin,int end,ref int index)
        {
            if (begin>end)
            {
                return;
            }
            if (index>0)
            {
                return;
            }
            int mid = (begin + end) >> 1;
            if (mid == 0)
            {
                if (nums[mid] > nums[mid + 1])
                {
                    index = mid;
                }
                else
                {
                    FindPeakElement(nums, mid + 1, end, ref index);
                }
            }
            else if (mid == nums.Length - 1)
            {
                if (nums[mid] > nums[mid - 1])
                {
                    index = mid;
                }
                else
                {
                    FindPeakElement(nums, begin, mid - 1, ref index);
                }
            }
            else
            {
                if (nums[mid] > nums[mid - 1] && nums[mid] > nums[mid + 1])
                {
                    index = mid;
                }
                else
                {
                    FindPeakElement(nums, mid + 1, end, ref index);
                    FindPeakElement(nums, begin, mid - 1, ref index);
                }
            }
        }
    }