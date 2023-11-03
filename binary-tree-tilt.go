package main

import "math"

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

func findTilt(root *TreeNode) int {
	_, sumDiff := _findTilt(root)
	return sumDiff
}

func _findTilt(root *TreeNode) (int, int) {
	if root == nil {
		return 0, 0
	}

	leftDiff := 0
	leftSum := 0
	if root.Left != nil {
		leftSum, leftDiff = _findTilt(root.Left)
	}

	rightDiff := 0
	rightSum := 0
	if root.Right != nil {
		rightSum, rightDiff = _findTilt(root.Right)
	}
	diff := int(math.Abs(float64(leftSum) - float64(rightSum)))

	sumVal := root.Val + leftSum + rightSum
	sumDiff := diff + rightDiff + leftDiff
	return sumVal, sumDiff
}
