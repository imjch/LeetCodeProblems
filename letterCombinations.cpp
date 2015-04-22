class Solution {
public:
	static vector<string> digitLetters;
	vector<string> letterCombinations(string digits) {
		vector<string> vectorStrs;
		if (digits.size()==0)
		{
			return vectorStrs;
		}
		innerLetterCombinations(vectorStrs,"",digits,0,digits.size());
		return vectorStrs;
	}

	void innerLetterCombinations(vector<string>& vectorStrs,string str,string& digits,int position,int len)
	{
		if (position == len)
		{
			vectorStrs.push_back(str);
			return;
		}
		string s = digitLetters[digits[position]-'0'];
		for (size_t i = 0; i < s.size(); i++)
		{
			str.push_back(s[i]);
			innerLetterCombinations(vectorStrs, str, digits, position + 1, len);
			str.pop_back();
		}
	}
};
   vector<string> Solution::digitLetters = {
	"",
	"",
	"abc",
	"def",
	"ghi",
	"jkl",
	"mno",
	"pqrs",
	"tuv",
	"wxyz" };