public class Solution {
  private int first=int.MaxValue, last=int.MinValue;
    public int[] SearchRange(int[] nums, int target)
    {
         BinarySearch(nums,0,nums.Length,target);
         return new int[] { first == int.MaxValue ? -1 : first, last == int.MinValue ? -1 : last };
    }
    
    public void BinarySearch(int[] nums,int start,int end, int target)
    {
        if (start>end)
        {
            return;
        }
        var index = Array.BinarySearch(nums, start, end - start, target);
        if (index<0)
        {
            return;
        }
        if (first > index) first = index;
        if (last  < index) last = index;
        BinarySearch(nums, start, index, target);
         BinarySearch(nums, index+1, end, target);
    }
}