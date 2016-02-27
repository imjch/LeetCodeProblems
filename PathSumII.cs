 public class Solution
    {
        private List<IList<int>> list = new List<IList<int>>();
        private List<int> pathRecorder = new List<int>();
        public IList<IList<int>> PathSum(TreeNode root, int sum)
        {
            _PathSum(root,sum,0);
            return list;
        }

        public void _PathSum(TreeNode node, int sum, int n)
        {
            if (node == null)
            {
                return;
            }
            pathRecorder.Add(node.val);
            n += node.val;
            if (n == sum&&node.left==null&&node.right==null)
            {
                list.Add(pathRecorder.ToList());
            }
            _PathSum(node.left, sum, n);
            _PathSum(node.right, sum, n);
            pathRecorder.RemoveAt(pathRecorder.Count-1);
        }
    
    }
