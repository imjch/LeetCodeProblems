    public class Solution
    {
        public string GetPermutation(int n, int k)
        {
            var fac = new List<int>(n+1){1};
            for (var i = 1; i <= n; i++)
            {
                fac.Add(fac[i - 1] * i);
            }
            var numbers = new List<int>(n);
            for (var i = 1; i <= n; i++)
            {
                numbers.Add(i);
            }
            var sb = new StringBuilder(n);
            k--;
            while (numbers.Count!=0)
            {
                var index = k / fac[numbers.Count - 1];
                k = k % fac[numbers.Count - 1] ;
                sb.Append(numbers[index]);
                numbers.RemoveAt(index);
            }
            return sb.ToString();
        }
    }
