package main

import (
	"fmt"
)

func addToArrayForm(num []int, k int) []int {
	kNum := []int{}
	for k > 0 {
		v := k % 10
		kNum = append([]int{v}, kNum...)
		k /= 10
	}

	if len(num) < len(kNum) {
		t := kNum
		kNum = num
		num = t
	}
	add := false
	for i := len(num) - 1; i >= 0; i-- {
		sum := num[i]
		kNumIdx := i - len(num) + len(kNum)
		if kNumIdx >= 0 && kNumIdx < len(kNum) {
			sum += kNum[kNumIdx]
		}
		if add {
			sum += 1
			add = false
		}
		if sum >= 10 {
			add = true
			sum = sum % 10
		}
		num[i] = sum
	}
	if add {
		num = append([]int{1}, num...)
	}
	return num
}

func main() {
	fmt.Println(addToArrayForm([]int{1, 2, 6, 3, 0, 7, 1, 7, 1, 9, 7, 5, 6, 6, 4, 4, 0, 0, 6, 3}, 516))
}
