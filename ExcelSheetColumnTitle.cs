    Given a positive integer, return its corresponding column title as appear in an Excel sheet.

For example:

    1 -> A
    2 -> B
    3 -> C
    ...
    26 -> Z
    27 -> AA
    28 -> AB 

    public class Solution
    {
        public string ConvertToTitle(int n)
        {
            var dict = new Dictionary<int, char>()
            {
                { 1, 'A' }, { 2, 'B' }, { 3, 'C' }, { 4, 'D' }, { 5, 'E' }, { 6, 'F' }, { 7, 'G' }, { 8, 'H' }, { 9, 'I' }, { 10, 'J' } ,
               {11,'K'},{12,'L'},{13,'M'},{14,'N'},{15,'O'},{16,'P'},{17,'Q'},{18,'R'},{19,'S'},{20,'T'},{21,'U'},{22,'V'},{23,'W'},{24,'X'},{25,'Y'},{26,'Z'}
            };
            var sb = new StringBuilder();
            while (n>26)
            {
                var remain = n%26;
                if (remain == 0)
                {
                    sb.Append('Z');
                    n -= 26;
                }
                else
                {
                    sb.Append(dict[remain]);
                    n -= remain;
                }
                n /= 26;
            }
            sb.Append(dict[n]);
            var chArr = sb.ToString().ToCharArray();
            Array.Reverse(chArr);
            return new string(chArr);
        }
    }