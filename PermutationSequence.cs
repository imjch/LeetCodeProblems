    public class Solution
    {
        int count = 0;
        
        int max = 0;
        readonly HashSet<int> set = new HashSet<int>();
        void Swap(int i, int j, StringBuilder arr)
        {
            var t = arr[i];
            arr[i] = arr[j];
            arr[j] = t;
        }

        public string GetPermutation(int n, int k)
        {

            var arr = new StringBuilder();
            for (var i = 0; i < n; i++)
            {
                arr.Append(i + 1);
            }
            count = k;
            var s=string.Empty;
            Permutation(ref s, 0, n, arr);
            return s;
        }

        public void Permutation(ref string str, int begin, int end, StringBuilder arr)
        {
            if (begin > end||!string.IsNullOrEmpty(str))
            {
                return;
            }
            if (begin == end)
            {
                int t = Convert.ToInt32(arr.ToString());
                max = t > max ? t : max;
                if (--count == 0)
                {
                    str = max.ToString();
                }
            }
            for (var i = begin; i < end; i++)
            {
                Swap(begin, i, arr);
                Permutation(ref str, begin + 1, end, arr);
                Swap(begin, i, arr);
            }
          
        }

    }
