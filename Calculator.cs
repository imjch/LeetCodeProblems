    public class Solution
    {
        public int Calculate(string s)
        {
            var rgx = new Regex(@"\(|\)|\d+|\+|\-");
            MatchCollection matches = rgx.Matches(s);
            var n = 0;
            return Calculate(matches,ref n);
        }

        public int Calculate(MatchCollection s,ref int n)
        {
            var result = 0;
            var lastOP = '+';
            
            for (; n < s.Count; n++)
            {
                var value = s[n].Value;
                var number = 0;
                if (value == "(")
                {
                    ++n;
                    if (lastOP == '+')
                    {
                        result += Calculate(s, ref n);
                    }
                    else
                    {
                        result -= Calculate(s, ref n);
                    }
                   
                }
                else if (value == ")")
                {
                    break;
                }
                else if(int.TryParse(value,out number))
                {
                    if (lastOP=='+')
                    {
                        result += number;
                    }
                    else
                    {
                        result -= number;
                    }

                }
                else if (value == "+")
                {
                    lastOP = '+';
                }
                else//value == "-"
                {
                    lastOP = '-';
                }
            }
            return result;
  
        }
    }