    public class Solution
    {
        public IList<IList<int>> Generate(int numRows)
        {
            var list = new List<IList<int>>();
            if (numRows==0)
            {
                return list;
            }
            list.Add(new List<int>(1){1});
            
            for (var i = 1; i < numRows; i++)
            {
                var l = new int[i+1];
                for (int j = 0,k=i; j<=k; j++,k--)
                {
                    var val = 0;
                    if (j - 1 >= 0)
                    {
                        val = list[i - 1][j - 1];
                    }
                    l[j] = val + list[i - 1][j];
                    l[k] = val + list[i - 1][j];
                }
                list.Add(l);
            }
            return list;
        }
    }
