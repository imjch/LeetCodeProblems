/*
Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].

The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.

You must write an algorithm that runs in O(n) time and without using the division operation.



Example 1:

Input: nums = [1,2,3,4]
Output: [24,12,8,6]
Example 2:

Input: nums = [-1,1,0,-3,3]
Output: [0,0,9,0,0]


Constraints:

2 <= nums.length <= 105
-30 <= nums[i] <= 30
The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.


Follow up: Can you solve the problem in O(1) extra space complexity? (The output array does not count as extra space for space complexity analysis.)
*/

package main

import "fmt"

func productExceptSelf(nums []int) []int {
	preNums := make([]int, 0, len(nums))
	sufNums := make([]int, len(nums), len(nums))

	for i := 0; i < len(nums); i++ {
		if i == 0 {
			preNums = append(preNums, nums[i])
		} else {
			preNums = append(preNums, nums[i]*preNums[i-1])
		}
	}
	for i := len(nums) - 1; i >= 0; i-- {
		if i == len(nums)-1 {
			sufNums[i] = nums[i]
		} else {
			sufNums[i] = nums[i] * sufNums[i+1]
		}
	}
	res := []int{}
	for i := 0; i < len(nums); i++ {
		if i == 0 {
			res = append(res, sufNums[i+1])
		} else if i == len(nums)-1 {
			res = append(res, preNums[i-1])
		} else {
			res = append(res, preNums[i-1]*sufNums[i+1])
		}
	}
	return res
}

func main() {
	nums := []int{-1, 1}
	fmt.Println(productExceptSelf(nums)) // [24, 12, 8, 6]
}
