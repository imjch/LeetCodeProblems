    public class Solution
    {
        int postIndex = 0;
        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            postIndex = postorder.Length - 1;
            return BuildTree(inorder,postorder,0,postorder.Length-1);
        }
        public TreeNode BuildTree(int[] inorder, int[] postorder, int beginIndex, int endIndex)
        {
            if (beginIndex > endIndex || beginIndex < 0 || endIndex > postorder.Length - 1)
            {
                return null;
            }
            var rootVal = postorder[postIndex--];
            var midIndex = -1;
            for (var i = 0; i < inorder.Length; i++)
            {
                if (inorder[i] == rootVal)
                {
                    midIndex = i;
                    break;
                }
            }
            var root = new TreeNode(rootVal);
            root.right = BuildTree(inorder, postorder, midIndex + 1, endIndex);
            root.left = BuildTree(inorder, postorder, beginIndex, midIndex - 1);
            return root;
        }
    }