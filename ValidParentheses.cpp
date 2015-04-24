class Solution {
public:
    bool isValid(string s) {
         stack<char> stack;
		 stack.push(s[0]);

		 for (auto i = 1; i < s.size(); i++)
		 {
		
			 if (s[i]==')'||s[i]=='}'||s[i]==']')
			 {
				 if (stack.empty())
				 {
					 return false;
				 }
				 char topChar = stack.top();
				 switch (s[i])
				 {
				 case ')':
					 if (topChar == '(') stack.pop(); else return false;
					 break;
				 case ']':
					 if (topChar == '[') stack.pop(); else return false;
					 break;
				 case '}':
					 if (topChar == '{') stack.pop(); else return false;
					 break;
				 default:
					 return false;
				 }
			 }
			 else
			 {
				 stack.push(s[i]);
			 }
		 }
		 return stack.empty();
    }
};