/*
232. Implement Queue using Stacks
Easy
6.8K
384
Companies
Implement a first in first out (FIFO) queue using only two stacks. The implemented queue should support all the functions of a normal queue (push, peek, pop, and empty).

Implement the MyQueue class:

void push(int x) Pushes element x to the back of the queue.
int pop() Removes the element from the front of the queue and returns it.
int peek() Returns the element at the front of the queue.
boolean empty() Returns true if the queue is empty, false otherwise.
Notes:

You must use only standard operations of a stack, which means only push to top, peek/pop from top, size, and is empty operations are valid.
Depending on your language, the stack may not be supported natively. You may simulate a stack using a list or deque (double-ended queue) as long as you use only a stack's standard operations.


Example 1:

Input
["MyQueue", "push", "push", "peek", "pop", "empty"]
[[], [1], [2], [], [], []]
Output
[null, null, null, 1, 1, false]

Explanation
MyQueue myQueue = new MyQueue();
myQueue.push(1); // queue is: [1]
myQueue.push(2); // queue is: [1, 2] (leftmost is front of the queue)
myQueue.peek(); // return 1
myQueue.pop(); // return 1, queue is [2]
myQueue.empty(); // return false


Constraints:

1 <= x <= 9
At most 100 calls will be made to push, pop, peek, and empty.
All the calls to pop and peek are valid.


Follow-up: Can you implement the queue such that each operation is amortized O(1) time complexity? In other words, performing n operations will take overall O(n) time even if one of those operations may take longer.
*/

package main

import "fmt"

type MyQueue struct {
	stack1 []int
	stack2 []int
}

func Constructor() MyQueue {
	return MyQueue{
		stack1: []int{},
		stack2: []int{},
	}
}

func (this *MyQueue) Push(x int) {
	this.stack1 = append(this.stack1, x)
}

func (this *MyQueue) Pop() int {
	this.stack2 = make([]int, 0, len(this.stack1))
	// 将stack1逆序放入stack2
	for _, item := range this.stack1 {
		this.stack2 = append([]int{item}, this.stack2...)
	}
	// 此时stack2的pop操作即为queue的pop
	ele := this.stack2[len(this.stack2)-1]
	this.stack2 = this.stack2[0 : len(this.stack2)-1]

	this.stack1 = make([]int, 0, len(this.stack1))
	// 将stack1逆序放入stack2
	for _, item := range this.stack2 {
		this.stack1 = append([]int{item}, this.stack1...)
	}
	return ele
}

func (this *MyQueue) Peek() int {
	return this.stack1[0]
}

func (this *MyQueue) Empty() bool {
	return len(this.stack1) == 0
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * obj := Constructor();
 * obj.Push(x);
 * param_2 := obj.Pop();
 * param_3 := obj.Peek();
 * param_4 := obj.Empty();
 */

func main() {
	obj := Constructor()
	obj.Push(1)
	obj.Push(2)
	param_2 := obj.Peek()
	param_3 := obj.Pop()
	param_4 := obj.Empty()
	fmt.Println(param_2, param_3, param_4)
}
