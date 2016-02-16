    public class Solution
    {
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            var list = new List<IList<int>>();
            if (root != null)
            {
                var currentlevelQueue = new Queue<TreeNode>();
                currentlevelQueue.Enqueue(root);
                var fromRight = false;
                while (currentlevelQueue.Count != 0)
                {
                    var nextLevelQueue = new Queue<TreeNode>();
                    currentlevelQueue.ToList().ForEach(x =>
                    {
                            if (x.left != null)
                            {
                                nextLevelQueue.Enqueue(x.left);
                            }
                            if (x.right != null)
                            {
                                nextLevelQueue.Enqueue(x.right);
                            }
                    }
                );

                    list.Add(fromRight ? currentlevelQueue.Reverse().Select(x => x.val).ToList() : currentlevelQueue.Select(x => x.val).ToList());
                    currentlevelQueue = nextLevelQueue;
                    fromRight = !fromRight;
                }
            }

            return list;
        }
    }
