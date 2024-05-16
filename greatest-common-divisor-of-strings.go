package main

import "fmt"

func canDivide(src string, word string) bool {
	newW := word
	n := len(src) / len(word)
	for n-1 > 0 {
		newW += word
		n--
	}
	return src == newW
}

func gcdOfStrings(str1 string, str2 string) string {
	i := len(str2)
	for i >= 1 {
		gcd := string(str2[0:i])
		if canDivide(str1, gcd) && canDivide(str2, gcd) {
			return gcd
		}
		i--
	}
	return ""
}

func main() {
	fmt.Println(gcdOfStrings("ABABABAB", "ABAB"))
}
