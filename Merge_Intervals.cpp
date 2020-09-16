#include <vector>
#include <iostream>

using namespace std;

class Solution {
public:
    vector<int> isOverlap(vector<int> &left, vector<int> &right, bool &isOverlap)
    {
        int leftA = left[0];
        int leftB = left[1];
        int rightA = right[0];
        int rightB = right[1];

        if ((leftA < rightA && leftB < rightA) || (leftA > rightB && leftB > rightB)) {
            isOverlap = false;
        }
        return vector<int>({min(leftA, rightA), max(leftB, rightB)});
    }

    vector<vector<int>> merge(vector<vector<int>>& intervals) {
        if (intervals.empty()) {
            return vector<vector<int>>();
        }
        sort(intervals.begin(), intervals.end(), [](vector<int> &a, vector<int> &b){
            return a[0] < b[0];
        });
        vector<vector<int>> res;
        res.push_back(intervals[0]);
        for (size_t i = 1; i < intervals.size(); i++)
        {
            auto first = res[res.size() - 1];
            auto second = intervals[i];

            bool isOverlap = true;
            auto overlapVector = this->isOverlap(first, second, isOverlap);
            if (isOverlap) {
                res[res.size() - 1] = overlapVector;
            } else {
                res.push_back(second);
            }
        }
        return res;
    }
};

int main(int argc, char** argv) {
    Solution s;
    auto value = vector<vector<int>> {vector<int>({2,6}), vector<int>({1,6})};
    auto res = s.merge(value);
    for (size_t i = 0; i < res.size(); i++)
    {
        cout << res[i][0] << "," << res[i][1] << endl;
    }
    
}