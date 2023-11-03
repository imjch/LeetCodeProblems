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

func findMode(root *TreeNode) []int {
	if root == nil {
		return []int{}
	}
	res := []int{}
	curCount := 0
	preMax := 0
	preV := -1000000
	_findMode(root, &preV, &preMax, &curCount, &res)
	return res
}

// 逐次记录当前可能的mode值与频次，
func _findMode(root *TreeNode, preVal *int, preMax *int, curCount *int, res *[]int) {
	if root == nil {
		return
	}
	if root.Left != nil {
		_findMode(root.Left, preVal, preMax, curCount, res)
	}

	if *preVal == -1000000 {
		*curCount = 1
		*preVal = root.Val
	} else if root.Val == *preVal {
		*curCount++
	} else {
		*curCount = 1
		*preVal = root.Val
	}
	//fmt.Println(*curCount)
	if *curCount > *preMax {
		*preMax = *curCount
		*res = []int{*preVal}
	} else if *curCount == *preMax {
		// *preMax = *curCount
		*res = append(*res, root.Val)
	}

	if root.Right != nil {
		_findMode(root.Right, preVal, preMax, curCount, res)
	}
	return
}

func main() {
	node1 := &TreeNode{
		Val: 1,
	}
	node2 := &TreeNode{
		Val:  1,
		Left: node1,
	}
	fmt.Println(findMode(node2))
}
