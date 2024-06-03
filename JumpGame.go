package main

import "fmt"

func canJump(nums []int) bool {
	curPos := nums[0]
	for curPos < len(nums) && curPos != (len(nums)-1) {
		if nums[curPos] == 0 {
			break
		} else {
			curPos += nums[curPos]
		}
	}
	return curPos == (len(nums) - 1)
}

func main() {
	fmt.Printf("JCJC %+v", canJump([]int{2, 3, 1, 1, 4}))
}
