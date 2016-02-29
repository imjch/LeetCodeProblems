    public class Solution
    {
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            if (triangle.Count==0)
            {
                return 0;
            }
            var resultArr = new int[triangle.Count];
            resultArr[0] = triangle[0][0];
            for (var i = 1; i < triangle.Count; i++)
            {
                var previoudRow = resultArr.ToArray();
                var currentRow = triangle[i];
                for (var j = 0; j < currentRow.Count; j++)
                {
                    if (j == 0)
                    {
                        resultArr[0] = previoudRow[0]+currentRow[0];
                    }
                    else if (j == currentRow.Count - 1)
                    {
                        resultArr[j] = previoudRow[j - 1] + currentRow[j];
                    }
                    else
                    {
                        resultArr[j] = Math.Min(previoudRow[j - 1] + currentRow[j], previoudRow[j] + currentRow[j]);
                    }
                }
            }
            return resultArr.Min();
        }
    }
