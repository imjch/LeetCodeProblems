        static int IndexOf(string s, char target)
        {
            if (string.IsNullOrEmpty(s))
            {
                return -1;
            }
            int begin = 0;
            int end = s.Length - 1;
           
            if (s[begin] == target) return begin;
            if (s[end] == target) return end;
           
            while (begin<=end)
            {
                int mid = (begin + end) / 2;
                if (s[mid]==target)
                {
                    return mid;
                }
                if (s[begin]==target)
                {
                    return begin;
                }
                if (s[end]==target)
                {
                    return end;
                }
                if (s[mid] < s[end])
                {
                    if (target > s[mid] && target < s[end])
                    {
                        begin = mid + 1;
                        end -= 1;
                    }
                    else
                    {
                        end = mid - 1;
                        begin += 1;
                    }
                }
                else
                {
                    if (target>s[begin]&&target<s[mid])
                    {
                        end = mid - 1;
                        begin += 1;
                    }
                    else
                    {
                        begin = mid + 1;
                        end -= 1;
                    }
                }
            }
            return -1;
        }