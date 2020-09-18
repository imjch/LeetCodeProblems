#include <iostream>
#include <queue>
using namespace std;
// Definition for a Node.
class Node {
public:
    int val;
    Node* left;
    Node* right;
    Node* next;

    Node() : val(0), left(NULL), right(NULL), next(NULL) {}

    Node(int _val) : val(_val), left(NULL), right(NULL), next(NULL) {}

    Node(int _val, Node* _left, Node* _right, Node* _next)
        : val(_val), left(_left), right(_right), next(_next) {}
};


class Solution {
public:
    Node* connect(Node* root) {
        if (!root) {
            return NULL;
        }
        Node* rightest = NULL;
        Node* last = NULL;
        queue<Node*> Q;
        if (root->left) {
            Q.push(root->left);
        }
        if (root->right) {
            Q.push(root->right);
        }
        last = root;
        rightest = root;

        while (!Q.empty())
        {
            auto tmpNode = Q.front();
            Q.pop();
            if (tmpNode->left) {
                Q.push(tmpNode->left);
            }
            if (tmpNode->right) {
                Q.push(tmpNode->right);
            }

            if (last == rightest) {
                rightest->next = NULL;
                rightest = rightest->right;   
            } else {
                last->next = tmpNode;
            }
            last = tmpNode;
        }
        return root;
    }
};

int main(int argc, char* argv[]) {
    return 1;
}