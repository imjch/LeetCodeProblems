package main

/*
*
  - Definition for a binary tree node.
    type TreeNode struct {
    Val int
    Left *TreeNode
    Right *TreeNode
    }
*/
type TreeNode struct {
	Val   int
	Left  *TreeNode
	Right *TreeNode
}

func _leadSimilar(root *TreeNode, res *[]int) {
	if root == nil {
		return
	}
	if root.Left == nil && root.Right == nil {
		*res = append(*res, root.Val)
	} else {
		_leadSimilar(root.Left, res)
		_leadSimilar(root.Right, res)
	}
}

func leafSimilar(root1 *TreeNode, root2 *TreeNode) bool {
	res1, res2 := []int{}, []int{}
	_leadSimilar(root1, &res1)
	_leadSimilar(root2, &res2)
	if len(res1) != len(res2) {
		return false
	}
	for i := 0; i < len(res1); i++ {
		if res1[i] != res2[i] {
			return false
		}
	}
	return true
}
