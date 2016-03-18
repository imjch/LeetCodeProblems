
 class Solution {

    public List<TreeNode> generateTrees(int n) {
        if(n==0){
            return new ArrayList<>();
        }
        return _generateTrees(1,n);
    }

     public List<TreeNode> _generateTrees(int start,int end) {
         List<TreeNode> list=new ArrayList<>();
         if(start>end){
             list.add(null);
             return list;
         }
         if(start==end){
             list.add(new TreeNode(start));
             return list;
         }
         List<TreeNode> leftList,rightList;
         for(int i = start;i <= end;i++){
             leftList=_generateTrees(start,i-1);
             rightList=_generateTrees(i+1,end);
             for(TreeNode left:leftList){
                 for(TreeNode right:rightList){
                     TreeNode node = new TreeNode(i);
                     node.left=left;
                     node.right=right;
                     list.add(node);
                 }
             }
         }
         return list;
     }
}
