int e;
class Solution {
public:
	int removeElement(int A[], int n, int elem) {
		e = elem;
		int* begin = A;
		int* end = remove_if(A, A + n, Solution::equals);
		return  (end - begin);
	}
	static bool equals(int x){ return x ==e; }
};