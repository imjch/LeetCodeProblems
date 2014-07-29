//Evaluate the value of an arithmetic expression in Reverse Polish Notation.
//
//Valid operators are +, -, *, /. Each operand may be an integer or another expression.
//
//Some examples:
//  ["2", "1", "+", "3", "*"] -> ((2 + 1) * 3) -> 9
//  ["4", "13", "5", "/", "+"] -> (4 + (13 / 5)) -> 6

class Solution {
public:
    int evalRPN(vector<string> &tokens) {
    std::stack<int> s;
    int t;
    for (size_t i = 0; i < tokens.size(); i++)
    {
        if (tokens[i]=="+")
        {
            t = s.top();
            s.pop();
            t = s.top() + t;
            s.pop();
            s.push(t);
        }
        else if (tokens[i] == "-")
        {
            t = s.top();
            s.pop();
            t = s.top() - t;
            s.pop();
            s.push(t);
        }
        else if (tokens[i] == "*")
        {
            t = s.top();
            s.pop();
            t = s.top() * t;
            s.pop();
            s.push(t);
        }
        else if (tokens[i] == "/")
        {
            t = s.top();
            s.pop();
            t = s.top() / t;
            s.pop();
            s.push(t);
        }
        else
        {
            s.push(atoi(tokens[i].c_str()));
        }
    }
    return s.top();
    }
};