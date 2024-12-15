package main

import (
	"container/heap"
	"fmt"
)

type IntHeap [][]int

func (h IntHeap) Len() int           { return len(h) }
func (h IntHeap) Less(i, j int) bool { return h[i][0] <= h[j][0] }
func (h IntHeap) Swap(i, j int)      { h[i], h[j] = h[j], h[i] }

func (h *IntHeap) Push(x any) {
	*h = append(*h, x.([]int))
}

func (h *IntHeap) Pop() any {
	old := *h
	n := len(old)
	x := old[n-1]
	*h = old[0 : n-1]
	return x
}

func kSmallestPairs(nums1 []int, nums2 []int, k int) [][]int {
	res := [][]int{}

	h := &IntHeap{}
	heap.Init(h)

	idx := 0
	tmpK := k
	for idx < len(nums1) && tmpK > 0 {
		heap.Push(h, []int{nums1[idx] + nums2[0], idx, 0})
		tmpK--
		idx++
	}
	j := 0
	for k > 0 {
		v := heap.Pop(h)
		arr, _ := v.([]int)
		_, tmpI, tmpJ := arr[0], arr[1], arr[2]

		res = append(res, []int{nums1[tmpI], nums2[tmpJ]})

		j = tmpJ + 1
		if j < len(nums2) {
			heap.Push(h, []int{nums1[tmpI] + nums2[j], tmpI, j})
		}
		k--
	}
	return res
}

func main() {
	fmt.Print(kSmallestPairs([]int{1, 2, 4, 5, 6}, []int{3, 5, 7, 9}, 20))
	fmt.Print(kSmallestPairs([]int{1, 1, 2}, []int{1, 2, 3}, 2))
}
