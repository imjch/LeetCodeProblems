/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode Partition(ListNode head, int x) {
                   if (head==null)
            {
                return null;
            }
            ListNode tempNode = head;
            ListNode newHead = null;

            while (tempNode!= null)
            {
                var t = tempNode;
                tempNode = tempNode.next;
                t.next=newHead;
                newHead = t;
            }
            tempNode = newHead;

            ListNode lList = null;
            ListNode meList = null;
            ListNode llistTailNode=null;
            bool f = true;
            while (tempNode!=null)
            {
                var t = tempNode;
                tempNode = tempNode.next;
                if (t.val < x)
                {
                    t.next = lList;
                    lList = t;
                    if (f) llistTailNode = t;
                    f = false;
                }
                else
                {
                    t.next = meList;
                    meList = t;
                }
            }
            if (llistTailNode != null)
            {
                llistTailNode.next = meList;
                return lList;
            }
            else
            {
                return meList;
            }
            
    }
}
