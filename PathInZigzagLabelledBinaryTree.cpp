/*
In an infinite binary tree where every node has two children, the nodes are labelled in row order.

In the odd numbered rows (ie., the first, third, fifth,...), the labelling is left to right, while in the even numbered rows (second, fourth, sixth,...), the labelling is right to left.

Given the label of a node in this tree, return the labels in the path from the root of the tree to the node with that label.

https://leetcode.com/problems/path-in-zigzag-labelled-binary-tree/
*/
#include <vector>
#include <cmath>
#include <iostream>
using namespace std;

class Solution {
public:
    // Hint: Based on the label of the current node, find what the label must be for the parent of that node.
    vector<int> pathInZigZagTree(int label) {
        vector<int> e;
        // default case
        if (label < 1) {
            return e;
        }
        if (label == 1) {
            e.push_back(1);
            return e;
        }
        getParentNum(label, e);
        e.push_back(label);
        return e;
    }

    // 输出父节点的label
    void getParentNum(int currentLabel, vector<int> &e) {
        int n = log(currentLabel)/log(2); // get base number
        if (n == 1) {
            e.push_back(1);
            return;
        }
        // 行节点数
        int curLineNodesCnt = pow(2, n);
        // 包括当前行的总节点数
        int totalNodesCnt = pow(2, n + 1) - 1;
        // 不包括当前的总节点数
        int preNodeCnt = totalNodesCnt - curLineNodesCnt;

        // 判定当前行奇偶
        bool isEven = (n + 1)%2 == 0 ? true: false; // is even?
        if (isEven) {   
            int leftestLabel = totalNodesCnt;
            int res = (preNodeCnt + leftestLabel - currentLabel + 1) / 2;
            getParentNum(res, e);
            e.push_back(res);
            return;
        } else {
            int parentLabel = currentLabel / 2;
            int parentPreNodeCnt = pow(2,  int(log(parentLabel)/log(2))) - 1;
            int res = preNodeCnt - (parentLabel - parentPreNodeCnt) + 1;
            getParentNum(res, e);
            e.push_back(res);
            return;
        }
    }
};

// int main(int argc, char* argv[]) {
//     Solution s;
//     vector<int> e = s.pathInZigZagTree(26);
//     for (size_t i = 0; i < e.size(); i++)
//     {
//         cout << e[i] << endl;
//     }
    
//     return 1;
// }