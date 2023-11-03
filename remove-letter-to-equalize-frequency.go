package main

func equalFrequency(word string) bool {
	for i, _ := range word {
		if sameCnt(word[0:i] + word[i+1:]) {
			return true
		}
	}
	return false
}

func sameCnt(word string) bool {
	m := map[rune]int{}
	for _, item := range word {
		if _, ok := m[item]; !ok {
			m[item] = 1
		} else {
			m[item]++
		}
	}
	preCnt := -1
	for _, cnt := range m {
		if preCnt == -1 {
			preCnt = cnt
		}
		if preCnt != cnt {
			return false
		}
	}
	return true
}
