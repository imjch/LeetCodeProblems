package main

import "fmt"

// s1 = "abcd", s2 = "cdab"
func canBeEqual(s1 string, s2 string) bool {
	if len(s1) != len(s2) {
		return false
	}
	return _canBeEqual([]rune(s1), s2, 0)
}

func _canBeEqual(s1 []rune, s2 string, i int) bool {
	if string(s1) == string(s2) {
		return true
	}
	if i+2 >= len(s1) {
		return false
	}
	t := s1[i]
	s1[i] = s1[i+2]
	s1[i+2] = t
	b1 := _canBeEqual(s1, s2, i+1)
	t = s1[i]
	s1[i] = s1[i+2]
	s1[i+2] = t
	if b1 {
		return true
	}
	return _canBeEqual(s1, s2, i+1)
}

func main() {
	fmt.Println(canBeEqual("abcd", "cdab"))
}
