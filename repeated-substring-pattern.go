package main

import "fmt"

func repeatedSubstringPattern(s string) bool {
	i := len(s) / 2
	for i > 0 {
		if isRSub(s[0:i], s) && len(s)%(i) == 0 {
			return true
		}
		i--
	}
	return false
}

func isRSub(subStr string, goal string) bool {
	newStr := subStr
	for len(newStr) <= len(goal) {
		if newStr == goal {
			return true
		}
		newStr += subStr
	}
	return false
}

func main() {
	fmt.Println(repeatedSubstringPattern("aaa"))
}
