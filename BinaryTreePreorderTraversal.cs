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
        public IList<int> PreorderTraversal(TreeNode root)
        {
            var list = new List<int>();
            if (root!=null)
            {
                var stack = new Stack<TreeNode>();
                stack.Push(root);
                while (stack.Count != 0)
                {
                    var node = stack.Pop();
                    list.Add(node.val);
                    if (node.right != null)
                    {
                        stack.Push(node.right);
                    }
                    if (node.left != null)
                    {
                        stack.Push(node.left);
                    }
                }
               
            }
            return list;
        }
    }