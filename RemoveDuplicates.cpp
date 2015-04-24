class Solution {
public:
    int removeDuplicates(int A[], int n) {
		set<int> set;
		for (size_t i = 0; i < n; i++)
		{
			set.insert(A[i]);
		}
		memset(A, 0, n);
		auto counter = 0;
		for (auto iter = set.begin(); iter != set.end(); ++iter)
		{
			A[counter] = *iter;
			counter++;
		}
		return counter;
    }
};