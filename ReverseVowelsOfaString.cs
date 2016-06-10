Write a function that takes a string as input and reverse only the vowels of a string.

Example 1:
Given s = "hello", return "holle".

Example 2:
Given s = "leetcode", return "leotcede".

public class Solution {
        public string ReverseVowels(string s)
        {
                var set = new HashSet<char>() {'a', 'e', 'i', 'o', 'u','A','E','I','O','U'};
                int i = 0, j = s.Length - 1;
                var sb = new StringBuilder(s);
                while (i < j)
                {
                    while (i < j && !set.Contains(s[i]))
                    {
                        i++;
                    }
                    while (i < j && !set.Contains(s[j]))
                    {
                        j--;
                    }
                    if (i<j)
                    {
                        var t = sb[j];
                        sb[j] = sb[i];
                        sb[i] = t;
                    }
                    i++;
                    --j;
                }
                return sb.ToString();
            }
}