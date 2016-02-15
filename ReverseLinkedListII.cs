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
        public ListNode ReverseBetween(ListNode head, int m, int n)
        {
            ListNode newListHead = null;
            ListNode newListTail = null;
            ListNode beginPreNode = null;
          
            var currentNode = head;
            
            var d1 = m;
            while ((d1---1)!=0)
            {
                beginPreNode = currentNode;
                currentNode = currentNode.next;
            }
            var d2 = n - m + 1;
            newListTail = currentNode;
            while ((d2--) != 0)
            {
                var tNode = currentNode;
                currentNode = currentNode.next;
               
                tNode.next = newListHead;
                newListHead = tNode;
            }
            newListTail.next = currentNode;
            if (beginPreNode==null)
            {
                return newListHead;
            }
            beginPreNode.next = newListHead;
            return head;
        }

    }
