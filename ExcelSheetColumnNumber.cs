Related to question Excel Sheet Column Title

Given a column title as appear in an Excel sheet, return its corresponding column number.

For example:

    A -> 1
    B -> 2
    C -> 3
    ...
    Z -> 26
    AA -> 27
    AB -> 28 


    public class Solution
    {
        public int TitleToNumber(string s)
        {
            var arr = s.ToCharArray();
            var result = 0;
            for (int i = s.Length-1,j=0; i >= 0; i--,j++)
            {
                var radix = j == 0 ? 1 : (int)Math.Pow(26,j);
                result += radix * ((int)s[i]-'0'-16);
            }
            return result;
        }
    }