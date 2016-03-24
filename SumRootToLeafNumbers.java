class Solution {

    public int sumNumbers(TreeNode root) {
        return _sumNumbers(root, 0);

    }

    int _sumNumbers(TreeNode node, int sum) {
        if (node == null) {
            return 0;
        }
        if (node.left == null && node.right == null) {
            return node.val + sum;
        }
        sum += node.val;
       return   _sumNumbers(node.left, sum * 10) + _sumNumbers(node.right, sum * 10);
        
    }
}
