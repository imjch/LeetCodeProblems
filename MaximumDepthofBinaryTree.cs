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
        public int MaxDepth(TreeNode root)
        {
            return root==null ? 0 : Math.Max(MaxDepth(root.left)+1, MaxDepth(root.right)+1);
        }
    }
