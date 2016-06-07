Given two integers representing the numerator and denominator of a fraction, return the fraction in string format.

If the fractional part is repeating, enclose the repeating part in parentheses.

For example,

Given numerator = 1, denominator = 2, return "0.5".
Given numerator = 2, denominator = 1, return "2".
Given numerator = 2, denominator = 3, return "0.(6)".
Hint:

No scary math, just apply elementary math knowledge. Still remember how to perform a long division?
Try a long division on 4/9, the repeating part is obvious. Now try 4/333. Do you see a pattern?
Be wary of edge cases! List out as many test cases as you can think of and test your code thoroughly.




    public class Solution
    {
        public string FractionToDecimal(int numerator, int denominator)
        {
            long num = Math.Abs((long)numerator);
            long denomi =Math.Abs((long)denominator);
            if (denomi == 1 || denomi == -1)
            {
                return Math.Sign((long)numerator * (long)denominator) > 0 ? (num / denomi).ToString() : "-"+(num / denomi).ToString();
            }
            if (num == 0)
            {
                return "0";
            }

            var executeOnce = false;
            var sb = new StringBuilder();
            var hashTable = new Dictionary<long,int>();
            int index = 1;
            while (num != 0)
            {
                var quotient = num / denomi;
                if (executeOnce)
                {
                     hashTable.Add(num,index++);
                }
                sb.Append(quotient);
                if (num % denomi != 0)
                {
                    if (!executeOnce)
                    {
                        sb.Append('.');
                        executeOnce = true;
                    }
                    num %= denomi;
                    num *= 10;
                }
                else
                {
                    num %= denomi;
                }
                if (hashTable.ContainsKey(num))
                {
                    sb.Insert(sb.ToString().IndexOf('.') + hashTable[num], '(').Append(')');
                    break;
                }
            }
          
            return Math.Sign((long)numerator * (long)denominator) > 0 ? sb.ToString() : "-" + sb.ToString();

        }
    }
