public class Solution
    {
        private long min=Int64.MinValue;
        private bool flag=true;
        public bool IsValidBST(TreeNode root)
        {
            IsValid(root);
            return flag;
        }

        void IsValid(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            IsValidBST(root.left);
            if (root.val<=min)
            {
                flag = false;
                return;
            }
            else
            {
                min = root.val;
            }
            IsValidBST(root.right);
        }
    }
