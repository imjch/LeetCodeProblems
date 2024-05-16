package main

import (
	"fmt"
	"sort"
)

func threeSum(nums []int) [][]int {
	n := len(nums)
	sort.Slice(nums, func(i, j int) bool { return nums[i] < nums[j] })
	res := [][]int{}
	for i := 0; i < n-2; i++ {
		j := i + 1
		k := n - 1

		if i > 0 && nums[i] == nums[i-1] {
			continue
		}

		for j < k {
			sum := nums[j] + nums[k] + nums[i]
			if sum == 0 {
				res = append(res, []int{nums[i], nums[j], nums[k]})
				j++
				for j < k && nums[j] == nums[j-1] {
					j++
					continue
				}
			} else if 0 > sum {
				j++
			} else {
				k--
			}
		}
	}
	return res
}

func main() {
	fmt.Print(threeSum([]int{-1, 0, 1, 2, -1, -4}))
}
