
 struct TreeNode {
     int val;
     TreeNode *left;
     TreeNode *right;
	 explicit TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
 };

class Solution {
public:
	TreeNode* invertTree(TreeNode* root) {
		if (root==nullptr)
		{
			return nullptr;
		}
		stack<TreeNode*> treeStack;
		treeStack.push(root);
		while (!treeStack.empty())
		{
			auto nodePtr = treeStack.top();
			treeStack.pop();
			if (nodePtr->left)
				treeStack.push(nodePtr->left);
			if (nodePtr->right)
				treeStack.push(nodePtr->right);
			swap(nodePtr->left, nodePtr->right);
		}
		return root;
	}
};