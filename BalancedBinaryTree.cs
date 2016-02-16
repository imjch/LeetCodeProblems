    public class Solution
    {
        public bool IsBalanced(TreeNode root)
        {
            int height;
            return IsBalanced(root, out height);
        }
        public bool IsBalanced(TreeNode root, out int height)
        {
            if (root == null)
            {
                height = 0;
                return true;
            }
            var ld = 0;
            var rd = 0;
            var lb = IsBalanced(root.left, out ld);
            var rb = IsBalanced(root.right, out rd);

            height = (ld > rd ? ld : rd) + 1;

            if (!lb || !rb || Math.Abs(ld - rd) > 1) return false;
            return true;
        }
    }
