    public class Solution
    {
        public string CountAndSay(int n)
        {
            var sb = new StringBuilder();
            sb.Append('1');
            var newSB = new StringBuilder();
            if (n==1)
            {
                return sb.ToString();
            }
            for (var i = 1; i < n; i++)
            {
                var count = 1;
                var ch = sb[0];
                var same = sb[0];
                for (var j = 1; j < sb.Length; j++)
                {
                    if (sb[j]==ch)
                    {
                        count++;
                    }
                    else
                    {
                        newSB.Append(""+count + same);
                        count = 1;
                        ch = same = sb[j];
                    }
                }
                newSB.Append("" + count + same);
                sb=newSB;
                newSB=new StringBuilder();
            }
            return sb.ToString();
        }
    }
