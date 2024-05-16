package main

import "fmt"

func removeElement(nums []int, val int) int {
	i, j := 0, 0
	for j < len(nums) {
		if nums[j] == val {
			j++
		} else {
			swap(nums, i, j)
			i++
			j++
		}
	}
	return i
}

func swap(arr []int, i int, j int) {
	t := arr[i]
	arr[i] = arr[j]
	arr[j] = t
}

func main() {
	fmt.Print(removeElement([]int{0, 0, 1, 1, 1, 2, 2, 3, 3, 4}, 2))
}
