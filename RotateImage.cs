public class Solution {
 private void Swap(int xX,int xY, int yX, int yY, int[,] matrix)
        {
            try
            {
                var t = matrix[xX, xY];
                matrix[xX, xY] = matrix[yX, yY];
                matrix[yX, yY] = t;
            }
            catch (Exception)
            {
                Console.WriteLine(string.Format("Flag:{0},{1},{2},{3}", xX, xY, yX, yY));
                Console.Read();
            }
        }

        public void ReverseMainDiagonal(int [,] matrix)
        {
            var xX = matrix.GetLength(0) - 1;
            var xY = 0;
            var yX = 0;
            var yY = matrix.GetLength(0)-1;
            while (xY<yY)
            {
                Swap(xX,xY,yX,yY,matrix);
                xX--;
                xY++;
                yX++;
                yY--;
            }
        }

        public void RotateLeftSideLine(int xX,int yY,int [,] matrix)
        {
            var xY = 0;
            var yX = 0;
            while (xX > yX)
            {
                Swap(xX, xY, yX, yY, matrix);
                xX--;
                xY++;
                yX++;
                yY--;
            }
        }


        public void RotateRightSideLine(int xY, int yX, int[,] matrix)
        {
            var xX = matrix.GetLength(0)-1;
            var yY = matrix.GetLength(0)-1;
            while (xY < yY)
            {
                Swap(xX, xY, yX, yY, matrix);
                xX--;
                xY++;
                yX++;
                yY--;
            }
        }

        public void Rotate(int[,] matrix)
        {
            ReverseMainDiagonal(matrix);
           
            for (var i = 0; i < matrix.GetLength(0)-1; i++ )
            {
                RotateLeftSideLine(i, i, matrix);
            }
          
            for (var i = matrix.GetLength(0) - 1; i > 0; i--)
            {
                RotateRightSideLine(i, i, matrix);
            }
            
            var length = matrix.GetLength(1);
            for (var i = 0; i < length; i++)
            {
                var begin = 0;
                var end = length - 1;
                while (begin < end)
                {
                    Swap(i, begin, i, end, matrix);
                    begin++;
                    end--;
                }
            }
        }
}
