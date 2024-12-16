/**
 * Definition for a binary tree node.
 * type TreeNode struct {
 *     Val int
 *     Left *TreeNode
 *     Right *TreeNode
 * }
 */
package main

import "fmt"

type TreeNode struct {
	Val   int
	Left  *TreeNode
	Right *TreeNode
}

func lowestCommonAncestor(root, p, q *TreeNode) *TreeNode {
	a := &TreeNode{}
	_lowestCommonAncestor(root, p, q, a)
	return a
}

func _lowestCommonAncestor(root, p, q *TreeNode, resNode *TreeNode) bool {
	hitRoot := false
	if root.Val == p.Val || root.Val == q.Val {
		hitRoot = true
	}
	hitLeft := false
	if root.Left != nil {
		hitLeft = _lowestCommonAncestor(root.Left, p, q, resNode)
	}
	hitRight := false
	if root.Right != nil {
		hitRight = _lowestCommonAncestor(root.Right, p, q, resNode)
	}
	if (hitLeft && hitRight) ||
		(hitRoot && hitLeft) ||
		(hitRoot && hitRight) {
		resNode.Val = root.Val
		return true
	}
	return hitLeft || hitRight || hitRoot
}

func main() {
	root := &TreeNode{Val: 10}

	root.Left = &TreeNode{Val: 5}
	root.Right = &TreeNode{Val: 15}

	root.Left.Left = &TreeNode{Val: 3}
	root.Left.Right = &TreeNode{Val: 7}

	root.Right.Right = &TreeNode{Val: 18}
	fmt.Print(lowestCommonAncestor(root, &TreeNode{Val: 3}, &TreeNode{Val: 7}))
}
