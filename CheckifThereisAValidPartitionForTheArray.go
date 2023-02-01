/*
2369. Check if There is a Valid Partition For The Array

You are given a 0-indexed integer array nums. You have to partition the array into one or more contiguous subarrays.

We call a partition of the array valid if each of the obtained subarrays satisfies one of the following conditions:

The subarray consists of exactly 2 equal elements. For example, the subarray [2,2] is good.
The subarray consists of exactly 3 equal elements. For example, the subarray [4,4,4] is good.
The subarray consists of exactly 3 consecutive increasing elements, that is, the difference between adjacent elements is 1. For example, the subarray [3,4,5] is good, but the subarray [1,3,5] is not.
Return true if the array has at least one valid partition. Otherwise, return false.

Example 1:

Input: nums = [4,4,4,5,6]
Output: true
Explanation: The array can be partitioned into the subarrays [4,4] and [4,5,6].
This partition is valid, so we return true.
Example 2:

Input: nums = [1,1,1,2]
Output: false
Explanation: There is no valid partition for this array.

Constraints:

2 <= nums.length <= 10^5
1 <= nums[i] <= 10^6
*/
package main

import "fmt"

func validPartition(nums []int) bool {
	res := []bool{true, false, nums[0] == nums[1], false}
	l := len(nums)
	for i := 2; i < l; i++ {
		two := nums[i] == nums[i-1]
		three := (two && nums[i-2] == nums[i]) || ((nums[i]-1) == nums[i-1] && (nums[i-1]-1) == nums[i-2])
		res[(i+1)%4] = (two && res[(i-1)%4]) || (three && res[(i-2)%4])
	}
	return res[l%4]
}

func main() {
	fmt.Println(validPartition([]int{1, 1, 1, 2}))
	fmt.Println(validPartition([]int{4, 4, 4, 5, 6}))
	fmt.Println(validPartition([]int{993335, 993336, 993337, 993338, 993339, 993340, 993341}))
}
