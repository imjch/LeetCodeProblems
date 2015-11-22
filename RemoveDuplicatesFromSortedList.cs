public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
             if (head == null)
             {
                 return head;
             }
             ListNode newHead = head;
             ListNode lastNode=newHead;

             head = head.next;
             newHead.next = null;
             while (head != null)
             {
                 if (head.val == lastNode.val)
                 {
                     head = head.next;
                 }
                 else
                 {
                     ListNode t = head;
                     head = head.next;
                     t.next = null;
                     lastNode.next = t;
                     lastNode = t;
                 }
             }
             return newHead;
    }
}