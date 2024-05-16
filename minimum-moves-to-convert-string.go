package main

import (
	"fmt"
)

func minimumMoves(s string) int {
	cnt := 0
	i := 0
	for i < len(s) {
		if s[i] == 'X' {
			i += 3
			cnt++
		} else {
			i++
		}
	}
	return cnt
}

func main() {
	fmt.Println(minimumMoves("OOXXX"))
}
