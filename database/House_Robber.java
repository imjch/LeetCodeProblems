class Solution {
    public int rob(int[] nums) {
        if (nums==null||nums.length == 0) {
            return 0;
        }
        if (nums.length == 1) {
            return nums[0];
        }
        int[][] arr = new int[nums.length][2];
        arr[0][0] = 0;
        arr[0][1] = nums[0];

        int i = 0;
        for (i = 1; i < nums.length; i++) {
            arr[i][0] = Math.max(arr[i-1][0], arr[i-1][1]);
            arr[i][1] = nums[i] + arr[i-1][0];
        }
        return Math.max(arr[i-1][0], arr[i-1][1]);  
    }
}
