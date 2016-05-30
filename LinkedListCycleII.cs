    public class Solution
    {
        public ListNode DetectCycle(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return null;
            }
            ListNode slow = head;
            ListNode fast = head.next;
            while (slow != fast)
            {
                if (fast == null || fast.next == null)
                {
                    return null;
                }
                slow = slow.next;
                fast = fast.next.next;
            }
            var newHead = head;
            slow = slow.next;
            while (slow != newHead)
            {
                slow = slow.next;
                newHead = newHead.next;
            }
            return newHead;
        }
    }