    public class Solution
    {
        public void Solve(char[,] board)
        {
            var row = board.GetLength(0);
            var col = board.GetLength(1);

            for (var i = 0; i < col; i++)
            {
                if (board[0,i]=='O')
                {
                    board[0, i] = '1';
                    Solve(board,0,i);
                }
            }
            for (var i = 0; i < col; i++)
            {
                if (board[row-1, i] == 'O')
                {
                    board[row - 1, i] = '1';
                    Solve(board, row - 1, i);
                }
            }
            for (var i = 1; i < row-1; i++)
            {
                if (board[i,0 ] == 'O')
                {
                    board[i, 0] = '1';
                    Solve(board, i, 0);
                }
            }
            for (var i = 1; i < row-1; i++)
            {
                if (board[i, col - 1] == 'O')
                {
                    board[i, col - 1] = '1';
                    Solve(board, i, col - 1);
                }
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (board[i, j] == 'O')
                    {
                        board[i, j] = 'X';
                    }
                }
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (board[i, j] == '1')
                    {
                        board[i, j] = 'O';
                    }
                }
            }
        }

        public void Solve(char[,] matrix, int i, int j)
        {
            var row = matrix.GetLength(0);
            var col = matrix.GetLength(1);
            if (i > 1 && matrix[i - 1,j] == 'O')
            {
                matrix[i - 1,j] = '1';
                Solve(matrix,i-1,j);
            }
            if (i < row - 1 && matrix[i + 1, j] == 'O')
            {
                matrix[i + 1,j] = '1';
                Solve(matrix, i + 1, j);
            }
            if (j > 1 && matrix[i,j - 1] == 'O')
            {
                matrix[i,j - 1] = '1';
                Solve(matrix, i , j-1);
            }
            if (j < col - 1 && matrix[i,j + 1] == 'O')
            {
                matrix[i,j + 1] = '1';
                Solve(matrix, i , j+1);
            }
        }
    }