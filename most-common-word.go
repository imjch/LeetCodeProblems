package main

import (
	"fmt"
	"strings"
)

func mostCommonWord(paragraph string, banned []string) string {
	m := map[string]bool{}
	for _, item := range banned {
		m[item] = true
	}

	word := []rune{}
	record := map[string]int{}

	for _, item := range strings.ToLower(paragraph) + " " {
		if item >= 'a' && item <= 'z' {
			word = append(word, item)
		} else if len(word) > 0 {
			if _, ok := m[string(word)]; !ok {
				if _, ok := record[string(word)]; !ok {
					record[string(word)] = 1
				} else {
					record[string(word)]++
				}
			}
			word = []rune{}
		}
	}
	maxStr := ""
	maxCnt := 0
	for k, cnt := range record {
		if cnt > maxCnt {
			maxStr = k
			maxCnt = cnt
		}
	}
	return maxStr
}

func main() {
	fmt.Println(mostCommonWord("Bob hit a ball, the hit BALL flew far after it was hit.", []string{"hit"}))
	fmt.Println(mostCommonWord("Bob", []string{""}))
}
