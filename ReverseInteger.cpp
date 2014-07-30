//Reverse digits of an integer.
//
//Example1: x = 123, return 321
//Example2: x = -123, return -321
//
//
//Have you thought about this?
//Here are some good questions to ask before coding. Bonus points for you if you have already thought through this!
//
//If the integer's last digit is 0, what should the output be? ie, cases such as 10, 100.
//
//Did you notice that the reversed integer might overflow? Assume the input is a 32-bit integer, then the reverse of 1000000003 overflows. How should you handle such cases?
//
//Throw an exception? Good, but what if throwing an exception is not an option? You would then have to re-design the function (ie, add an extra parameter).

class Solution {
public:
    int reverse(int x) {
    long long num=0;
    char str[1024];
    memset(str,0,1024);
    int  i = 0, m = 1;
    bool flag = false;
    if (x<0)
    {
        x = -x;
        flag = 1;
    }
    while (x!=0)
    {
        str[i] = (x % 10)+'0';
        x /= 10;
        i++;
    }

    while (i!=0)
    {
        num += (str[i-1] - '0')*m;
        m *= 10;
        --i;
    }

    if (flag)
    {
        num = -num;
    }
    return num;
    }
};