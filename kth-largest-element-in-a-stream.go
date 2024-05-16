package main

import (
	"fmt"
	"sort"
)

type KthLargest struct {
	k          int
	sortedNums []int
}

func KthConstructor(k int, nums []int) KthLargest {
	sort.Slice(nums, func(i, j int) bool {
		return nums[i] < nums[j]
	})
	return KthLargest{
		k:          k,
		sortedNums: nums,
	}
}

func (this *KthLargest) Add(val int) int {
	if len(this.sortedNums) == 0 {
		this.sortedNums = append(this.sortedNums, val)
	} else if val > this.sortedNums[len(this.sortedNums)-1] {
		this.sortedNums = append(this.sortedNums, val)
	} else if val < this.sortedNums[0] {
		this.sortedNums = append([]int{val}, this.sortedNums...)
	} else {
		newNum := []int{}
		for i := 0; i < len(this.sortedNums)-1; i++ {
			if val >= this.sortedNums[i] && val <= this.sortedNums[i+1] {
				newNum = append(newNum, this.sortedNums[0:i+1]...)
				newNum = append(newNum, val)
				newNum = append(newNum, this.sortedNums[i+1:]...)
				this.sortedNums = newNum
				break
			}
		}
	}
	if this.k > len(this.sortedNums) {
		return this.sortedNums[len(this.sortedNums)-1]
	}
	return this.sortedNums[len(this.sortedNums)-this.k]
}

func main() {
	obj := KthConstructor(1, []int{})
	fmt.Println(obj.Add(3))
	fmt.Println(obj.Add(5))
	fmt.Println(obj.Add(10))
	fmt.Println(obj.Add(9))
	fmt.Println(obj.Add(4))
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * obj := Constructor(k, nums);
 * param_1 := obj.Add(val);
 */
