  public class Solution
    {
        private int minDepth =int.MaxValue;
        public int MinDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            MinDepth(root,1);
            return minDepth;
        }

        public void MinDepth(TreeNode root,int depth)
        {
            if (depth>minDepth||root==null)
            {
                return;
            }
            if (root.left==null&&root.right==null)
            {
                minDepth = depth<minDepth?depth:minDepth;
                return;
            }
            MinDepth(root.left,depth+1);
            MinDepth(root.right,depth+1);
        }
