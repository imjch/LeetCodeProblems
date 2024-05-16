package main

import "fmt"

func removeDuplicates(nums []int) int {
	if len(nums) == 1 {
		return 1
	}
	i, j := 0, 1
	cnt := 1
	for j < len(nums) {
		if nums[j] == nums[i] {
			if cnt < 2 {
				cnt++
				i++
				nums[i] = nums[j]
			}
		} else {
			cnt = 1
			i++
			nums[i] = nums[j]
		}
		j++

		fmt.Println(nums)
	}
	return i + 1
}

func main() {
	fmt.Print(removeDuplicates([]int{0, 0, 1, 1, 1, 1, 2, 3, 3}))
}
