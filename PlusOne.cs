public class Solution {
         public int[] PlusOne(int[] digits)
         {
             var length = digits.Length;
             digits[length - 1] += 1;
             for (var i = length-1; i >=1; i--)
             {
                 if (digits[i] > 9)
                 {
                     digits[i - 1] += 1;
                     digits[i] -= 10;
                 }
                 else
                 {
                     break;
                 }
             }
             ;
             if (digits[0]>9)
             {
                 var newDigits = new int[length + 1];
                 newDigits[0] = 1;
                 digits[0] -= 10;
                 Array.ConstrainedCopy(digits, 0, newDigits, 1, digits.Length);
                 return newDigits;
             }
             return digits;
         }
}
