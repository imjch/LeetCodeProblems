/**
 * Definition for a binary tree node.
 * type TreeNode struct {
 *     Val int
 *     Left *TreeNode
 *     Right *TreeNode
 * }
 */
package main

func isUnivalTree(root *TreeNode) bool {
	if root == nil {
		return false
	}
	return _isUnivalTree(root, root.Val)
}

func _isUnivalTree(root *TreeNode, val int) bool {
	if root == nil {
		return true
	}
	if root.Val == val {
		return _isUnivalTree(root.Left, val) && _isUnivalTree(root.Right, val)
	}
	return false
}
