 public class Solution
    {
        public ListNode OddEvenList(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            ListNode oddHead = head;
            ListNode oddTail = oddHead;
            head = head.next;
            oddHead.next = null;
            ListNode evenHead = head;
            ListNode evenTail = evenHead;
            head = head.next;
            evenHead.next = null;
            var oddEvenFlag = true;//begin as odd
            while (head != null)
            {
                if (oddEvenFlag)//if odd
                {
                    oddTail.next = head;
                    head = head.next;
                    oddTail = oddTail.next;
                    oddTail.next = null;
                    oddEvenFlag = false;
                }
                else // if even
                {
                    evenTail.next = head;
                    head = head.next;
                    evenTail = evenTail.next;
                    evenTail.next = null;
                    oddEvenFlag = true;
                }
            }
            oddTail.next = evenHead;
            return oddHead;
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
