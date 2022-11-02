#include <iostream>
#include <vector>
using namespace std;

class Solution {
public:
    vector<int> sortArrayByParity(vector<int>& nums) {
        int i = 0;
        int j = nums.size() - 1;
        while (i < j) {
            while (i < j && nums[i] % 2 == 0)
            {
                ++i;
            }
            while (i < j && nums[j] % 2 == 1)
            {
                --j;
            }
            if (i<j) {
                int t = nums[i];
                nums[i] = nums[j];
                nums[j] = t;
            }
        }
        return nums;
    }
};

int main(int argc, char* argv[]) {
    Solution s;
    vector<int> nums = {0, 2};
    nums = s.sortArrayByParity(nums);
    for (size_t i = 0; i < nums.size(); i++)
    {
        cout << nums[i] << endl;
    }
    
}