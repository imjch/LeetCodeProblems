package main

func areAlmostEqual(s1 string, s2 string) bool {
	if len(s1) != len(s2) {
		return false
	}
	if s1 == s2 {
		return true
	}

	diff := []int{}
	for i := 0; i < len(s1); i++ {
		if s1[i] != s2[i] {
			diff = append(diff, i)
		}
	}
	if len(diff) != 2 {
		return false
	}
	i := diff[0]
	j := diff[1]
	return s1[i] == s2[j] && s1[j] == s2[i]
}
