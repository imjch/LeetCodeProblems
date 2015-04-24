class Solution {
public:
	void generateParenthesis2(vector<string>& v, stack<char> s, string parenthesisStr, char symbol, int counter, int length) {
		if (counter > length)
		{
			return;
		}
		if (symbol == '(')
		{
			s.push('(');
			parenthesisStr.push_back('(');
		}
		else
		{
			if (s.size()!=0)
			{
				s.pop();
				parenthesisStr.push_back(')');
			}
			else
			{
				return;
			}
		}
		if (counter == length)
		{
			if (s.size() == 0)
				v.push_back(parenthesisStr);
			else
				return;
		}
		generateParenthesis2(v, s, parenthesisStr, '(', counter + 1, length);
		generateParenthesis2(v, s, parenthesisStr, ')', counter + 1, length);
	}
	vector<string> generateParenthesis(int n) {
	
		vector<string> v;
		stack<char> s;

		generateParenthesis2(v,s,string(""),'(',1,n*2);
		return v;
	}
};