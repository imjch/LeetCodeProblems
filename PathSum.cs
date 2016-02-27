  public class Solution
    {
        public bool HasPathSum(TreeNode root, int sum)
        {
            return _HasPathSum(root,sum,0);
        }

        public bool _HasPathSum(TreeNode node, int sum, int n)
        {
            if (node == null)
            {
                return false;
            }
            n += node.val;
            if (n == sum&&node.left==null&&node.right==null)
            {
                return true;
            }
            return _HasPathSum(node.left, sum, n) || _HasPathSum(node.right, sum, n);
        }
    
    }
