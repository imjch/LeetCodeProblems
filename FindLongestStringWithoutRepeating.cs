 //动态规划思想，每一轮记录上一次的字符串长，记录currentLen
        static int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            var visited = new int[256];
            for (var i = 0; i < 256; i++)
            {
                visited[i] = -1;//初始化所有值为-1,表示未访问
            }
 

            var maxLen = 1;//开始时最大长度为1
            var currentLen = 1;//开始长度为1
           
            visited[s[0]] = 0;//记录第一个元素的索引

            for (var i = 1; i < s.Length; i++)
            {
                int previousIndex = visited[s[i]];
                if (previousIndex == -1 || i - currentLen > previousIndex)//如果未访问或不在当前最长子串中
                {
                    currentLen++;
                }
                else
                {
                    maxLen = currentLen > maxLen ? currentLen : maxLen; 
                    currentLen = i - previousIndex;//更新当前长度
                }
                visited[s[i]] = i;//更新最后一次访问的字符的索引
            }
            maxLen = currentLen > maxLen ? currentLen : maxLen; 
            return maxLen;
        }