package main

import "fmt"

func removeDuplicates(nums []int) int {
	if len(nums) == 1 {
		return 1
	}
	i, j := 0, 1
	for j < len(nums) {
		if nums[j] == nums[i] {
			j++
		} else {
			i++
			swap(nums, i, j)
			j++
		}
	}
	return i + 1
}

func swap(arr []int, i int, j int) {
	t := arr[i]
	arr[i] = arr[j]
	arr[j] = t
}

func main() {
	fmt.Print(removeDuplicates([]int{0, 0, 1, 1, 1, 2, 2, 3, 3, 4}))
}
