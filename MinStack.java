Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.

push(x) -- Push element x onto stack.
pop() -- Removes the element on top of the stack.
top() -- Get the top element.
getMin() -- Retrieve the minimum element in the stack.
Example:
MinStack minStack = new MinStack();
minStack.push(-2);
minStack.push(0);
minStack.push(-3);
minStack.getMin();   --> Returns -3.
minStack.pop();
minStack.top();      --> Returns 0.
minStack.getMin();   --> Returns -2.


class MinStack {

    /** initialize your data structure here. */
    long min=Integer.MAX_VALUE;
    Stack<Long> stack = new Stack<>();
    public MinStack() {

    }

    public void push(int x) {
        stack.add(x-min);
        min=x<min?x:min;
    }

    public void pop(){
        long val = stack.pop();
        if (val<0){
            min=min-val;
        }
    }

  public int top() {
        long val = stack.peek();
        if(val<0){
            return (int)min;
        }
        return (int)(min+val);
    }

    public int getMin() {
        return  (int)min;
    }
}