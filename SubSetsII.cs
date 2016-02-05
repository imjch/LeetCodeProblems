public class Solution {
   public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            Array.Sort(nums);
            var globalList = new List<IList<int>> {new List<int>()};
            for (var i = 0; i < nums.Length; )
            {
                var count = 0;
                while (count + i < nums.Length&&nums[i] == nums[i + count])
                {
                    ++count;
                }
                var len = globalList.Count;
                for (var j = 0; j < len; j++)
                {
                    var list = globalList[j].ToList();
                    for (var k = 0; k < count; k++)
                    {
                        list.Add(nums[i]);
                        globalList.Add(list.ToList());
                    }
                }
                i += count;
            }
            return globalList;
        }
}
