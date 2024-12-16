/*
Given two integers left and right that represent the range [left, right], return the bitwise AND of all numbers in this range, inclusive.

Example 1:

Input: left = 5, right = 7
Output: 4
Example 2:

Input: left = 0, right = 0
Output: 0
Example 3:

Input: left = 1, right = 2147483647
Output: 0

Constraints:

0 <= left <= right <= 231 - 1
*/
package main

import "fmt"

func rangeBitwiseAnd(left int, right int) int {
	cnt := 0
	for left != right {
		left >>= 1
		right >>= 1
		cnt++
	}
	right <<= cnt
	return right
}

func main() {
	fmt.Println(rangeBitwiseAnd(5, 7))
	fmt.Println(rangeBitwiseAnd(1, 2147483647))
	fmt.Println(rangeBitwiseAnd(700000000, 2147483641))
}
