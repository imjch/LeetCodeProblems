class Solution {
public:
	ListNode* swapPairs(ListNode* head) {
		vector<pair<ListNode*, ListNode*>> vp;
		int count = 1;
		ListNode* p=nullptr;
		while (head!=nullptr)
		{
			count %= 2;
			if (count==1)
			{
				p = head;
			}
			if (count==0)
			{
				vp.push_back(make_pair(head, p));
				p = nullptr;
			}
			head = head->next;
			count++;
		}
		ListNode* newHead=nullptr;
		if (p!=nullptr)
		{
			newHead = p;
		}

		for (auto iter = vp.rbegin(); iter !=vp.rend(); ++iter)
		{
			iter->first->next = iter->second;
			iter->second->next = newHead;
			newHead = iter->first;
		}
		return newHead;
	}
};