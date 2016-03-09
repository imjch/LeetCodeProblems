    public class Solution
    {
        private List<IList<int>> list = new List<IList<int>>();
        public IList<IList<int>> Combine(int n, int k)
        {
            var arr = new List<int>(n);
            for (var i = 0; i < n; i++)
            {
                arr.Add( i + 1);
            }
            _Combine(arr,0,k,new Stack<int>(k));
            return list;
        }

        public void _Combine(List<int> arr, int begin, int k, Stack<int> l)
        {
            if (begin>arr.Count)
            {
                return;
            }
            if (l.Count==k)
            {
                list.Add(l.Reverse().ToList());
                return;
            }
            for (var i = begin; i < arr.Count; i++)
            {
                l.Push(arr[i]);
                _Combine(arr,i+1,k, l);
                l.Pop();
            }
        }
    }
