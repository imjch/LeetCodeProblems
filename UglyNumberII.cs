public class Solution {
    public int NthUglyNumber(int n) {
            var arr = new int[n];
            arr[0] = 1;
            var index2 = 0;
            var index3 = 0;
            var index5 = 0;
            var currentUglyNumIndex = 1;
            while (currentUglyNumIndex < n)
            {
                arr[currentUglyNumIndex] = Math.Min(Math.Min(arr[index2] * 2, arr[index3] * 3), arr[index5] * 5);
                while (arr[currentUglyNumIndex] >= arr[index2]*2)
                {
                    index2++;
                }
                while (arr[currentUglyNumIndex] >= arr[index3] * 3)
                {
                    index3++;
                }
                while (arr[currentUglyNumIndex] >= arr[index5] * 5)
                {
                    index5++;
                }
                ++currentUglyNumIndex;
            }
            return arr[n - 1];
    }
}
