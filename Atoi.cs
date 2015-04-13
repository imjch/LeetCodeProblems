        public static int Atoi(string str)
        {
            if (string.IsNullOrWhiteSpace(str) || str == string.Empty)
            {
                return 0;
            }
            var chArr = str.Trim().ToCharArray();
            char firstChar = chArr[0];
            var sb = new StringBuilder();
            if (Char.IsDigit(firstChar))
            {
                sb.Append(firstChar);
            }
            else if (firstChar == '+')
            {
                
            }
            else if (firstChar == '-')
            {
                
            }
            else
            {
                return 0;
            }

            for (int i = 1; i < chArr.Length; i++)
            {
                if (!Char.IsDigit(chArr[i]))
                {
                    break;
                }
                sb.Append(chArr[i]);    
            }
            BigInteger result;
            if (BigInteger.TryParse(sb.ToString(), out result) == false)
            {
                return 0;
            }

            result = firstChar == '-' ? -result : result;
            if (result>int.MaxValue)
            {
                return int.MaxValue;
            }
            if (result<int.MinValue)
            {
                return int.MinValue;
            }
            return (int)result;
        }