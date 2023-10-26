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

func postorderTraversal(root *TreeNode) []int {
	res := []int{}
	_postorderTraversal(root, &res)
	return res
}

func _postorderTraversal(root *TreeNode, res *[]int) {
	if root == nil {
		return
	}
	if root.Left != nil {
		_postorderTraversal(root.Left, res)
	}
	if root.Right != nil {
		_postorderTraversal(root.Right, res)
	}
	*res = append((*res), root.Val)
	return
}

func main() {
	root := &TreeNode{Val: 1}
	node1 := &TreeNode{Val: 2}
	node2 := &TreeNode{Val: 3}

	root.Right = node1
	node1.Left = node2
	res := postorderTraversal(root)
	fmt.Println(res)
}
