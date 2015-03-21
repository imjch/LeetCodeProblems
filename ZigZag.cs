        static string Convert(String s, int nRows)
        {
            if (nRows==1)
            {
                return s;
            }
            var sbList = new List<StringBuilder>(nRows);
            for (int i = 0; i < nRows; i++)
            {
                sbList.Add(new StringBuilder(s.Length/nRows));
            }
            var resultStr = new StringBuilder(s.Length*2);
            var currentCharIndex = 0;
            var strLength = s.Length;

            while (currentCharIndex < strLength)
            {
                for (int i = 0; i < nRows && currentCharIndex < strLength; i++, currentCharIndex++)
                {
                    sbList[i].Append(s[currentCharIndex]);//由上至下
                }
                for (int i = nRows-2; i >=1 && currentCharIndex < strLength; i--, currentCharIndex++)
                {
                    sbList[i].Append(s[currentCharIndex]);//由下再至上
                }
            }
            foreach (var sb in sbList)
            {
                resultStr.Append(sb.ToString());
            }
            return resultStr.ToString();
        }