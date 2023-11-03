/**
 * Definition for a binary tree node.
 * type TreeNode struct {
 *     Val int
 *     Left *TreeNode
 *     Right *TreeNode
 * }
 */

func increasingBST(root *TreeNode) *TreeNode {
	head, _ := _increasingBST(root)
	return head
}

func _increasingBST(root *TreeNode) (*TreeNode, *TreeNode) {
	if root == nil {
		return nil, nil
	}
	var head *TreeNode = root
	var tail *TreeNode = root
	if root.Left != nil {
		var tmpTail *TreeNode 
		head, tmpTail = _increasingBST(root.Left)
		root.Left = nil
		tmpTail.Right = root
	}
	if root.Right != nil {
		var tmpHead *TreeNode 
		tmpHead, tail = _increasingBST(root.Right)
		root.Right = tmpHead
	}
	return head, tail
}