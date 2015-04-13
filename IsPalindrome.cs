 public static bool IsPalindrome(int x)
        {
            //bool signFlag = x < 0;
            if (x<0)
            {
                return false;
            }
            var y=x;
            var bitCount = 0;
            while (y!=0)
            {
                y/=10;
                bitCount++;
            }

            var m = (int)Math.Pow(10,bitCount-1);
            var n = 10;
            var n2 = 1;
            for (var i = 0; i < bitCount/2; i++)
            {
                if ((x/m%10)!=(x%n/n2))
                {
                    return false;
                }
                m /= 10;
                n *= 10;
                n2 *= 10;
            }
            return true;
        }
