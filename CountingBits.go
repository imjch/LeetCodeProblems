package main

import "fmt"

func countBits(n int) []int {
	res := make([]int, n+1)
	for i := 1; i <= n; i++ {
		cnt := 0
		n := i
		for n > 0 {
			n = n & (n - 1)
			cnt++
		}
		res[i] = cnt
	}
	return res
}

func main() {
	fmt.Print(countBits(2))
}
