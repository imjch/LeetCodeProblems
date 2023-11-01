/**
 * Definition for a binary tree node.
 * type TreeNode struct {
 *     Val int
 *     Left *TreeNode
 *     Right *TreeNode
 * }
 */

package main

func isSubtree(root *TreeNode, subRoot *TreeNode) bool {
	if root == nil {
		return false
	}
	if root.Val == subRoot.Val && _isSubtree(root, subRoot) {
		return true
	}
	if isSubtree(root.Left, subRoot) {
		return true
	}
	return isSubtree(root.Right, subRoot)
}

func _isSubtree(root *TreeNode, subRoot *TreeNode) bool {
	if subRoot == nil && root == nil {
		return true
	}
	if subRoot == nil || root == nil {
		return false
	}
	if root.Val != subRoot.Val {
		return false
	}
	return _isSubtree(root.Left, subRoot.Left) && _isSubtree(root.Right, subRoot.Right)
}
