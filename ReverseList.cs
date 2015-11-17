/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
 public ListNode ReverseList(ListNode head)
            {
                if (head==null)
                {
                    return head;
                }
                ListNode newHead=head;
                ListNode t;
                head = head.next;
                newHead.next = null;
                while (head!=null)
                {
                    t = head;
                    head = head.next;
                    t.next = newHead;
                    newHead = t;
                }
                return newHead;
            }
}
