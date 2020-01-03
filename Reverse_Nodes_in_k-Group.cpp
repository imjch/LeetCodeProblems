/**
 * Definition for singly-linked list.
 */
#include <cstdio>

struct ListNode {
    int val;
    ListNode *next;
    ListNode(int x) : val(x), next(NULL) {}
};


class Solution {
public:
    ListNode* reverseList(ListNode* head, ListNode* end) {
        ListNode* tail = head;
        head = head->next;
        tail->next = end;
        while (head != end) {
            ListNode* tmp = head->next;
            head->next = tail;
            tail = head;
            head = tmp;
        }
        return tail;
    }

    ListNode* reverseKGroup(ListNode* head, int k) {
        ListNode* tmpRight = head;
        ListNode* last = NULL;
        bool flag = true;
        while (tmpRight)
        {
            ListNode* tmpLeft = tmpRight;
            int step = 1;
            while (step < k && tmpRight)
            {
                tmpRight = tmpRight->next;
                step++;
            }
            if (step < k || tmpRight == NULL) {
                break;
            }

            tmpRight = tmpRight->next;
            ListNode* tmp = tmpLeft;
            tmpLeft = this->reverseList(tmpLeft, tmpRight);
            if (last != NULL) {
                last->next = tmpLeft;
            }
            last = tmp;
            if (flag) {
                head = tmpLeft;
                flag = false;
            }
        }
                
        return head;
    }
};

int main(int argc, char const *argv[])
{
    Solution s;
    ListNode* head = new ListNode(1);
    ListNode* node1 = new ListNode(2);
    ListNode* node2 = new ListNode(3);
    ListNode* node3 = new ListNode(4);
    ListNode* node4 = new ListNode(5);

    head->next = node1;
    node1->next = node2;
    node2->next = node3;
    node3->next = node4;
    head = s.reverseKGroup(head, 2);
    while (head)
    {
        printf("%d\n", head->val);
        head = head->next;
    }
    
    return 0;
}

