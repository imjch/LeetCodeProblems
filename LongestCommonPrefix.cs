  public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length==0)
            {
                return "";
            }
            var minLengthStr=strs[0];
            for (var i = 1; i < strs.Length; i++)
            {
                if (minLengthStr.Length>strs[i].Length)
                {
                    minLengthStr = strs[i];
                }
            }
            var longestCommonPrefix = new StringBuilder(minLengthStr.Length);
            for (var i = 0; i < minLengthStr.Length; i++)
            {
                if (strs.All(s => s[i] == minLengthStr[i]))
                {
                    longestCommonPrefix.Append(minLengthStr[i]);
                }
                else
                {
                    break;
                }
            }
            return longestCommonPrefix.ToString();
        }