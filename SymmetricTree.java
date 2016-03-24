
 class Solution {
    public boolean isSymmetric(TreeNode root) {
        if(root==null){
            return true;
        }
        return _isSymmetric(root.left,root.right);
    }
    boolean _isSymmetric(TreeNode left,TreeNode right){
        if(left==null||right==null){
            return left==right;
        }
        if(left.val!=right.val){
            return false;
        }
        return _isSymmetric(left.left,right.right)&&_isSymmetric(left.right,right.left);
    }
}
