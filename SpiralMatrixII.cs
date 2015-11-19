public class Solution {
        private int counter=1;
        private int count;
        public int[,] GenerateMatrix(int n)
        {
            var matrix = new int[n,n];
            count = n * n;
            int rank = n/2 + 1;
            for (int i = 0; i < rank; i++, n--)
            {
                Spiral(i, n, n, matrix);
            }
           
            return matrix;
        }

        public void Spiral(int pos, int m, int n, int[,] matrix)
        {
            for (int j = pos; j < n && count >= counter; j++,counter++)
            {
                matrix[pos, j]=counter;
            }
            for (int i = pos + 1; i < m && count >= counter; i++, counter++)
            {
                matrix[i, n - 1]=counter;
            }
            for (int j = n - 2; j >= pos && count >= counter; j--, counter++)
            {
                matrix[m - 1, j]=counter;
            }
            for (int i = m - 2; i > pos && count >= counter; i--, counter++)
            {
                matrix[i, pos]=counter;
            }
        }

}
