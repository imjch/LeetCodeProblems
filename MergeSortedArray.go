package main

import "fmt"

func merge(nums1 []int, m int, nums2 []int, n int) {
	if m == 0 {
		for i := 0; i < n; i++ {
			nums1[i] = nums2[i]
		}
	}
	bigestIdx := len(nums1) - 1
	m -= 1
	n -= 1
	for m >= 0 && n >= 0 {
		if nums1[m] >= nums2[n] {
			nums1[bigestIdx] = nums1[m]
			m--
		} else {
			nums1[bigestIdx] = nums2[n]
			n--
		}
		bigestIdx--
	}
	if n >= 0 {
		for i := n; i >= 0; i-- {
			nums1[i] = nums2[i]
		}
	}

}

func main() {
	nums1 := []int{4, 5, 6, 0, 0, 0} // Example nums1 array with extra space
	m := 3                           // Number of elements in nums1
	nums2 := []int{1, 2, 3}          // Example nums2 array
	n := 3                           // Number of elements in nums2

	merge(nums1, m, nums2, n)

	fmt.Println(nums1) // Output: [1 2 2 3 5 6]
}
