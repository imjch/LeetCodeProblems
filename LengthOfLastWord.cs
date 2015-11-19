public class Solution {
    public int LengthOfLastWord(string s) {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }
             var strs = s.TrimEnd().Split(' ');
            return strs[strs.Length - 1].Length;
    }
}
