package main

import "fmt"

func containsPattern(arr []int, m int, k int) bool {
	for i := 0; i < len(arr)-m+1; i++ {
		matchCnt := 1
		srcArr := arr[i : i+m]
		for j := i + m; j < len(arr)-m+1; j += m {
			dstArr := arr[j : j+m]
			if arrEqual(srcArr, dstArr) {
				matchCnt++
			} else {
				break
			}
		}
		if matchCnt == k {
			return true
		}
	}
	return false
}

func arrEqual(src []int, dst []int) bool {
	for i := 0; i < len(src); i++ {
		if src[i] != dst[i] {
			return false
		}
	}
	return true
}

func main() {
	fmt.Print(containsPattern([]int{1, 2, 1, 2, 1, 2, 3}, 2, 3))
}
