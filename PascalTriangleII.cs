public class Solution {
        public IList<int> GetRow(int rowIndex)
        {
            rowIndex += 1;
            var lastList = new int[1]{ 1 };

            for (var i = 1; i < rowIndex; i++)
            {
                var currentRow = new int[i + 1];
                for (int j = 0, k = i; j <= k; j++, k--)
                {
                    var val = 0;
                    if (j - 1 >= 0)
                    {
                        val = lastList[j - 1];
                    }
                    currentRow[j] = val + lastList[j];
                    currentRow[k] = val + lastList[j];
                }
                lastList = null;
                lastList = currentRow;
            }
            return lastList;
        }
}
