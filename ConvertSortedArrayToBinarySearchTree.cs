/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
    public class Solution
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return SortedArrayToBST(nums, 0, nums.Length - 1);
        }


        public TreeNode SortedArrayToBST(int[] nums,int begin,int end)
        {
            if (begin>end)
            {
                return null;
            }
            var mid = (begin + end) >> 1;
            var node = new TreeNode(nums[mid]);
            node.left = SortedArrayToBST(nums, begin, mid - 1);
            node.right = SortedArrayToBST(nums,mid + 1, end);
            return node;
        }
    }