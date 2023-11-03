package main

import "fmt"

func countSegments(s string) int {
	headIdx := -1
	for i, item := range s {
		if item != ' ' {
			headIdx = i
			break
		}
	}
	if headIdx == -1 {
		return 0
	}

	tailIdx := -1
	for i := len(s) - 1; i >= 0; i-- {
		if s[i] != ' ' {
			tailIdx = i
			break
		}
	}
	if tailIdx == -1 {
		return 0
	}

	cnt := 0
	for i := headIdx; i < tailIdx; i++ {
		if s[i] == ' ' {
			for ; i < tailIdx; i++ {
				if s[i+1] != ' ' {
					break
				}
			}
			cnt++
		}
	}
	return cnt + 1
}

func main() {
	fmt.Print(countSegments("Hello, my name is John"))
}
