    public class Solution
    {
        private int[,] newGrid;
        public int UniquePathsWithObstacles(int[,] obstacleGrid)
        {
            newGrid = new int[obstacleGrid.GetLength(0), obstacleGrid.GetLength(1)];
            var endI = newGrid.GetLength(0) - 1;
            var endJ = newGrid.GetLength(1) - 1;
            for (var i = endI; i >=0 ; i--)
            {
                for (var j = endJ; j >=0 ; j--)
                {
                    if (obstacleGrid[i, j] == 1)
                    {
                        newGrid[i, j] = 0;
                        continue;
                    }
                    if (i == endI && j == endJ)
                    {
                        newGrid[i, j] = 1;
                        continue;
                    }
                    if (j == endJ)
                    {
                        newGrid[i, j] = newGrid[i+1, j ];
                        continue;
                    }
                    if (i==endI)
                    {
                        newGrid[i, j] = newGrid[i, j + 1];
                        continue;
                    }
                    newGrid[i, j] = newGrid[i, j + 1] + newGrid[i + 1, j];
                }
            }
            return newGrid[0,0];
        }
       
    }
