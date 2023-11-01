/**
 * Definition for singly-linked list.
 * type ListNode struct {
 *     Val int
 *     Next *ListNode
 * }
 */
package main

import "fmt"

type ListNode struct {
	Val  int
	Next *ListNode
}

func isPalindrome(head *ListNode) bool {
	if head.Next == nil {
		return true
	}
	fast := head
	slow := head
	var prev *ListNode
	for fast != nil && fast.Next != nil {
		head = head.Next
		fast = fast.Next.Next
		slow.Next = prev
		prev = slow
		slow = head
	}

	if fast != nil {
		slow = slow.Next
	}

	for prev != nil && slow != nil {
		if prev.Val != slow.Val {
			return false
		}
		prev = prev.Next
		slow = slow.Next
	}
	return true
}

func main() {
	n3 := &ListNode{
		Val: 1,
	}
	n2 := &ListNode{
		Val:  0,
		Next: n3,
	}
	n1 := &ListNode{
		Val:  1,
		Next: n2,
	}
	fmt.Print(isPalindrome(n1))
}
