public class Solution {
         public int UniquePaths(int m, int n)
         {
             var matrix = new int[m, n];
             matrix[0, 0] = 1;
             for (var i = 1; i < m; i++)
             {
                 matrix[i, 0] = 1;
             }
             for (var i = 1; i < n; i++)
             {
                 matrix[0, i] = 1;
             }
             for (var i = 1; i < m; i++)
             {
                 for (var j = 1; j < n; j++)
                 {
                     matrix[i, j] = matrix[i - 1, j]+matrix[i,j-1];
                 }
             }
             return matrix[m-1,n-1];
         }
}
