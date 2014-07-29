//Given an array of integers, find two numbers such that they add up to a specific target number.

//The function twoSum should return indices of the two numbers such that they add up to the target, where index1 must be less than index2. Please note that your returned answers (both index1 and index2) are not zero-based.

//You may assume that each input would have exactly one solution.

//Input: numbers={2, 7, 11, 15}, target=9
//Output: index1=1, index2=2

#include <utility>
#include <unordered_map>
#include <vector>
using namespace std;
class Solution {
public:
    vector<int> twoSum(vector<int> &numbers, int target) {
    int index1, index2;
    unordered_multimap<int, int> map;
    for (size_t i = 0; i < numbers.size(); i++)
    {
        map.insert(make_pair(numbers[i],i));
    }

    for (size_t i = 0; i < numbers.size(); i++)
    {
        index1 = i + 1;
        auto pair = map.equal_range(target - numbers[i]);
        unordered_multimap<int, int>::iterator iter = pair.first;
        if (iter != pair.second)
        {
            int min_i = -1;
            while (iter != pair.second )
            {
                if (iter->second==i)
                {
                    ++iter;
                    continue;
                }
                else if (min_i<iter->second)
                {
                    min_i = iter->second;
                }
                ++iter;
            }
            index2 = min_i + 1;
            if (min_i!=-1)
            {
                break;
            }
        }
    }
    if (index1 > index2)
    {
        int t = index1;
        index1 = index2;
        index2 = t;
    }
    vector<int> result;
    result.push_back(index1);
    result.push_back(index2);
    return result;
    }
};