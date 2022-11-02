// Given the array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].

// Return the array in the form [x1,y1,x2,y2,...,xn,yn].


// Example 1:

// Input: nums = [2,5,1,3,4,7], n = 3
// Output: [2,3,5,4,1,7] 
// Explanation: Since x1=2, x2=5, x3=1, y1=3, y2=4, y3=7 then the answer is [2,3,5,4,1,7].
// Example 2:

// Input: nums = [1,2,3,4,4,3,2,1], n = 4
// Output: [1,4,2,3,3,2,4,1]
// Example 3:

// Input: nums = [1,1,2,2], n = 2
// Output: [1,2,1,2]
 

// Constraints:

// 1 <= n <= 500
// nums.length == 2n
// 1 <= nums[i] <= 10^3
// Accepted
// 295,237

// #include <iostream>
#include <vector>
using namespace std;

class Solution {
public:
    vector<int> shuffle(vector<int>& nums, int n) {
        vector<int> e(2 * n);
        size_t xi = 0;
        for (size_t i = 0; i < nums.size(); i+=2)
        {
            xi = i / 2;
            size_t yi = n + xi;
            e[i] = nums[xi];
            e[i + 1] = nums[yi];
        }
        return e;
    }
};


// class Test {
//     public: 
//         Test() {
//             cout<<"cons"<<endl;
//         }
//         ~Test() {
//             cout<<"de cons"<<endl;
//         }
// };

// Test test() {
//     Test t;
//     cout<<"test ====="<<endl;
//     return t;
// }


int main(int argc, char* argv[]) {
    Solution s;
    vector<int> data = {1, 2, 3, 4, 5, 6, 7, 8};
    vector<int> e = s.shuffle(data, data.size() / 2);
    // for (size_t i = 0; i < e.size(); i++)
    // {
    //     cout << e[i] << endl;
    // }
    return 1;
}