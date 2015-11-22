public class Solution {
    public int ClimbStairs(int n) {
             if (n==0||n==1)
             {
                 return n;
             }
             int a = 1, b = 2;
             while (n-- > 2)
             {
                 b = a + b;
                 a = b - a;

             }
             return b;
    }
}