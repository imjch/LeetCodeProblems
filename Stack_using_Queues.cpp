class Stack {
public:
	 deque<int> queue;
	 // Push element x onto stack.
	 void push(int x) {
		 queue.push_back(x);
	 }

	 // Removes the element on top of the stack.
	 void pop() {
		 queue.pop_back();
	 }

	 // Get the top element.
	 int top() {
		 return queue.back();
	 }

	 // Return whether the stack is empty.
	 bool empty() {
		 return queue.empty();
	 }
};