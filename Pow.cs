 public class Solution
    {
        public double MyPow(double x, int n)
        {
            double val = 1;
            if (n > 0)
            {
               return  Math.Round(_MyPowPositive(x, n),5);
            }
            _MyPowNegtive(x,ref val,n);
            return Math.Round(val,5);
        }

       
        public void _MyPowNegtive(double x,ref double r, int n)
        {
            if (n == -1)
            {
                r *= 1 / x;
                return;
            }
            if (n == 0)
            {
                r *= 1;
                return;
            }
            if (n % 2 == 0)
            {
                 _MyPowNegtive(x * x, ref r, n/2);
            }
            else
            {
                r *= 1 / x;
                _MyPowNegtive(x * x, ref r, n/2);
            }

        }
        public double _MyPowPositive(double x, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            if (n==1)
            {
                return x;
            }
          
            if (n%2==0)
            {
                return _MyPowPositive(x * x, n / 2 );
            }
            return x * _MyPowPositive(x * x, n / 2);
        }
    }
