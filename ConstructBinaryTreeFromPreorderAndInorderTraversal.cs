    public class Solution
    {
        private int preIndex = 0;
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            return BuildTree(preorder, inorder, 0, inorder.Length - 1);
        }

        public TreeNode BuildTree(int[] preorder, int[] inorder,int beginIndex,int endIndex)
        {
            if (beginIndex > endIndex || beginIndex < 0 || endIndex>preorder.Length-1)
            {
                return null;
            }
            var rootVal = preorder[preIndex++];
            var midIndex = -1;
            for (var i = 0; i < inorder.Length; i++)
            {
                if (inorder[i]==rootVal)
                {
                    midIndex = i;
                    break;
                }
            }
            var root = new TreeNode(rootVal);
            root.left = BuildTree(preorder, inorder,beginIndex, midIndex-1);
            root.right = BuildTree(preorder, inorder, midIndex + 1,endIndex);
            return root;
        }
    }