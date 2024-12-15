func longestConsecutive(nums []int) int {
	m := map[int]struct{}{}
	for _, c := range nums {
		m[c] = struct{}{}
	}
	res := 0
	for _, c := range nums {
		if _, ok := m[c-1]; !ok {
			cnt := 1
			next := c + 1
			_, ok = m[next]
			for ok {
				cnt++
				next++
				_, ok = m[next]
			}
			if cnt > res {
				res = cnt
			}
		}
	}
	return res
}