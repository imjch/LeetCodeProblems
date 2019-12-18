/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode(int x) : val(x), next(NULL) {}
 * };
 */
#include <vector>
#include <set>
#include <cstdio>
using namespace std;
  struct ListNode {
      int val;
      ListNode *next;
      ListNode(int x) : val(x), next(NULL) {}
  };

class Solution {
public:
    ListNode* mergeKLists(vector<ListNode*>& lists) {
        if (lists.empty()) {
            return NULL;
        }
        std::multiset<int> valSet;
        for (vector<ListNode*>::iterator iter = lists.begin(); iter != lists.end(); ++iter) {
            ListNode* headNode = *iter;
            while (headNode)
            {
                int val = headNode->val;
                valSet.insert(val);
                headNode = headNode->next;
            }
        }
        ListNode* resNode = new ListNode(0);
        ListNode* resHead = resNode;

        multiset<int>::iterator it;
        for(it = valSet.begin ();it != valSet.end(); it++)
        {
            ListNode* node = new ListNode(*it);
            resNode->next = node;
            resNode = node;
        }
        return resHead->next;
    }
};

int main(int argc, char**argv) {
    Solution s;
    vector<ListNode*> v;
    ListNode* head1 = new ListNode(1);
    ListNode* node1 = new ListNode(4);
    ListNode* node2 = new ListNode(5);
    head1->next = node1;
    node1->next = node2;

    ListNode* head2 = new ListNode(1);
    ListNode* node3 = new ListNode(3);
    ListNode* node4 = new ListNode(4);
    head2->next = node3;
    node3->next = node4;

    ListNode* head3 = new ListNode(2);
    ListNode* node5 = new ListNode(6);
    head3->next = node5;

    v.push_back(head1);
    v.push_back(head2);
    v.push_back(head3);
    s.mergeKLists(v);
}
