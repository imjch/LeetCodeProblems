package main

import "fmt"

func majorityElement(nums []int) int {
	fst := nums[0]
	cnt := 0
	for _, v := range nums {
		if v == fst {
			cnt++
		} else {
			cnt--
			if cnt == 0 {
				fst = v
				cnt = 1
			}
		}
	}
	return fst
}

func main() {
	fmt.Print(majorityElement([]int{1, 2, 1, 1, 1, 2, 2}))
}
