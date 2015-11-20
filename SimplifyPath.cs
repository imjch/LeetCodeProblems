public class Solution {
 public string SimplifyPath(string path)
 {
             var pathList = path.Split('/');
             var stack = new Stack<string>(path.Length);
             foreach (var item in pathList)
             {
                 switch (item)
                 {
                     case "..":
                         if (stack.Count <= 0)
                             break;
                         stack.Pop();
                         break;
                     case ".":
                     case "":
                         continue;
                     default:
                         stack.Push(item);
                         break;
                 }
             }
             var sb = new StringBuilder();
             sb.Append('/');
             sb.Append(string.Join("/",stack.ToArray().Reverse()));
             return sb.ToString();
         }
}