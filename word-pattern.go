package main

import "strings"

func wordPattern(pattern string, s string) bool {
	sL := strings.Split(s, " ")
	if len(sL) != len(pattern) {
		return false
	}
	record1 := map[rune]string{}
	record2 := map[string]rune{}
	for i := 0; i < len(sL); i++ {
		_, ok1 := record1[rune(pattern[i])]
		_, ok2 := record2[sL[i]]
		if !ok1 && !ok2 {
			record1[rune(pattern[i])] = sL[i]
			record2[sL[i]] = rune(pattern[i])
		} else if ok1 && ok2 && record2[sL[i]] == rune(pattern[i]) && record1[rune(pattern[i])] == sL[i] {
			continue
		} else {
			return false
		}
	}
	return true
}
