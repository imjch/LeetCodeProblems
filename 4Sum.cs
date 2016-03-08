 class Solution
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            Array.Sort(nums);
            var list = new List<IList<int>>();
            for (var i = 0; i < nums.Length-3; i++)
            {
                if(i>0&&nums[i] == nums[i-1])
                {
                    continue;
                }
                for (var j = i+1; j < nums.Length - 2; j++)
                {
                    if (j-1!=i&&nums[j] == nums[j - 1])
                    {
                        continue;
                    }
                    for (int k = j + 1,l=nums.Length-1; k < l;)
                    {
                        var val = nums[i] + nums[j] + nums[k] + nums[l];
                        if (val < target)
                        {
                            ++k;
                            while (l > k && nums[k] == nums[k - 1])
                            {
                                ++k;
                            }
                        }
                        else if (val > target)
                        {
                            --l;
                            while (l>k&&nums[l]==nums[l+1])
                            {
                                --l;
                            }
                        }
                        else
                        {
                            list.Add(new List<int>() { nums[i], nums[j], nums[k], nums[l] });
                            ++k;
                            --l;
                            while (l > k && nums[k] == nums[k - 1])
                            {
                                ++k;
                            }
                            while (l > k && nums[l] == nums[l + 1])
                            {
                                --l;
                            }
                        }
                    }
                }
            }
            return list;
        }
    }
