class Solution {
public:
	ListNode* removeNthFromEnd(ListNode* head, int n) {
		if (!head)
		{
			return head;
		}
		n--;
		ListNode* begin=head;
	
		ListNode newHead(0);
		newHead.next = head;
		ListNode* preHead = &newHead;
		ListNode* endHead = head;
		for (size_t i = 0; i < n; i++)
		{
			endHead = endHead->next;
		}
		while (endHead->next!=nullptr)
		{
			endHead = endHead->next;
			head = head->next;
			preHead = preHead->next;
		}
		preHead->next = head->next;
		if (head == begin)
		{
			return preHead->next;
		}
		head->next = nullptr;
		return begin;
	}