class Solution {
    public int[] twoSum(int[] numbers, int target) {
        int start = 0, end = numbers.length - 1;
        while (start < end) {
            int startVal = numbers[start];
            int endVal = numbers[end];
            int curVal = startVal + endVal;
            if (curVal == target) {
                return new int[] {start + 1, end + 1};
            }
            else if(curVal > target) {
                end--;
            } else {
                start++;
            }
        }
        return new int[]{};
    }
}
