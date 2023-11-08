package main

import (
	"fmt"
)

func numDifferentIntegers(word string) int {
	word = word + " "
	preWord := []rune{}
	record := map[string]bool{}
	for _, item := range word {
		if item >= '0' && item <= '9' {
			preWord = append(preWord, item)
		} else if len(preWord) > 0 {
			j := 0
			for j < len(preWord) && preWord[j] == '0' {
				j++
			}
			if j >= len(preWord) {
				record["0"] = true
			} else {
				record[string(preWord[j:])] = true
			}
			preWord = []rune{}
		}
	}
	return len(record)
}

func main() {
	fmt.Println(numDifferentIntegers("a1b01c001"))
}
