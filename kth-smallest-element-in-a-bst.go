package main

import "fmt"

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

func kthSmallest(root *TreeNode, k int) int {
	res := -1
	_kthSmallest(root, &k, &res)
	return res
}

func _kthSmallest(root *TreeNode, k *int, res *int) {
	if root == nil {
		return
	}
	if root.Left != nil {
		_kthSmallest(root.Left, k, res)
	}
	if *res != -1 {
		return
	}
	if *k == 1 {
		*res = root.Val
		return
	} else {
		(*k) -= 1
	}
	if root.Right != nil {
		_kthSmallest(root.Right, k, res)
	}
}

func main() {
	root := &TreeNode{Val: 10}

	root.Left = &TreeNode{Val: 5}
	root.Right = &TreeNode{Val: 15}

	root.Left.Left = &TreeNode{Val: 3}
	root.Left.Right = &TreeNode{Val: 7}

	root.Right.Right = &TreeNode{Val: 18}
	fmt.Print(kthSmallest(root, 3))
}
