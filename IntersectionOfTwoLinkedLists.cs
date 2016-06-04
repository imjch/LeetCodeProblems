Write a program to find the node at which the intersection of two singly linked lists begins.


For example, the following two linked lists:

A:          a1 → a2
                   ↘
                     c1 → c2 → c3
                   ↗            
B:     b1 → b2 → b3
begin to intersect at node c1.


Notes:

If the two linked lists have no intersection at all, return null.
The linked lists must retain their original structure after the function returns.
You may assume there are no cycles anywhere in the entire linked structure.
Your code should preferably run in O(n) time and use only O(1) memory.




/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
    public class Solution
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA==null||headB==null)
            {
                return null;
            }
            var newHeadA = headA;
            var newHeadB = headB;
            while (newHeadA!=null&&newHeadB!=null)
            {
                if (newHeadA==newHeadB)
                {
                    return newHeadA;
                }
                newHeadA = newHeadA.next;
                newHeadB = newHeadB.next;
            }
            if (newHeadA==newHeadB)//is null
            {
                return null;
            }
            ListNode newHead=null;
            ListNode currrentHead=null;
            ListNode otherHead = null;
            if (newHeadA==null)//newHeadB is not null
            {
                newHead = headB;
                otherHead = headA;
                currrentHead = newHeadB;
            }
            else //newHeadA is not null
            {
                newHead = headA;
                otherHead = headB;
                currrentHead = newHeadA;
            }
            while (currrentHead!=null)
            {
                newHead = newHead.next;
                currrentHead = currrentHead.next;
            }
            while (otherHead != null && newHead != null)
            {
                if (otherHead == newHead)
                {
                    return otherHead;
                }
                otherHead = otherHead.next;
                newHead = newHead.next;
            }
            return null;
        }
    }