/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode(int x) : val(x), next(NULL) {}
 * };
 */
class Solution {
public:
    ListNode* mergeTwoLists(ListNode* l1, ListNode* l2) {
        		 ListNode* headNode;
		 ListNode* newList=new ListNode(0);
		 headNode = newList;
		 ListNode* l1begin = l1;
		 ListNode* l2begin = l2;
		 while (l1begin!=nullptr&&l2begin!=nullptr)
		 {
			 if (l1begin->val<l2begin->val)
			 {
				 newList->next = l1begin;
				 l1begin = l1begin->next;
			 }
			 else
			 {
				 newList->next = l2begin;
				 l2begin = l2begin->next;
			 }
			 newList = newList->next;
		 }
		 if (l1begin!=nullptr)
		 {
			 newList->next = l1begin;
		 }
		 if (l2begin != nullptr)
		 {
			 newList->next = l2begin;
		 }
		 return headNode->next;
    }
};