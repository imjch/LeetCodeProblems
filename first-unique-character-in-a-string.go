package main

func firstUniqChar(s string) int {
	m := map[rune][]int{}
	for i, c := range s {
		if _, ok := m[c]; !ok {
			m[c] = []int{i, 1}
		} else {
			m[c][1]++
		}
	}
	minIdx := 1000000
	for _, item := range m {
		// 找到第一个仅出现一次的元素，并返回其第一次出现的位置
		if item[1] == 1 && item[0] < minIdx {
			minIdx = item[0]
		}
	}
	if minIdx == 1000000 {
		return -1
	}
	return minIdx
}
