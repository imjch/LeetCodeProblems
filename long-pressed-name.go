package main

import "fmt"

// type Meta struct {
// 	Letter rune
// 	Count  int
// }

// func uniqNameMap(str string) []Meta {
// 	res := []Meta{}
// 	i := 0
// 	str += " "
// 	for j := i + 1; j < len(str); j++ {
// 		if str[i] != str[j] {
// 			res = append(res, Meta{
// 				Letter: rune(str[i]),
// 				Count:  j - i,
// 			})
// 			i = j
// 		}
// 	}
// 	return res
// }

func isLongPressedName(name string, typed string) bool {
	// if len(name) > len(typed) {
	// 	return false
	// }
	// 对每个内容进行去重，并记录每个字母出现的次数
	// 顺序比对两个内容，若name中字符的出现次数小于等于typed中的同字符出现次数，则成立，否则不成立
	idx1 := 0
	idx2 := 0
	var preV rune = '0'
	var c1 rune = '0'
	for idx1 < len(name) && idx2 < len(typed) {
		c1 = rune(name[idx1])
		c2 := rune(typed[idx2])
		if c1 == c2 {
			idx1++
			idx2++
			preV = c2
		} else if c2 == preV {
			idx2++
		} else {
			return false
		}
	}
	if idx1 != len(name) {
		return false
	}
	for idx2 < len(typed) {
		if rune(typed[idx2]) != c1 {
			return false
		}
		idx2++
	}
	return true
}

func main() {
	fmt.Println(isLongPressedName("pyplrz", "ppyypllr"))
}
