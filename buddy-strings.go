package main

import "fmt"

func buddyStrings(s string, goal string) bool {
	if len(s) != len(goal) || len(s) < 2 {
		return false
	}
	if s == goal {
		// 如果存在2或多个字母相等，则表示相等
		m := map[rune]bool{}
		for _, item := range s {
			m[item] = true
		}
		return len(m) < len(s)
	}

	diff := []int{}
	for i := 0; i < len(s); i++ {
		if s[i] != goal[i] {
			diff = append(diff, i)
		}
	}
	if len(diff) != 2 {
		return false
	}
	i := diff[0]
	j := diff[1]
	return s[i] == goal[j] && goal[i] == s[j]
}

func main() {
	fmt.Println(buddyStrings("abcd", "badc"))
}
