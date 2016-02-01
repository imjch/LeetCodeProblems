public class Solution {
    public int NumSquares(int n) {
    var arr = new int[n + 1];//what arr stored is the least count of perfect square needed by every positive integer i
            for (int i = 1; i <= n; i++)
            {
                arr[i] = int.MaxValue;
            }
            for (var i = 0; i <= n; i++)
            {
                for (var j= 1; i+j*j<= n; j++)
                {
                    if (arr[i+j*j]>arr[i]+1)
                    {
                        arr[i + j * j] = arr[i] + 1;
                    }
                }
            }
            return arr[n];
    }
}
