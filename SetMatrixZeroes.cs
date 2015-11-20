public class Solution {
 public void SetZeroes(int[,] matrix)
 {
             var rows = matrix.GetLength(0);
             var cols = matrix.GetLength(1);
             var rowIndex = new int[rows];
             var colIndex = new int[cols];
             for (int i = 0; i < rows; i++)
             {
                 for (int j = 0; j < cols; j++)
                 {
                     if (matrix[i, j]==0)
                     {
                         rowIndex[i] = 1;
                         colIndex[j] = 1;
                     }
                 }
             }
             for (int i = 0; i < rowIndex.Length; i++)
             {
                 if (rowIndex[i]==1)
                 {
                     for (int j = 0; j < cols; j++)
                     {
                         matrix[i, j] = 0;
                     }
                 }
             }
             for (int i = 0; i < colIndex.Length; i++)
             {
                 if (colIndex[i] == 1)
                 {
                     for (int j = 0; j < rows; j++)
                     {
                         matrix[j, i] = 0;
                     }
                 }
             }
         }
}