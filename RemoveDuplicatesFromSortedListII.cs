    public class Solution
    {
        public ListNode DeleteDuplicates(ListNode head)
        {

            var dict = new SortedDictionary<int, int>();
            while (head!=null)
            {
                if (dict.ContainsKey(head.val))
                {
                    dict[head.val]++;
                }
                else
                {
                    dict.Add(head.val,1);
                }
                head = head.next;
            }
            var newHead=new ListNode(0);
            foreach (var node in dict.Where(x => x.Value == 1).Reverse().Select(item => new ListNode(item.Key)))
            {
                node.next = newHead.next;
                newHead.next = node;
            }
            return newHead.next;
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
