Longest Increasing Path in a Matrix public class Solution
    {
       
        int[,] cacheMatrix;
        public int LongestIncreasingPath(int[,] matrix)
        {
            
            cacheMatrix=new int[matrix.GetLength(0),matrix.GetLength(1)];
            int maxCount=0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int count = DFS(matrix,i,j);
                    maxCount = maxCount < count ? count : maxCount;
                }
            }

            return maxCount;
        }

        public int DFS(int[,] matrix, int i, int j)
        {

            if (cacheMatrix[i,j]>0)
            {
                return cacheMatrix[i, j];
            }
            int r1=0, r2=0, r3=0, r4=0;
            if (i > 0 && matrix[i, j] < matrix[i - 1, j]) r1=DFS(matrix, i - 1, j);
            if (i < matrix.GetLength(0) - 1 && matrix[i, j] < matrix[i + 1, j]) r2=DFS(matrix, i + 1, j);
            if (j > 0 && matrix[i, j] < matrix[i, j - 1]) r3=DFS(matrix, i, j - 1);
            if (j < matrix.GetLength(1) - 1 && matrix[i, j] < matrix[i, j + 1]) r4=DFS(matrix, i, j + 1);
            var max = Math.Max(Math.Max(r1, Math.Max(r2, r3)), r4)+1;
            cacheMatrix[i, j] = max;
            return max;
        }
    }
