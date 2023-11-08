package main

import (
	"fmt"
)

func addStrings(num1 string, num2 string) string {
	i, j := len(num1)-1, len(num2)-1
	sum := ""
	addFlag := false
	for i >= 0 || j >= 0 {

		var s byte = 0
		if i >= 0 {
			s += num1[i] - '0'
		}
		if j >= 0 {
			s += num2[j] - '0'
		}
		if addFlag {
			s += 1
			addFlag = false
		}
		if s >= 10 {
			addFlag = true
			s -= 10
		}
		sum = string(s+'0') + sum
		i--
		j--
	}
	if addFlag {
		sum = "1" + sum
	}
	return sum
}

func main() {
	fmt.Println(addStrings("3", "7"))
}
