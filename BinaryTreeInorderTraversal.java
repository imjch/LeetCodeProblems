/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode(int x) { val = x; }
 * }
 */
class Solution {
    List<Integer> list=new ArrayList<>();
    public List<Integer> inorderTraversal(TreeNode root) {
        _inorderTraversal(root);
        return list;
    }

    void _inorderTraversal(TreeNode node) {
        if(node==null){
            return;
        }

        _inorderTraversal(node.left);
        list.add(node.val);
        _inorderTraversal(node.right);
    }
}
