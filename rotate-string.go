package main

func rotateString(s string, goal string) bool {
	for idx, item := range s {
		if item != rune(goal[0]) {
			continue
		}
		if (s[idx:] + s[0:idx]) == goal {
			return true
		}
	}
	return false
}
