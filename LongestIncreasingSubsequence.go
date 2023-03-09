/*
300. Longest Increasing Subsequence

Given an integer array nums, return the length of the longest strictly increasing
subsequence
.

Example 1:

Input: nums = [10,9,2,5,3,7,101,18]
Output: 4
Explanation: The longest increasing subsequence is [2,3,7,101], therefore the length is 4.
Example 2:

Input: nums = [0,1,0,3,2,3]
Output: 4
Example 3:

Input: nums = [7,7,7,7,7,7,7]
Output: 1

Constraints:

1 <= nums.length <= 2500
-10^4 <= nums[i] <= 10^4

Follow up: Can you come up with an algorithm that runs in O(n log(n)) time complexity?
*/
package main

import "fmt"

func lengthOfLIS(nums []int) int {
	res := make([]int, len(nums))
	// the first value of nums is 1
	res[0] = 1
	resMax := 1
	for i := 1; i < len(nums); i++ {
		maxLen := res[0]
		for j := 0; j < i; j++ {
			if nums[i] > nums[j] && res[j] >= maxLen {
				maxLen = res[j] + 1
			}
		}
		if maxLen > resMax {
			resMax = maxLen
		}
		res[i] = maxLen
	}
	return resMax
}

func main() {
	fmt.Println(lengthOfLIS([]int{7, 7, 7, 7, 7, 7, 7}))
	fmt.Println(lengthOfLIS([]int{0, 1, 0, 3, 2, 3}))
	fmt.Println(lengthOfLIS([]int{10, 9, 2, 5, 3, 7, 101, 18}))
}
