public class Solution {
       private int[,] flagMatrix;

        public bool Exist(char[,] board, string word)
        {
            flagMatrix = new int[board.GetLength(0),board.GetLength(1)];
            for (var i = 0; i < board.GetLength(0); i++)
            {
                for ( var j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] != word[0]) continue;
                  
                    if (__Exist(board, word, i, j,0))
                    {
                        return true;
                    }
                   
                }
            }
            
            return false;
        }
        public bool __Exist(char[,] board, string word, int beginI, int beginJ ,int strIndex)
        {
          
            if (strIndex == word.Length-1 && board[beginI, beginJ] == word[strIndex])
            {
                return true;
            }

            if (board[beginI, beginJ] != word[strIndex])
            {
                return false;
            }
            flagMatrix[beginI, beginJ] = 1;
            bool flag = false;
           
            if (beginI > 0 && flagMatrix[beginI - 1, beginJ] == 0)
            {
                flag = __Exist(board, word, beginI - 1, beginJ, strIndex + 1);
            }
            if (!flag && beginI < board.GetLength(0) - 1 && flagMatrix[beginI + 1, beginJ] == 0)
            {
                flag = __Exist(board, word, beginI + 1, beginJ, strIndex + 1);
            }
            if (!flag && beginJ > 0 && flagMatrix[beginI, beginJ - 1] == 0)
            {
                flag = __Exist(board, word, beginI, beginJ - 1, strIndex + 1);
            }
            if (!flag && beginJ < board.GetLength(1) - 1 && flagMatrix[beginI, beginJ + 1] == 0)
            {
                flag = __Exist(board, word, beginI, beginJ + 1, strIndex + 1);
            }

            flagMatrix[beginI, beginJ] = 0;
            return flag;
        }
}
