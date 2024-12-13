/*
https://leetcode.com/problems/average-of-levels-in-binary-tree/description/?envType=study-plan-v2&envId=top-interview-150
*/

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

func averageOfLevels(root *TreeNode) []float64 {
	if root == nil {
		return []float64{}
	}
	res := []float64{}
	queue := []*TreeNode{root}
	for len(queue) > 0 {
		newQueue := []*TreeNode{}
		tmpRes := 0.0
		tmpCnt := 0.0
		for len(queue) > 0 {
			node := queue[0]
			if node.Left != nil {
				newQueue = append(newQueue, node.Left)
			}
			if node.Right != nil {
				newQueue = append(newQueue, node.Right)
			}
			queue = queue[1:]
			tmpRes += float64(node.Val)
			tmpCnt += 1
		}
		queue = newQueue
		res = append(res, tmpRes/tmpCnt)
	}
	return res
}

func main() {
	root := &TreeNode{Val: 3}
	root.Left = &TreeNode{Val: 9}
	root.Right = &TreeNode{Val: 20}
	root.Right.Left = &TreeNode{Val: 15}
	root.Right.Right = &TreeNode{Val: 7}

	fmt.Print(averageOfLevels(root))
}
