package main

import "fmt"

func isSubsequence(s string, t string) bool {
	if s == "" {
		return true
	}
	if t == "" {
		return false
	}
	idx := 0
	for _, v := range t {
		if idx < len(s) && v == rune(s[idx]) {
			idx++
			continue
		}
	}
	return idx == len(s)
}

func main() {
	fmt.Print(isSubsequence("b", "abc"))
}
