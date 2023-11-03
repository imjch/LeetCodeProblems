package main

/**
 * Definition for a binary tree node.
 * type TreeNode struct {
 *     Val int
 *     Left *TreeNode
 *     Right *TreeNode
 * }
 */

type TreeNode struct {
	Val   int
	Left  *TreeNode
	Right *TreeNode
}

func searchBST(root *TreeNode, val int) *TreeNode {
	if root == nil {
		return nil
	}
	if root.Val == val {
		return root
	}
	var left *TreeNode
	if root.Left != nil {
		left = searchBST(root.Left, val)
	}
	if left != nil {
		return left
	}
	if root.Right != nil {
		return searchBST(root.Right, val)
	}
	return nil
}
