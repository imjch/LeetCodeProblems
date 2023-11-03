package main

import "fmt"

func binaryGap(n int) int {
	preIdx := 0
	maxDis := 0
	curIdx := 1

	for n > 0 {
		v := n & 1
		if v == 1 {
			if curIdx-preIdx > maxDis && preIdx != 0 {
				maxDis = curIdx - preIdx
			}
			preIdx = curIdx
		}
		curIdx++
		n >>= 1
	}
	return maxDis
}

func main() {
	fmt.Print(binaryGap(15))
}
