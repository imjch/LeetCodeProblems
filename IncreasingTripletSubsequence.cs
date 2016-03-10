    public class Solution
    {
        public bool IncreasingTriplet(int[] nums)
        {
            return _IncreasingTriplet(nums, 0, 0, new Stack<int>(3));
        }

        public bool _IncreasingTriplet(int[] nums,int begin ,int count,Stack<int> arr)
        {
            if (count == 3)
            {
                if (arr.ElementAt(2) < arr.ElementAt(1) && arr.ElementAt(1) < arr.ElementAt(0))
                {
                    return true;
                }
                return false;
            }

            if (begin >= nums.Length)
            {
                return false;
            }

            for (var i = begin; i < nums.Length; i++)
            {
                arr.Push(nums[i]);
                var index = i+1;
                while (index<nums.Length&&nums[index]<=nums[i])
                {
                    index++;
                }
                var isSorted = _IncreasingTriplet(nums, index, count + 1, arr);
                if (isSorted)
                {
                    return true;
                }
                arr.Pop();
            }
            return false;
        }
    }
