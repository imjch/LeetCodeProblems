    public class Solution
    {
        public string Multiply(string num1, string num2)
        {
            BigInteger result1 = BigInteger.Parse(num1);
            BigInteger result2 = BigInteger.Parse(num2);
            return (result1*result2).ToString();
        }
    }
