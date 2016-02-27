  public void Flatten(TreeNode root)
        {
            _Flatten(root);
        }

        public TreeNode _Flatten(TreeNode node)
        {

            if (node == null||node.left == null && node.right == null)
            {
                return node;
            }
            var left = node.left; node.left = null;
            var right = node.right; node.right= null;

            TreeNode leafOfLeftTree = null;
            TreeNode leafOfRightTree = null;
            if (left != null)
            {
                leafOfLeftTree = _Flatten(left);
                node.right = left;
            }
            if (right!=null)
            {
                leafOfRightTree=_Flatten(right);
            }

            if (leafOfLeftTree != null)
            {
                leafOfLeftTree.right = right;
            }
            else
            {
                node.right = right;
            }

            return leafOfRightTree ?? leafOfLeftTree;
        }
