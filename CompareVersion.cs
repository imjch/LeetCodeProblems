public class Solution {
    public int CompareVersion(string version1, string version2) {
             var versionList1 = version1.Split('.');
             var versionList2 = version2.Split('.');
             var len = Math.Max(versionList1.Length, versionList2.Length);
             for (var i = 0; i < len; i++)
             {
                 var val1 = i < versionList1.Length ? Convert.ToInt32(versionList1[i]) : 0;
                 var val2 = i < versionList2.Length ? Convert.ToInt32(versionList2[i]) : 0;

                 if (val1>val2)
                 {
                     return 1;
                 }
                 if(val1<val2)
                 {
                     return -1;
                 }
             }
             return 0;
    }
}
