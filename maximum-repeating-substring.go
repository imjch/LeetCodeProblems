package main

import "strings"

// 该题比较特殊在于需要反向思考：很多时候backstrace不一定可取，因为相对复杂。在判定字符串包含是否包含多个连续字符串时，直接拿拼好的去做模式匹配更简单。
func maxRepeating(sequence string, word string) int {
	cnt := 0
	tmpW := word
	for len(word) <= len(sequence) {
		if strings.Index(sequence, word) != -1 {
			cnt++
		}
		word += tmpW
	}
	return cnt
}
