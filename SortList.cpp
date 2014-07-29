/*Sort a linked list in O(n log n) time using constant space complexity.

 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode(int x) : val(x), next(NULL) {}
 * };
 */
 #include <set>
 #include <functional>
 using namespace std;
 namespace std {
 template<>
struct less<ListNode*>
{
    bool operator()(ListNode* x, ListNode* y)
    {
        if (x->val<y->val)
        {
            return true;
        }
        return false;
    }
};
}
class Solution {
public:
    ListNode *sortList(ListNode *head) {
    if (head==NULL)
    {
        return head;
    }
    multiset<ListNode*> tree;
    ListNode* node = head;
    ListNode* t;
    head = NULL;
    while (node!=NULL)
    {
        t = node;
        node = node->next;
        t->next = NULL;
        tree.insert(t);
    }
    multiset<ListNode*>::iterator iter = tree.begin();
    head = *iter;
    node = head;
    for (iter++; iter != tree.end(); iter++)
    {
        node->next = (*iter);
        node = node->next;
    }

    return head;
    }
};