/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
        public ListNode RemoveElements(ListNode head, int val)
        {

            var node = head;
            var preNode = new ListNode(-1){next=node};
            while (node != null)
            {
                if (node.val == val)
                {
                    node = node.next;
                    preNode.next = node;
                    head = head.val == val ? node : head;
                }
                else
                {
                    preNode = preNode.next;
                    node = node.next;
                }
            }
            return head;
        }
}
