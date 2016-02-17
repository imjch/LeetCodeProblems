public class Solution
    {
        List<string> ipList = new List<string>();
        public IList<string> RestoreIpAddresses(string s)
        {
            if (!string.IsNullOrEmpty(s) && s.Length > 3&&s.Length<=12)
            {
                RestoreIpAddresses(s, 0, 1, "");
            }
            return ipList;
        }
        public void RestoreIpAddresses(string s, int begin, int depth, string srcStr)
        {
            if (begin >= s.Length) return;
            if (depth == 4)
            {
                var remainStr = s.Substring(begin);
                if (IsValid(remainStr))
                {
                    ipList.Add(srcStr + "." + s.Substring(begin));
                }
                return;
            }
            var list = ConstructValidIP(s, begin);
            foreach (var t in list)
            {
                var len = srcStr.Count(Char.IsDigit) + t.Length;
                RestoreIpAddresses(s, len, depth + 1, string.IsNullOrEmpty(srcStr)?t:srcStr + "." + t);
            }
        }
        public bool IsValid(string s)
        {
            return  s.Length != 0 && (s[0] != '0' || s.Length <= 1) && Convert.ToInt64(s) <= 255;
        }

        public List<string> ConstructValidIP(string s,int begin)
        {
            var list = new List<string>();
            var sb = new StringBuilder(3);
    
            while (sb.Length <= 3 && begin < s.Length)
            {
                sb.Append(s[begin++]);
                if (!IsValid(sb.ToString()))
                {
                    break;
                }
                else
                {
                    list.Add(sb.ToString());
                }              
            }
            return list;
        }
    }
