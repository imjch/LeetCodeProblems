
class Solution {
public:
	int searchInsert(vector<int>& nums, int target) {
		if (target>nums[nums.size()-1])
		{
			return nums.size();
		}
		auto len = nums.size();
		vector<int>::iterator first = nums.begin();
		vector<int>::iterator middle;
		auto half=-1;
		while (len>0)
		{
			half = len >> 1;
		    middle = (first + half);
			if (*middle<target)
			{
				first = middle;
				++first;
				len = len - half - 1;
			}
			else
			{
				len = half;
			}
		}
		return distance(nums.begin(), first);
	}
};