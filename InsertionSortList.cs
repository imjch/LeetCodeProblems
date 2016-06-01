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
        public ListNode InsertionSortList(ListNode head)
        {
            if (head==null||head.next==null)
            {
                return head;
            }
            var tmpHead = head.next;
            var minValHead = head;
            minValHead.next = null;
            
            while (tmpHead!=null)
            {
                ListNode node = new ListNode(0) { next= minValHead };
                while (node.next!=null&&tmpHead.val > node.next.val)
                {
                    node= node.next;
                }

                var t = tmpHead;
                if (t.val<=minValHead.val)
                {
                    minValHead = t;
                }
                tmpHead=tmpHead.next;
                t.next = node.next;
                node.next = t;
            }
            return minValHead;
        }
    }