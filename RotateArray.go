package main

import "fmt"

func rotate(nums []int, k int) {
	reverse(nums[0:k])
	reverse(nums[k:len(nums)])
	reverse(nums)
}

func reverse(nums []int) {
	i, j := 0, len(nums)-1
	for i < j {
		t := nums[j]
		nums[j] = nums[i]
		nums[i] = t
		i++
		j--
	}
}

func main() {
	nums := []int{1, 2, 3, 4, 5, 6, 7}
	rotate(nums, 3)
	fmt.Print(nums)
}
