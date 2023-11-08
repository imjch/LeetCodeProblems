package main

import "fmt"

func reverseStr(s string, k int) string {
	sl := []rune(s)
	i := 0
	for i < len(sl) {
		start := i
		end := i + k - 1
		if end >= len(sl) {
			end = len(sl) - 1
		}
		for start < end {
			t := sl[start]
			sl[start] = sl[end]
			sl[end] = t
			start++
			end--
		}
		i += 2 * k
	}
	return string(sl)
}

func main() {
	fmt.Println(reverseStr("abcdefg", 8))
}
