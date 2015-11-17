/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
        public int ListLength(ListNode head)
        {
            ListNode node = head;
            if (node == null)
            {
                return 0;
            }
            var count = 0;
            while (node != null)
            {
                node = node.next;
                count++;
            }
            return count;
        }

        public ListNode RotateRight(ListNode head, int k)
        {
            var newHead=head;
            var demarcationNode = head;
            var listLength = ListLength(head);
            if (listLength==0)
            {
                return null;
            }
            
            k = (k % listLength);
            while (k!=0)
            {
                newHead = newHead.next;
                k--;
            }
            if (newHead==null)
            {
                return head;
            }
            while (newHead.next!=null)
            {
                newHead = newHead.next;
                demarcationNode = demarcationNode.next;
            }
            newHead.next = head;
            head = demarcationNode.next;
            demarcationNode.next = null;
            return head;
        }
}
