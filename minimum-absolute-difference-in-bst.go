package main

import (
	"fmt"
	"math"
)

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

func getMinimumDifference(root *TreeNode) int {
	min := 999999
	var lastNode *TreeNode = &TreeNode{Val: -1}
	_getMinimumDifference(root, lastNode, &min)
	return min
}

func _getMinimumDifference(root *TreeNode, lastNode *TreeNode, min *int) {
	if root.Left != nil {
		_getMinimumDifference(root.Left, lastNode, min)
	}

	if lastNode.Val != -1 && math.Abs(float64(root.Val-(*lastNode).Val)) < float64(*min) {
		*min = int(math.Abs(float64(root.Val - (*lastNode).Val)))
	}

	lastNode.Val = root.Val
	if root.Right != nil {
		_getMinimumDifference(root.Right, lastNode, min)
	}
	return
}

func main() {
	root := &TreeNode{Val: 1}
	root.Left = &TreeNode{Val: 0}
	root.Right = &TreeNode{Val: 48}
	root.Right.Left = &TreeNode{Val: 12}
	root.Right.Right = &TreeNode{Val: 49}
	fmt.Print(getMinimumDifference(root))
}
