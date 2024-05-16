package main

import "fmt"

func minSubArrayLen(target int, nums []int) int {
	i, j := 0, 0
	sum := nums[0]
	minCnt := 10000000
	for j < len(nums) {
		if sum >= target {
			if j-i+1 <= minCnt {
				minCnt = j - i + 1
			}
			sum -= nums[i]
			i++
		} else if sum < target {
			j++
			if j < len(nums) {
				sum += nums[j]
			}
		}
	}
	if minCnt == 10000000 {
		return 0
	}
	return minCnt
}

func main() {
	fmt.Print(minSubArrayLen(11, []int{1, 1, 1, 1, 1, 1, 1, 1}))
}
