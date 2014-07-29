//Given an input string, reverse the string word by word.
//
//For example,
//Given s = "the sky is blue",
//return "blue is sky the".
//
//
//Clarification:
//What constitutes a word?
//A sequence of non-space characters constitutes a word.
//Could the input string contain leading or trailing spaces?
//Yes. However, your reversed string should not contain leading or trailing spaces.
//How about multiple spaces between two words?
//Reduce them to a single space in the reversed string.
#include <iostream>
#include <string>
#include <stack>
using namespace std;
class Solution {
public:
void trim(std::string &s)
{
    if (s==" "||s.size()==0)
    {
        s = "";
        return;
    }
    int end = s.size() - 1;
    int begin = 0;
    while (s[begin] == ' '&&begin<end)
    {
        ++begin;
    }
    while (s[end] == ' '&&begin<end)
    {
        --end;
    }
    if (begin <= end)
    {
        s = s.substr(begin, end - begin + 1);
    }
    else
    {
        s = "";
    }
}
    void reverseWords(string &s) {
        trim(s);
    stack<std::string> stack;
    string tmp;
    for (size_t i = 0; i < s.size(); i++)
    {
        if (s[i] == ' ')
        {
            if (tmp.size()!=0)
            {
                stack.push(tmp);
                tmp.clear();
            }
            continue;
        }
        tmp.push_back(s[i]);
    }
    stack.push(tmp);
    s = "";
    while (stack.size() != 1)
    {
        s.append(stack.top()).append(" ");
        stack.pop();
    }
    s.append(stack.top());
    }
};