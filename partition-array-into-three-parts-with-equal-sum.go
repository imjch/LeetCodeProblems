package main

import "fmt"

var accRecord []int

func canThreePartsEqualSum(arr []int) bool {
	accRecord = make([]int, len(arr))
	accRecord[0] = arr[0]
	for i := 1; i < len(arr); i++ {
		accRecord[i] = arr[i] + accRecord[i-1]
	}
	for i := 0; i < len(arr)-2; i++ {
		for j := i + 2; j < len(arr); j++ {
			if equal(arr, i, j) {
				return true
			}
		}
	}
	return false
}

// 0..i | i+1..j-1 | j..n
func equal(arr []int, i int, j int) bool {
	sum1 := accRecord[i]
	sum3 := accRecord[len(arr)-1] - accRecord[j-1]
	sum2 := accRecord[j-1] - accRecord[i]

	return sum1 == sum2 && sum2 == sum3
}

func main() {
	fmt.Print(canThreePartsEqualSum([]int{0, 2, 1, -6, 6, -7, 9, 1, 2, 0, 1}))
}
