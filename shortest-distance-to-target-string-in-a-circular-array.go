package main

import "fmt"

func closetTarget(words []string, target string, startIndex int) int {
	minStep := 1000
	n := len(words)
	for i, item := range words {
		if item != target {
			continue
		}
		if i < startIndex {
			stepLeft := startIndex - i
			stepRight := n - startIndex + i
			if stepLeft < minStep {
				minStep = stepLeft
			}
			if stepRight < minStep {
				minStep = stepRight
			}
		} else {
			stepLeft := startIndex + n - i
			stepRight := i - startIndex
			if stepLeft < minStep {
				minStep = stepLeft
			}
			if stepRight < minStep {
				minStep = stepRight
			}
		}
	}
	if minStep == 1000 {
		return -1
	}
	return minStep
}

func main() {
	fmt.Println(closetTarget([]string{"hsdqinnoha", "mqhskgeqzr", "zemkwvqrww", "zemkwvqrww", "daljcrktje", "fghofclnwp", "djwdworyka", "cxfpybanhd", "fghofclnwp", "fghofclnwp"}, "zemkwvqrww", 8))
}
