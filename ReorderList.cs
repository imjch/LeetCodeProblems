//Sort a linked list using insertion sort.



/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
        public void ReorderList(ListNode head)
        {
            if (head==null||head.next==null||head.next.next==null)
            {
                return;   
            }
            var list = new List<ListNode>();
            var newHead = head;

            while (newHead!=null)
            {
                list.Add(newHead);
                newHead = newHead.next;
            }
            int i = 0, j = list.Count - 1;
            for (; i < j; i++,j--)
            {
                list[i].next = list[j];
                list[j].next = list[i + 1];
            }

            list[i].next = null;
        }
}