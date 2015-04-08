        public static string LongestPalindrome(string s)
        {
            var newLen = s.Length*2 + 3;
            var chArr = new char[newLen];
            if (s.Length==1||string.IsNullOrEmpty(s))
            {
                return s;
            }
            chArr[0] = '$';
            var j = 1;
            for (;j <= s.Length;j++)
            {
                chArr[j * 2] = s[j-1];
                chArr[j * 2 - 1] = '#';
            }
            chArr[j * 2 - 1] = '#';
            chArr[j * 2] = '\0';
            var mx = 0;
            var auxArr = new int[newLen];
             
            var id = 0;//i关于id的对称点
            var longestIndex = 0;
            var longestLen = 0;
            for (var i = 1; chArr[i]!='\0'; i++)
            {
                if (mx > i)
                {
                    auxArr[i] = mx - i > auxArr[2 * id - i] ? auxArr[2 * id - i] : mx - i;
                }
                else
                {
                    auxArr[i] = 1;
                }
                while (chArr[i + auxArr[i]] == chArr[i - auxArr[i]])
                {
                    auxArr[i]++;
                }
                if (i+auxArr[i]>mx)
                {
                    
                    mx = i + auxArr[i];
                    id = i;
                    if (mx - id + 1 > longestLen)
                    {
                        longestLen=mx-id;
                        longestIndex=id;
                    }
                }
            }
            var sb = new StringBuilder();
            var len = chArr.Max();
            for (int i = longestIndex - longestLen+1; i < longestIndex+longestLen; i++)
            {
                if (chArr[i]!='#')
                {
                    sb.Append(chArr[i]);
                }
            }
            return sb.ToString();
        }