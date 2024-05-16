package main

import "strings"

func findTheLongestBalancedSubstring(s string) int {
	if len(s) <= 1 {
		return 0
	}
	str := "01"
	maxCount := 0
	for len(str) <= len(s) {
		if strings.Index(s, str) != -1 {
			maxCount = len(str)
		}
		str = "0" + str + "1"
	}
	return maxCount
}
