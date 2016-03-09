    public class Solution
    {
        public int Divide(int dividend, int divisor)
        {
            if (divisor == 0||divisor==-1&&dividend==int.MinValue)
            {
                return int.MaxValue;
            }
            long newDividend = Math.Abs((long)dividend);
            long newDivisor = Math.Abs((long)divisor);
            var flag = (dividend < 0 && divisor > 0) || (dividend > 0 && divisor < 0);
            if (newDivisor == 1)
            {
                return (int)(flag ? -newDividend : newDividend);
            }
            if (newDividend == 0)
            {
                return 0;
            }
            var count = 0;
            var val = count;
            while (newDivisor <= newDividend)
            {
                count = 1;
                long tempDivisor = newDivisor;
                while (tempDivisor<<1<newDividend )
                {
                    tempDivisor <<= 1;
                    count <<= 1;
                }
                newDividend -= tempDivisor;
                val += count;
            }

            return flag ? -val : val;
        }
    }
