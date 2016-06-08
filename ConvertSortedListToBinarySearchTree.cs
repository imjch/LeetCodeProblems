Given a singly linked list where elements are sorted in ascending order, convert it to a height balanced BST.


    public class Solution
    {
        public TreeNode SortedListToBST(ListNode head)
        {
            var node = head;
            var size = 0;
            while (node!=null)
            {
                node = node.next;
                size++;
            }
            return Insert(0, size - 1,ref head);
        }

        public TreeNode Insert(int start, int end,ref ListNode lnode)
        {
            if (start>end)
            {
                return null;
            } 
            var mid = (start + end) >> 1;
            var left = Insert(start, mid - 1, ref lnode);
            var node = new TreeNode(lnode.val);

            node.left = left;
            lnode = lnode.next;

            var right = Insert(mid + 1, end,ref lnode);
            node.right = right;
            return node;
        }

    }