#include <iostream>
#include <cstring>
#include <string>
#include <algorithm>
using namespace std;
class Solution {
public:
    bool isAnagram(string s, string t) {
		sort(s.begin(),s.end());
		sort(t.begin(),t.end());
		
		return std::strcmp(s.c_str(),t.c_str())==0;
    }
};

int main(){
	Solution s;
	cout<<s.isAnagram(string("abc"),string("cba"))<<endl;
}