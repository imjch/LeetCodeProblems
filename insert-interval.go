/*
You are given an array of non-overlapping intervals intervals where intervals[i] = [starti, endi] represent the start and the end of the ith interval and intervals is sorted in ascending order by starti. You are also given an interval newInterval = [start, end] that represents the start and end of another interval.

Insert newInterval into intervals such that intervals is still sorted in ascending order by starti and intervals still does not have any overlapping intervals (merge overlapping intervals if necessary).

Return intervals after the insertion.

Note that you don't need to modify intervals in-place. You can make a new array and return it.

Example 1:

Input: intervals = [[1,3],[6,9]], newInterval = [2,5]
Output: [[1,5],[6,9]]
Example 2:

Input: intervals = [[1,2],[3,5],[6,7],[8,10],[12,16]], newInterval = [4,8]
Output: [[1,2],[3,10],[12,16]]
Explanation: Because the new interval [4,8] overlaps with [3,5],[6,7],[8,10].
*/
package main

import "fmt"

func insert(intervals [][]int, newInterval []int) [][]int {
	if len(intervals) == 0 {
		return [][]int{newInterval}
	}
	res := [][]int{}
	idx := 0
	for ; idx < len(intervals); idx++ {
		if newI, has := isOverlap(intervals[idx], newInterval); has {
			newInterval = newI
		} else if newInterval[1] < intervals[idx][0] {
			break
		} else { // if newInterval[1] > intervals[idx][0]{
			res = append(res, intervals[idx])
		}
	}
	res = append(res, newInterval)
	for ; idx < len(intervals); idx++ {
		res = append(res, intervals[idx])
	}
	return res
}

func isOverlap(src []int, dst []int) ([]int, bool) {
	m := src[0]
	n := src[1]
	i := dst[0]
	j := dst[1]

	if m >= i && m <= j {
		if n >= j {
			return []int{i, n}, true
		} else {
			return []int{i, j}, true
		}
	}
	if n >= i && n <= j {
		if m >= i {
			return []int{i, j}, true
		} else {
			return []int{m, j}, true
		}
	}
	if m <= i && n >= j {
		return []int{m, n}, true
	}
	return []int{}, false
}

func main() {
	fmt.Println(insert([][]int{{1, 3}, {6, 9}}, []int{2, 5}))
	fmt.Println(insert([][]int{[]int{1, 5}}, []int{2, 7}))
	fmt.Println(insert([][]int{[]int{1, 5}}, []int{6, 8}))
	fmt.Println(insert([][]int{{1, 2}, {3, 5}, {6, 7}, {8, 10}, {12, 16}}, []int{4, 8}))
}
