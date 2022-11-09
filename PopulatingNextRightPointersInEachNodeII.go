/*
Given a binary tree

struct Node {
  int val;
  Node *left;
  Node *right;
  Node *next;
}
Populate each next pointer to point to its next right node. If there is no next right node, the next pointer should be set to NULL.

Initially, all next pointers are set to NULL.



Example 1:


Input: root = [1,2,3,4,5,null,7]
Output: [1,#,2,3,#,4,5,7,#]
Explanation: Given the above binary tree (Figure A), your function should populate each next pointer to point to its next right node, just like in Figure B. The serialized output is in level order as connected by the next pointers, with '#' signifying the end of each level.
Example 2:

Input: root = []
Output: []


Constraints:

The number of nodes in the tree is in the range [0, 6000].
-100 <= Node.val <= 100


Follow-up:

You may only use constant extra space.
The recursive approach is fine. You may assume implicit stack space does not count as extra space for this problem.

*/

/**
 * Definition for a Node.
 * type Node struct {
 *     Val int
 *     Left *Node
 *     Right *Node
 *     Next *Node
 * }
 */
package main

import "fmt"

type Node struct {
	Val   int
	Left  *Node
	Right *Node
	Next  *Node
}

// 解析思路： 插nil使其始终在一层的最右
func connect(root *Node) *Node {
	if root == nil {
		return root
	}
	queue := make([]*Node, 0)
	queue = append(queue, root, nil)
	for len(queue) > 1 {

		// get head node
		curNode := queue[0]
		// pop head node
		queue = queue[1:]
		if curNode == nil {
			queue = append(queue, nil)
			continue
		}

		if curNode.Left != nil {
			queue = append(queue, curNode.Left)
		}
		if curNode.Right != nil {
			queue = append(queue, curNode.Right)
		}
		curNode.Next = queue[0]
	}

	return root
}

func foreachTree(root *Node) {
	if root == nil {
		return
	}
	fmt.Print("value:%d\n", root.Val)
	foreachTree(root.Left)
	foreachTree(root.Right)
}

func main() {
	fourNode := &Node{
		Val: 4,
	}
	threeNode := &Node{
		Val: 3,
	}
	secondNode := &Node{
		Val:   2,
		Left:  threeNode,
		Right: fourNode,
	}
	rootNode := &Node{
		Val:  1,
		Left: secondNode,
	}
	connect(rootNode)
	//foreachTree(rootNode)
	fmt.Print("%+v", *rootNode.Left.Left)
}
