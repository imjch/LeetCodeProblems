  

    public class Solution
    {
                public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Array.Sort(strs);
            var dict = new Dictionary<string, List<string>>();
            foreach (string t in strs)
            {
                var cArr = t.ToCharArray();
                Array.Sort(cArr);
                var str = new string(cArr);
                if (dict.ContainsKey(str))
                {
                    dict[str].Add(t);
                }
                else
                {
                   // var linkList = new List<string>(1000) { t };
                    dict.Add(str, new List<string>() { t});
                }
            }

            return new List<IList<string>>(dict.Values);
        }
    }
