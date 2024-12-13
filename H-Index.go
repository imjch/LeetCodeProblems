package main

import "fmt"

/*
Given an array of integers citations where citations[i] is the number of citations a researcher received for their ith paper, return the researcher's h-index.

According to the definition of h-index on Wikipedia: The h-index is defined as the maximum value of h such that the given researcher has published at least h papers that have each been cited at least h times.



Example 1:

Input: citations = [3,0,6,1,5]
Output: 3
Explanation: [3,0,6,1,5] means the researcher has 5 papers in total and each of them had received 3, 0, 6, 1, 5 citations respectively.
Since the researcher has 3 papers with at least 3 citations each and the remaining two with no more than 3 citations each, their h-index is 3.
Example 2:

Input: citations = [1,3,1]
Output: 1
*/

func hIndex(citations []int) int {
	max := 0
	for _, c := range citations {
		if c > max {
			max = c
		}
	}
	cntArr := make([]int, max+1, max+1)
	for _, c := range citations {
		cntArr[c] += 1
	}
	for i := 1; i < len(cntArr); i++ {
		cntArr[i] += cntArr[i-1]
	}
	cnt := len(citations)
	res := make([]int, cnt, cnt)
	for _, c := range citations {
		// reverse sort
		res[(cnt-1)-(cntArr[c]-1)] = c
		cntArr[c]--
	}
	fmt.Print(res)
	i := 0
	for ; i < len(res); i++ {
		if res[i] >= i+1 {
			continue
		} else {
			break
		}
	}
	return i
}

func main() {
	fmt.Print(hIndex([]int{1}))
}
