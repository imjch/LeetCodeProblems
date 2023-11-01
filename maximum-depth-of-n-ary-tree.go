/**
 * Definition for a Node.
 * type Node struct {
 *     Val int
 *     Children []*Node
 * }
 */
package main

type Node struct {
	Val      int
	Children []*Node
}

func maxDepth(root *Node) int {
	if root == nil {
		return 0
	}

	queue := []*Node{
		root,
		nil,
	}
	levenCnt := 1
	for len(queue) > 0 {
		// 如果当前队列只剩nil，则结束流程
		ele := queue[0]
		queue = queue[1:]
		if ele == nil {
			if len(queue) == 0 {
				break
			}
			queue = append(queue, nil)
			levenCnt++
			continue
		}
		for _, item := range ele.Children {
			queue = append(queue, item)
		}
	}
	return levenCnt
}
