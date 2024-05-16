package main

import "fmt"

func findErrorNums(nums []int) []int {
	m := map[int][]int{}
	stopV := 0
	for i, v := range nums {
		if _, ok := m[v]; !ok {
			m[v] = []int{i}
		} else {
			m[v] = append(m[v], i)
			stopV = v
			break
		}
	}
	if stopV == 0 {
		return []int{}
	}
	res := []int{
		m[stopV][0] + 1,
		m[stopV][1] + 1,
	}
	return res
}

func main() {
	fmt.Print(findErrorNums([]int{1, 2}))
}
