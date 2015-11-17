/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public bool IsSameTree(TreeNode p, TreeNode q)
         {
             if (p==null&&q==null)
             {
                 return true;
             }
             if(p==null||q==null)return false;
             var flag = true;
             IterateTree(p, q, ref flag);
             return flag;
         }

         public void IterateTree(TreeNode tree1Node, TreeNode tree2Node,ref bool flag)
         {
             if (!flag)
             {
                 return;
             }
             if (tree1Node == null && tree2Node == null)
             {
                 return;
             }
             if (tree1Node == null || tree2Node == null)
             {
                 flag = false;
                 return;
             }
             if (tree1Node.val != tree2Node.val)
             {
                 flag = false;
                 return;
             }
             IterateTree(tree1Node.left, tree2Node.left, ref flag);
             IterateTree(tree1Node.right, tree2Node.right, ref flag);
         }
}
