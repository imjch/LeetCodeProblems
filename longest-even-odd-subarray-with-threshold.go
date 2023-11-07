package main

import (
	"fmt"
	"math"
)

func longestAlternatingSubarray(nums []int, threshold int) int {
	max := 0
	cnt := 0
	for i := 0; i < len(nums); i++ {
		if i > 0 && (nums[i]%2 != nums[i-1]%2) && int(math.Max(float64(nums[i]), float64(nums[i-1]))) <= threshold {
			cnt++
		} else if nums[i]%2 == 0 && nums[i] <= threshold {
			cnt = 1
		}
		fmt.Println(cnt)
		max = int(math.Max(float64(cnt), float64(max)))
	}
	return max
}

func main() {
	fmt.Println(longestAlternatingSubarray([]int{2, 3, 3, 10}, 18))
}
