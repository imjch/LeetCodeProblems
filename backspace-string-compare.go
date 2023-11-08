package main

func backspaceCompare(s string, t string) bool {
	i, j := len(s)-1, len(t)-1
	for i >= 0 || j >= 0 {

		bsS := 0
		for i >= 0 {
			if s[i] == '#' {
				bsS++
			} else if bsS > 0 {
				bsS--
			} else {
				break
			}
			i--
		}

		bsT := 0
		for j >= 0 {
			if t[j] == '#' {
				bsT++
			} else if bsT > 0 {
				bsT--
			} else {
				break
			}
			j--
		}

		if i < 0 && j < 0 {
			return true
		}
		if i < 0 || j < 0 || s[i] != t[j] {
			return false
		}
		i--
		j--
	}
	return true
}
