 
    public class Solution
    {
        public List<int> list=new List<int>();
        private int count=0;
        public IList<int> SpiralOrder(int[,] matrix)
        {
            var rows = matrix.GetLength(0);
            var cols = matrix.GetLength(1);
            var rank = rows <= cols ? rows : cols;
            count = rows * cols;
            for (int i = 0; i < rank/2+1; i++,rows--,cols--)
            {
                Outer(i, rows, cols, matrix);
            }
            
            return list;
        }

        public void Outer(int pos,int m,int n,int [,] matrix)
        {
            for (int j = pos; j < n && list.Count != count; j++)
            {
                list.Add(matrix[pos,j]);
            }
            for (int i = pos + 1; i < m && list.Count != count; i++)
            {
                list.Add(matrix[i, n-1]);
            }
            for (int j = n - 2; j >= pos && list.Count != count; j--)
            {
                list.Add(matrix[m-1, j]);
            }
            for (int i = m - 2; i > pos && list.Count != count; i--)
            {
                list.Add(matrix[i, pos]);
            }
        }
    }
