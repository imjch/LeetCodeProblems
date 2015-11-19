// Definition for a binary tree node.
  public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int x) { val = x; }
  }
 
    public class Solution
    {
        public int CountNodes(TreeNode root)
        {
            if (root==null)
            {
                return 0;
            }
            var lDepth = LeftDepth(root);
            var rDepth = RightDepth(root);
            if (lDepth==rDepth)
            {
                return (1 << lDepth)-1;
            }
            else
            {
                return CountNodes(root.left) + CountNodes(root.right) + 1;
            }
        }
        public int LeftDepth(TreeNode root)
        {
            var depth = 1;
            var node = root;
            while (node.left!=null)
            {
                node = node.left;
                ++depth;
            }
            return depth;
        }

        public int RightDepth(TreeNode root)
        {
            var depth = 1;
            var node = root;
            while (node.right != null)
            {
                node = node.right;
                ++depth;
            }
            return depth;
        }
    
    }