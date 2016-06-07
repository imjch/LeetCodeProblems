
Implement an iterator over a binary search tree (BST). Your iterator will be initialized with the root node of a BST.

Calling next() will return the next smallest number in the BST.

Note: next() and hasNext() should run in average O(1) time and uses O(h) memory, where h is the height of the tree.
    public class BSTIterator
    {
        private List<TreeNode> list = new List<TreeNode>();
        private int index = 0;
        public BSTIterator(TreeNode root)
        {
            Init(root);
        }

        /** @return whether we have a next smallest number */
        public bool HasNext()
        {
            if (index < list.Count)
            {
                return true;
            }
            else
            {
                index = 0;
                return false;
            }
         
        }

        /** @return the next smallest number */
        public int Next()
        {
            if (!HasNext())
            {
                return 0;
            }
            return list[index++].val;
        }

        public void Init(TreeNode node)
        {
            if (node==null)
            {
                return;
            }
            Init(node.left);
            list.Add(node);
            Init(node.right);
        }
    }