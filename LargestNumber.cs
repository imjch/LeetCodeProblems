    Given a list of non negative integers, arrange them such that they form the largest number.

For example, given [3, 30, 34, 5, 9], the largest formed number is 9534330.

Note: The result may be very large, so you need to return a string instead of an integer.

    public class Solution
    {
        public string LargestNumber(int[] nums)
        {
            if (nums.Length==0||nums==null)
            {
                return "";
            }
            var arr = nums.Select(x => x.ToString()).ToArray();
            Array.Sort(arr, (x, y) => string.CompareOrdinal(y + x, x + y));
            return arr.First()=="0" ? "0" : arr.Aggregate("",(x,y)=>x+y);
        }
    }