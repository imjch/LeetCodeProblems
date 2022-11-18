/*
1115. Print FooBar Alternately

Suppose you are given the following code:

class FooBar {
  public void foo() {
    for (int i = 0; i < n; i++) {
      print("foo");
    }
  }

  public void bar() {
    for (int i = 0; i < n; i++) {
      print("bar");
    }
  }
}
The same instance of FooBar will be passed to two different threads:

thread A will call foo(), while
thread B will call bar().
Modify the given program to output "foobar" n times.

 

Example 1:

Input: n = 1
Output: "foobar"
Explanation: There are two threads being fired asynchronously. One of them calls foo(), while the other calls bar().
"foobar" is being output 1 time.
Example 2:

Input: n = 2
Output: "foobarfoobar"
Explanation: "foobar" is being output 2 times.
 

Constraints:

1 <= n <= 1000
*/

#include <functional>
#include <iostream>
#include <mutex>          // std::mutex
#include <thread>         // std::thread
#include <condition_variable>

using namespace std;

class FooBar {
private:
    int n;
    mutex mtxFoo;
    mutex mtxBar;
public:
    FooBar(int n) {
        this->n = n;
        mtxBar.lock();
    }

    void foo(function<void()> printFoo) {
        for (int i = 0; i < n; i++) {
            mtxFoo.lock();
        	  printFoo();
            mtxBar.unlock();
        }
    }

    void bar(function<void()> printBar) {
        for (int i = 0; i < n; i++) {
            mtxBar.lock();
            printBar();
            mtxFoo.unlock();
        }
    }
};

int main(int argc, char const *argv[])
{


  FooBar fb(10);
  // fb.foo([]{cout<<"foo";});
  // fb.bar([]{cout<<"bar";});
  function<void()> fooFunc = [](){cout<<"foo";};
  function<void()> barFunc = [](){cout<<"bar";};
  thread threadFoo(&FooBar::foo, &fb, fooFunc);
  thread threadBar(&FooBar::bar, &fb, barFunc);
  threadFoo.join();
  threadBar.join();
  return 0;
}

