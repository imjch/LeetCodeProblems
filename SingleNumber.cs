public class Solution {
    public int SingleNumber(int[] nums) {
          return nums.Aggregate((x, y) => x ^ y);
    }
}