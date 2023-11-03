
// Definition for a binary tree node.
type TreeNode struct {
	Val   int
	Left  *TreeNode
	Right *TreeNode
}

func isCousins(root *TreeNode, x int, y int) bool {
	if root == nil {
		return false
	}
	queue := []*TreeNode{
		root,
		nil,
	}
	depth := 0
//	xFlag := false
	xDept := 0
	xPreVal := 0
//	yFlag := false
	yDept := 0
	yPreVal := 0

	for len(queue) > 0 {
		ele := queue[0]
		queue = queue[1:]
		if ele == nil {
			if len(queue) == 0 {
				return false
			}
			queue = append(queue, nil)
			depth++
			continue
		}
		if ele.Left != nil {
			queue = append(queue, ele.Left)
			if ele.Left.Val == x {
//				xFlag = true
				xDept = depth
				xPreVal = ele.Val
			}
			if ele.Left.Val == y {
//				yFlag = true
				yDept = depth
				yPreVal = ele.Val
			}
		}
		if ele.Right != nil {
			queue = append(queue, ele.Right)
			if ele.Right.Val == x {
//				xFlag = true
				xDept = depth
				xPreVal = ele.Val
			}
			if ele.Right.Val == y {
//				yFlag = true
				yDept = depth
				yPreVal = ele.Val
			}
		}
		if xDept != 0 && xDept == yDept && xPreVal != yPreVal {
			return true
		}
	}
	return false
}