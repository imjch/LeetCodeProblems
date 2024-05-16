package main

import "fmt"

func secondHighest(s string) int {
	var fst rune = -1
	var snd rune = -1
	for _, item := range s {
		if item >= '0' && item <= '9' {
			if item > fst {
				snd = fst
				fst = item
			} else if item > snd && item != fst {
				snd = item
			}
		}
	}
	if snd == -1 {
		return -1
	}
	return int(snd - '0')
}

func main() {
	fmt.Println(secondHighest("ck077"))
}
