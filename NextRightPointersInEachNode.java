class Solution {
     public void connect(TreeLinkNode root) {
         if(root==null){
             return;
         }
          if(root.left==null&&root.right==null){
              return;
          }
          root.right.next=null;
          root.left.next=root.right;

          connect(root.left);
          connect(root.right);
          twoSideConnect(root.left,root.right);
     }

     public void twoSideConnect(TreeLinkNode left,TreeLinkNode right){
         if(left.right==null&&right.left==null){
             return;
         }
         left.right.next=right.left;
         twoSideConnect(left.right,right.left);
     }
//     public void _connect(TreeLinkNod) {
//
//     }
}
