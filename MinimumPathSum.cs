public class Solution {
         public int MinPathSum(int[,] grid)
         {
             var rows = grid.GetLength(0);
             var cols = grid.GetLength(1);
             var matrix = (int [,])grid.Clone();
             for (var i = 1; i < rows; i++)
             {
                 matrix[i, 0] += matrix[i - 1, 0];
             }
             for (var j = 1; j < cols; j++)
             {
                 matrix[0, j] += matrix[0, j - 1];
             }
             for (var i = 1; i < rows; i++)
             {
                 for (var j = 1; j < cols; j++)
                 {
                     matrix[i, j] += matrix[i, j - 1] < matrix[i - 1, j] ? matrix[i, j - 1] : matrix[i - 1, j];
                 }
             }

             return matrix[rows-1,cols-1];
         }
}
