   public class Solution
    {
        public int MySqrt(int x)
        {
            var low = 0.0;
            var mid = 0.0;
            var high = (double)x;
            var last = 0.0;
            do
            {
              
                if (Math.Pow(mid,2)>x)
                {
                    high = mid;
                }
                else
                {
                    low = mid;
                }
                last = mid;
                mid = (low + high) / 2;
            } while (Math.Abs(last-mid)>float.Epsilon);
            return (int)mid;
        }
    }
