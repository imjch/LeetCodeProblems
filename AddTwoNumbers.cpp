<<<<<<< HEAD
//You are given two linked lists representing two non-negative numbers. The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.
//
//Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
//Output: 7 -> 0 -> 8
///**
 //* Definition for singly-linked list.
 //* struct ListNode {
 //*     int val;
 //*     ListNode *next;
 //*     ListNode(int x) : val(x), next(NULL) {}
 //* };
 //*/
class Solution {
public:
void add(ListNode* node,int val)
{
    bool flag = true;
    ListNode* prev;
    while (flag&&node != NULL)
    {
        int t = node->val + val;
        if (t>=10)
        {
            t -= 10;
            flag = true;
        }
        else
        {
            flag = false;
        }
        node->val = t;
        prev = node;
        node = node->next;
    }
    if (flag)
    {
        ListNode* new_node = new ListNode(1);
        prev->next = new_node;
    }
}
    ListNode *addTwoNumbers(ListNode *l1, ListNode *l2) {
      int i1 = 0, i2 = 0;
    ListNode* t1 = l1;
    ListNode* t2 = l2;
    if (t1==NULL)
    {
        return l2;
    }
    if (t2==NULL)
    {
        return l1;
    }
    while (t1!=NULL)
    {
        t1 = t1->next;
        ++i1;
    }
    t1 = l1;
    while (t2!=NULL)
    {
        t2 = t2->next;
        ++i2;
    }
    t2 = l2;
    if (i1<i2)
    {
        i2 = i1;
        swap(t1,t2);
    }
    bool flag = false; 
    ListNode* prev,*head;
    head = t1;
    while (i2!=0)
    {
        int t = t1->val + t2->val;
        if (flag)
        {
            t += 1;
            flag = false;
        }
        if (t>=10)
        {
            flag = true;
            t -= 10;
        }
        t1->val = t;
        prev = t1;
        t1 = t1->next;
        t2 = t2->next;
        i2--;
    }
    if (flag)
    {
        if (t1!=NULL)
        {
            add(t1,1);
        }
        else
        {
            ListNode* new_node = new ListNode(1);
            prev->next=new_node;
        }
    }
    return head;
    }
=======
//You are given two linked lists representing two non-negative numbers. The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.
//
//Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
//Output: 7 -> 0 -> 8
///**
 //* Definition for singly-linked list.
 //* struct ListNode {
 //*     int val;
 //*     ListNode *next;
 //*     ListNode(int x) : val(x), next(NULL) {}
 //* };
 //*/
class Solution {
public:
void add(ListNode* node,int val)
{
    bool flag = true;
    ListNode* prev;
    while (flag&&node != NULL)
    {
        int t = node->val + val;
        if (t>=10)
        {
            t -= 10;
            flag = true;
        }
        else
        {
            flag = false;
        }
        node->val = t;
        prev = node;
        node = node->next;
    }
    if (flag)
    {
        ListNode* new_node = new ListNode(1);
        prev->next = new_node;
    }
}
    ListNode *addTwoNumbers(ListNode *l1, ListNode *l2) {
      int i1 = 0, i2 = 0;
    ListNode* t1 = l1;
    ListNode* t2 = l2;
    if (t1==NULL)
    {
        return l2;
    }
    if (t2==NULL)
    {
        return l1;
    }
    while (t1!=NULL)
    {
        t1 = t1->next;
        ++i1;
    }
    t1 = l1;
    while (t2!=NULL)
    {
        t2 = t2->next;
        ++i2;
    }
    t2 = l2;
    if (i1<i2)
    {
        i2 = i1;
        swap(t1,t2);
    }
    bool flag = false; 
    ListNode* prev,*head;
    head = t1;
    while (i2!=0)
    {
        int t = t1->val + t2->val;
        if (flag)
        {
            t += 1;
            flag = false;
        }
        if (t>=10)
        {
            flag = true;
            t -= 10;
        }
        t1->val = t;
        prev = t1;
        t1 = t1->next;
        t2 = t2->next;
        i2--;
    }
    if (flag)
    {
        if (t1!=NULL)
        {
            add(t1,1);
        }
        else
        {
            ListNode* new_node = new ListNode(1);
            prev->next=new_node;
        }
    }
    return head;
    }
>>>>>>> 913373de193529a5e5d9a68a5b9929cde69b203b
};