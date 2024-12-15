package main

import (
	"strconv"
	"strings"
)

/**
 * Definition for a binary tree node.
 * type TreeNode struct {
 *     Val int
 *     Left *TreeNode
 *     Right *TreeNode
 * }
 */
func binaryTreePaths(root *TreeNode) []string {
	recorder := []string{}
	res := []string{}
	_binaryTreePaths(root, recorder, &res)
	return res
}

func _binaryTreePaths(root *TreeNode, recorder []string, res *[]string) {
	if root == nil {
		return
	}
	recorder = append(recorder, strconv.Itoa(root.Val))
	if root.Left == nil && root.Right == nil {
		*res = append(*res, strings.Join(recorder, "->"))
		recorder = recorder[:len(recorder)-1]
		return
	}
	if root.Left != nil {
		_binaryTreePaths(root.Left, recorder, res)
	}
	if root.Right != nil {
		_binaryTreePaths(root.Right, recorder, res)
	}
	recorder = recorder[:len(recorder)-1]
}
