public class Solution {
          public string AddBinary(string a, string b)
         {
             var sb = new StringBuilder();
             var carryIndex = 0;
             var aLength = a.Length-1;
             var bLength = b.Length-1;
             while (Math.Max(aLength,bLength)>=0)
             {
                 var sumVal = (aLength >= 0 ? a[aLength] - '0' : 0 )+ (bLength >= 0 ? b[bLength] - '0':0) +carryIndex;
                 carryIndex=sumVal/2;
                 sb.Append(sumVal%2);
                 --aLength;
                 --bLength;
             }
             if (carryIndex == 1)
             {
                 sb.Append('1');
             }
             
             return new string(sb.ToString().Reverse().ToArray());
         
         }
}