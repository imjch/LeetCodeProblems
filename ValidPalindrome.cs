    public class Solution
    {
        public bool IsPalindrome(string s)
        {
            int i = 0,j=s.Length-1; 
            while (i < j)
            {
                if (!Char.IsLetterOrDigit(s[i]) && !Char.IsLetterOrDigit(s[j]))
                {
                    ++i;
                    --j;
                }
                else if (!Char.IsLetterOrDigit(s[i]))
                {
                    ++i;
                }
                else if (!Char.IsLetterOrDigit(s[j]))
                {
                    --j;
                }
                else
                {
                    if (Char.ToUpper(s[i]) != Char.ToUpper(s[j]))
                    {
                        return false;
                    }
                    ++i;
                    --j;
                }
            }
            return true;
        }
    }
